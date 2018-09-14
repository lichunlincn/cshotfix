#region Header
/*
* The authors disclaim copyright to this source code.
* For more details, see the COPYING file included with this distribution.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace LITJson {

internal enum Condition {
	InArray,
	InObject,
	NotAProperty,
	Property,
	Value
}

internal class WriterContext {
	public int Count, Padding;
	public bool InArray, InObject;
	public bool ExpectingValue;
}

/// <summary>
/// Stream-like facility to output JSON text.
/// </summary>
public class JsonWriter {
	private static readonly NumberFormatInfo numberFormat;

	private WriterContext context;
	private Stack<WriterContext> ctxStack;
	private bool hasReachedEnd;
	private char[] hexSeq;
	private int indentation, indentValue;
	private StringBuilder stringBuilder;

	public int IndentValue {
		get { return indentValue; }
		set {
			indentation = (indentation / indentValue) * value;
			indentValue = value;
		}
	}

	public bool PrettyPrint { get; set; }
	public bool Validate { get; set; }
	public bool TypeHinting { get; set; }
	public string HintTypeName { get; set; }
	//public string HintValueName { get; set; }
    
    public Func<Type, int> TypeWriter { get; set; }

    public TextWriter TextWriter { get; private set; }

	static JsonWriter() {
		numberFormat = NumberFormatInfo.InvariantInfo;
	}

	public JsonWriter() {
		stringBuilder = new StringBuilder();
		TextWriter = new StringWriter(stringBuilder);
		Init();
	}

	public JsonWriter(StringBuilder sb) : this(new StringWriter(sb)) {
	}

	public JsonWriter(TextWriter writer) {
		if (writer == null) {
			throw new ArgumentNullException("writer");
		}
		this.TextWriter = writer;
		Init();
	}

	private void DoValidation(Condition cond) {
		if (!context.ExpectingValue) {
			context.Count++;
		}
		if (!Validate) {
			return;
		}
		if (hasReachedEnd) {
			throw new JsonException("A complete JSON symbol has already been written");
		}
		switch (cond) {
		case Condition.InArray:
			if (!context.InArray) {
				throw new JsonException("Can't close an array here");
			}
			break;
		case Condition.InObject:
			if (!context.InObject || context.ExpectingValue) {
				throw new JsonException("Can't close an object here");
			}
			break;
		case Condition.NotAProperty:
			if (context.InObject && !context.ExpectingValue) {
				throw new JsonException("Expected a property in obj? "+context.InObject+" expect val? "+context.ExpectingValue+" <"+stringBuilder.ToString()+">");
			}
			break;

		case Condition.Property:
			if (!context.InObject || context.ExpectingValue) {
				throw new JsonException("Can't add a property here");
			}
			break;
        // NV Allow for Pure Values
        //case Condition.Value:
        //    if (!context.InArray &&
        //       (!context.InObject || !context.ExpectingValue)) {
        //        throw new JsonException("Can't add a value here");
        //    }
        //    break;
		}
	}

	private void Init() {
		hasReachedEnd = false;
		hexSeq = new char[4];
		indentation = 0;
		indentValue = 4;
		PrettyPrint = false;
		Validate = true;

		TypeHinting = false;
		HintTypeName = "_t";
		//HintValueName = "_v";

		ctxStack = new Stack<WriterContext>();
		context = new WriterContext();
		ctxStack.Push(context);
	}

	private static void IntToHex(int n, char[] hex) {
		int num;
		for (int i = 0; i < 4; i++) {
			num = n % 16;
			if (num < 10) {
				hex[3 - i] = (char) ('0' + num);
			} else {
				hex[3 - i] = (char) ('A' + (num - 10));
			}
			n >>= 4;
		}
	}

	private void Indent() {
		if (PrettyPrint) {
			indentation += indentValue;
		}
	}

	private void Put(string str) {
		if (PrettyPrint && !context.ExpectingValue) {
			for (int i = 0; i < indentation; i++) {
				TextWriter.Write(' ');
			}
		}
		TextWriter.Write(str);
	}

		
	private void PutNewline() {
			PutNewline (true);
	}

	private void PutNewline(bool addComma) {
		if (addComma && !context.ExpectingValue && context.Count > 1) {
			TextWriter.Write(',');
		}
		if (PrettyPrint && !context.ExpectingValue) {
			TextWriter.Write(Environment.NewLine);
		}
	}

	private void PutString(string str) {
		Put(string.Empty);
		TextWriter.Write('"');
		int n = str.Length;
		for (int i = 0; i < n; i++) {
			switch (str[i]) {
			case '\n':
				TextWriter.Write("\\n");
				continue;
			case '\r':
				TextWriter.Write("\\r");
				continue;
			case '\t':
				TextWriter.Write("\\t");
				continue;
			case '"':
			case '\\':
				TextWriter.Write('\\');
				TextWriter.Write(str[i]);
				continue;
			case '\f':
				TextWriter.Write("\\f");
				continue;
			case '\b':
				TextWriter.Write("\\b");
				continue;
			}
			if ((int)str[i] >= 32 && (int)str[i] <= 126) {
				TextWriter.Write(str[i]);
				continue;
			}
			// Default, turn into a \uXXXX sequence
			//IntToHex ((int)str[i], hexSeq);
			//TextWriter.Write("\\u");
			//TextWriter.Write(hexSeq);
			TextWriter.Write(str[i]);
		}
		TextWriter.Write('"');
	}

	private void Unindent() {
		if (PrettyPrint) {
			indentation -= indentValue;
		}
	}

	public override string ToString() {
		if (stringBuilder == null) {
			return string.Empty;
		}
		return stringBuilder.ToString();
	}

	public void Reset() {
		hasReachedEnd = false;

		ctxStack.Clear();
		context = new WriterContext();
		ctxStack.Push(context);

		if (stringBuilder != null) {
			stringBuilder.Remove(0, stringBuilder.Length);
		}
	}

	public void Write(bool boolean) {
		DoValidation(Condition.Value);
		PutNewline();
		Put(boolean ? "true" : "false");
		context.ExpectingValue = false;
	}

	public void Write(double number) {
		DoValidation(Condition.Value);
		PutNewline();
		string str = number.ToString("R", numberFormat);
		Put(str);
		if (str.IndexOf('.') == -1 && str.IndexOf('E') == -1) {
			TextWriter.Write(".0");
		}
		context.ExpectingValue = false;
	}

	public void Write(decimal number) {
		DoValidation(Condition.Value);
		PutNewline();
		Put(Convert.ToString(number, numberFormat));
		context.ExpectingValue = false;
	}

	public void Write(long number) {
		DoValidation(Condition.Value);
		PutNewline();
		Put(Convert.ToString(number, numberFormat));
		context.ExpectingValue = false;
	}

	public void Write(ulong number) {
		DoValidation(Condition.Value);
		PutNewline();
		Put(Convert.ToString(number, numberFormat));
		context.ExpectingValue = false;
	}

	public void Write(string str) {
		DoValidation(Condition.Value);
		PutNewline();
		if (str == null) {
			Put("null");
		} else {
			PutString(str);
		}
		context.ExpectingValue = false;
	}

	public void WriteArrayEnd() {
		DoValidation(Condition.InArray);
		PutNewline(false);
		ctxStack.Pop();
		if (ctxStack.Count == 1) {
			hasReachedEnd = true;
		} else {
			context = ctxStack.Peek();
			context.ExpectingValue = false;
		}
		Unindent();
		Put("]");
	}

	public void WriteArrayStart() {
		DoValidation(Condition.NotAProperty);
		PutNewline();
		Put("[");
		context = new WriterContext ();
		context.InArray = true;
		ctxStack.Push (context);
		Indent();
	}

	public void WriteObjectEnd() {
		DoValidation(Condition.InObject);
		PutNewline(false);
		ctxStack.Pop();
		if (ctxStack.Count == 1) {
			hasReachedEnd = true;
		} else {
			context = ctxStack.Peek();
			context.ExpectingValue = false;
		}
		Unindent();
		Put("}");
	}

	public void WriteObjectStart() {
		DoValidation(Condition.NotAProperty);
		PutNewline();
		Put("{");
		context = new WriterContext();
		context.InObject = true;
		ctxStack.Push(context);
		Indent();
	}

	public void WritePropertyName(string name) {
		DoValidation(Condition.Property);
		PutNewline();
		PutString(name);
		if (PrettyPrint) {
			if (name.Length > context.Padding) {
				context.Padding = name.Length;
			}
			for (int i = context.Padding - name.Length; i >= 0; i--) {
				TextWriter.Write(' ');
			}
			TextWriter.Write(": ");
		} else {
			TextWriter.Write(':');
		}
		context.ExpectingValue = true;
	}

        public void WriteType(Type type)
        {
            WritePropertyName(HintTypeName);
            if (TypeWriter != null)
            {
                int typeId = TypeWriter(type);
                Write(typeId);
            }
            else
            {
                Write(type.AssemblyQualifiedName);
            }
        }
    }

}
