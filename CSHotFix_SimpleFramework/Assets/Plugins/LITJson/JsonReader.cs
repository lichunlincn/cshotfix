#region Header
/*
 * The authors disclaim copyright to this source code.
 * For more details, see the COPYING file included with this distribution.
 */
#endregion

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LITJson {

public enum JsonToken {
	None,
	Null,

	ObjectStart,
	PropertyName,
	ObjectEnd,

	ArrayStart,
	ArrayEnd,

	Real,
	Natural,

	String,

	Boolean
}

/// <summary>
/// Stream-like access to JSON text.
/// </summary>
public class JsonReader {
	private static readonly IDictionary<int, IDictionary<int, int[]>> parseTable;

	private Stack<int> automationStack;
	private Lexer lexer;
	private TextReader reader;
	private int currentInput, currentSymbol;
	private bool parserInString, parserReturn;
	private bool readStarted, readerIsOwned;

	public bool AllowComments {
		get { return lexer.AllowComments; }
		set { lexer.AllowComments = value; }
	}

	public bool AllowSingleQuotedStrings {
		get { return lexer.AllowSingleQuotedStrings; }
		set { lexer.AllowSingleQuotedStrings = value; }
	}

	public bool SkipNonMembers { get; set; }
	public bool TypeHinting { get; set; }
	public string HintTypeName { get; set; }
	//public string HintValueName { get; set; }

	public bool EndOfInput { get; private set; }
	public bool EndOfJson { get; private set; }
	public JsonToken Token { get; private set; }
	public object Value { get; private set; }

    public Func<object,Type> TypeReader { get; set; }

    public JsonReader(string json) : this(new StringReader(json), true) {
	}

	public JsonReader(TextReader reader) : this(reader, false) {
	}

	private JsonReader(TextReader reader, bool owned) {
		if (reader == null) {
			throw new ArgumentNullException("reader");
		}
		parserInString = false;
		parserReturn = false;

		readStarted = false;
		automationStack = new Stack<int>();
		automationStack.Push((int)ParserToken.End);
		automationStack.Push((int)ParserToken.Text);

		lexer = new Lexer(reader);

		EndOfInput = false;
		EndOfJson = false;

		SkipNonMembers = true;

		this.reader = reader;
		readerIsOwned = owned;

		TypeHinting = false;
        HintTypeName = "_t";
        //HintValueName = "_v";
    }

	static JsonReader() {
		// Populate parse table
		// See section A.2. of the manual for details
		parseTable = new Dictionary<int, IDictionary<int, int[]>>();

		TableAddRow(ParserToken.Array);
		TableAddCol(ParserToken.Array, '[',
					 '[',
					 (int)ParserToken.ArrayPrime);

		TableAddRow(ParserToken.ArrayPrime);
		TableAddCol(ParserToken.ArrayPrime, '"',
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, '[',
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, ']',
					 ']');

		TableAddCol(ParserToken.ArrayPrime, '{',
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, (int)ParserToken.Number,
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, (int)ParserToken.True,
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, (int)ParserToken.False,
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddCol(ParserToken.ArrayPrime, (int)ParserToken.Null,
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest,
					 ']');

		TableAddRow(ParserToken.Object);
		TableAddCol(ParserToken.Object, '{',
					 '{',
					 (int)ParserToken.ObjectPrime);

		TableAddRow(ParserToken.ObjectPrime);
		TableAddCol(ParserToken.ObjectPrime, '"',
					 (int)ParserToken.Pair,
					 (int)ParserToken.PairRest,
					 '}');

		TableAddCol(ParserToken.ObjectPrime, '}',
					 '}');

		TableAddRow(ParserToken.Pair);
		TableAddCol(ParserToken.Pair, '"',
					 (int)ParserToken.String,
					 ':',
					 (int)ParserToken.Value);

		TableAddRow(ParserToken.PairRest);
		TableAddCol(ParserToken.PairRest, ',',
					 ',',
					 (int)ParserToken.Pair,
					 (int)ParserToken.PairRest);

		TableAddCol(ParserToken.PairRest, '}',
					 (int)ParserToken.Epsilon);

		TableAddRow(ParserToken.String);
		TableAddCol(ParserToken.String, '"',
					 '"',
					 (int)ParserToken.CharSeq,
					 '"');

		TableAddRow(ParserToken.Text);
		TableAddCol(ParserToken.Text, '[',
					 (int)ParserToken.Array);
		TableAddCol(ParserToken.Text, '{',
					 (int)ParserToken.Object);

		TableAddRow(ParserToken.Value);
		TableAddCol(ParserToken.Value, '"',
					 (int)ParserToken.String);
		TableAddCol(ParserToken.Value, '[',
					 (int)ParserToken.Array);
		TableAddCol(ParserToken.Value, '{',
					 (int)ParserToken.Object);
		TableAddCol(ParserToken.Value, (int)ParserToken.Number,
					 (int)ParserToken.Number);
		TableAddCol(ParserToken.Value, (int)ParserToken.True,
					 (int)ParserToken.True);
		TableAddCol(ParserToken.Value, (int)ParserToken.False,
					 (int)ParserToken.False);
		TableAddCol(ParserToken.Value, (int)ParserToken.Null,
					 (int)ParserToken.Null);

		TableAddRow(ParserToken.ValueRest);
		TableAddCol(ParserToken.ValueRest, ',',
					 ',',
					 (int)ParserToken.Value,
					 (int)ParserToken.ValueRest);

		TableAddCol(ParserToken.ValueRest, ']',
					 (int)ParserToken.Epsilon);
	}

	private static void TableAddCol(ParserToken row, int col, params int[] symbols) {
		parseTable[(int)row].Add(col, symbols);
	}

	private static void TableAddRow(ParserToken rule) {
		parseTable.Add((int)rule, new Dictionary<int, int[]>());
	}

	private void ProcessNumber(string number) {
		if (number.IndexOf('.') != -1 ||
			number.IndexOf('e') != -1 ||
			number.IndexOf('E') != -1) {

			double real;
			if (double.TryParse (number, out real)) {
				Token = JsonToken.Real;
				Value = real;
				return;
			}
		}
		long natural;
		if (long.TryParse (number, out natural)) {
			Token = JsonToken.Natural;
			Value = natural;
			return;
		}
		ulong unsignednatural;
		if (ulong.TryParse(number, out unsignednatural)) {
			Token = JsonToken.Natural;
			Value = unsignednatural;
			return;
		}
		decimal decimalreal;
		if (Decimal.TryParse(number, out decimalreal)) {
			Token = JsonToken.Real;
			Value = decimalreal;

			return;
		}
		// Shouldn't happen, but just in case, return something
		Token = JsonToken.Natural;
		Value = 0;

		throw new JsonException(string.Format("Failed to parse number '{0}'", number));
	}

	private void ProcessSymbol() {
		if (currentSymbol == '[')  {
			Token = JsonToken.ArrayStart;
			parserReturn = true;
		} else if (currentSymbol == ']')  {
			Token = JsonToken.ArrayEnd;
			parserReturn = true;
		} else if (currentSymbol == '{')  {
			Token = JsonToken.ObjectStart;
			parserReturn = true;
		} else if (currentSymbol == '}')  {
			Token = JsonToken.ObjectEnd;
			parserReturn = true;
		} else if (currentSymbol == '"')  {
			if (parserInString) {
				parserInString = false;
				parserReturn = true;
			} else {
				if (Token == JsonToken.None) {
					Token = JsonToken.String;
				}
				parserInString = true;
			}
		} else if (currentSymbol == (int)ParserToken.CharSeq) {
			Value = lexer.StringValue;
		} else if (currentSymbol == (int)ParserToken.False)  {
			Token = JsonToken.Boolean;
			Value = false;
			parserReturn = true;
		} else if (currentSymbol == (int)ParserToken.Null)  {
			Token = JsonToken.Null;
			parserReturn = true;
		} else if (currentSymbol == (int)ParserToken.Number)  {
			ProcessNumber (lexer.StringValue);
			parserReturn = true;
		} else if (currentSymbol == (int)ParserToken.Pair)  {
			Token = JsonToken.PropertyName;
		} else if (currentSymbol == (int)ParserToken.True)  {
			Token = JsonToken.Boolean;
			Value = true;
			parserReturn = true;
		}
	}

	private bool ReadToken() {
		if (EndOfInput) {
			return false;
		}
		lexer.NextToken();
		if (lexer.EndOfInput) {
			Close();
			return false;
		}
		currentInput = lexer.Token;
		return true;
	}

	public void Close() {
		if (EndOfInput) {
			return;
		}
		EndOfInput = true;
		EndOfJson  = true;
		if (readerIsOwned) {
			reader.Close();
		}
		reader = null;
	}

    public Type ReadType()
    {
        Read();
        if (TypeReader != null)
            return TypeReader(Value);

        string typeName = (string)Value;
        return Type.GetType(typeName);
    }

	public bool Read() {
		if (EndOfInput) {
			return false;
		}
		if (EndOfJson) {
			EndOfJson = false;
			automationStack.Clear();
			automationStack.Push((int)ParserToken.End);
			automationStack.Push((int)ParserToken.Text);
		}
		parserInString = false;
		parserReturn = false;

		Token = JsonToken.None;
		Value = null;

		if (!readStarted) {
			readStarted = true;
			if (!ReadToken()) {
				return false;
			}
		}
		int[] entrySymbols;
		while (true) {
			if (parserReturn) {
				if (automationStack.Peek() == (int)ParserToken.End) {
					EndOfJson = true;
				}
				return true;
			}
			currentSymbol = automationStack.Pop();
			ProcessSymbol();
			if (currentSymbol == currentInput) {
				if (!ReadToken()) {
					if (automationStack.Peek() != (int)ParserToken.End) {
						throw new JsonException("Input doesn't evaluate to proper JSON text");
					}
					if (parserReturn) {
						return true;
					}
					return false;
				}
				continue;
			}
			try {
				entrySymbols = parseTable[currentSymbol][currentInput];
			} catch (KeyNotFoundException e) {
				throw new JsonException((ParserToken)currentInput, e);
			}
			if (entrySymbols[0] == (int)ParserToken.Epsilon) {
				continue;
			}
			for (int i = entrySymbols.Length - 1; i >= 0; i--) {
				automationStack.Push(entrySymbols[i]);
			}
		}
	}
}

}
