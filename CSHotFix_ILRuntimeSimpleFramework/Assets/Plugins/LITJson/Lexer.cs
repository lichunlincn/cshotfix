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

internal class FsmContext {
	public Lexer L;
	public bool Return;
	public int NextState, StateStack;
}

/// <summary>
/// JSON lexer implementation based on a finite state machine.
/// </summary>
internal class Lexer {
	private delegate bool StateHandler (FsmContext ctx);

	private static int[] returnTable;
	private static StateHandler[] handlerTable;

	private int inputBuffer, inputChar, state, unichar;
	private FsmContext context;
	private TextReader reader;
	private StringBuilder stringBuffer;

	public bool AllowComments { get; set; }
	public bool AllowSingleQuotedStrings { get; set; }

	public bool EndOfInput { get; private set; }
	public int Token { get; private set; }
	public string StringValue { get; private set; }

	static Lexer() {
		PopulateFsmTables();
	}

	public Lexer(TextReader reader) {
		AllowComments = true;
		AllowSingleQuotedStrings = true;

		inputBuffer = 0;
		stringBuffer = new StringBuilder(128);
		state = 1;
		EndOfInput = false;
		this.reader = reader;

		context = new FsmContext();
		context.L = this;
	}

	private static int HexValue(int digit) {
		switch (digit) {
		case 'a':
		case 'A':
			return 10;
		case 'b':
		case 'B':
			return 11;
		case 'c':
		case 'C':
			return 12;
		case 'd':
		case 'D':
			return 13;
		case 'e':
		case 'E':
			return 14;
		case 'f':
		case 'F':
			return 15;
		default:
			return digit - '0';
		}
	}

	private static void PopulateFsmTables() {
		// See section A.1. of the manual for details of the finite state machine.
		handlerTable = new StateHandler[28] {
			State1,
			State2,
			State3,
			State4,
			State5,
			State6,
			State7,
			State8,
			State9,
			State10,
			State11,
			State12,
			State13,
			State14,
			State15,
			State16,
			State17,
			State18,
			State19,
			State20,
			State21,
			State22,
			State23,
			State24,
			State25,
			State26,
			State27,
			State28
		};

		returnTable = new int[28] {
			(int)ParserToken.Char,
			0,
			(int)ParserToken.Number,
			(int)ParserToken.Number,
			0,
			(int)ParserToken.Number,
			0,
			(int)ParserToken.Number,
			0,
			0,
			(int)ParserToken.True,
			0,
			0,
			0,
			(int)ParserToken.False,
			0,
			0,
			(int)ParserToken.Null,
			(int)ParserToken.CharSeq,
			(int)ParserToken.Char,
			0,
			0,
			(int)ParserToken.CharSeq,
			(int)ParserToken.Char,
			0,
			0,
			0,
			0
		};
	}

	private static char ProcessEscChar (int escChar) {
		switch (escChar) {
		case '"':
		case '\'':
		case '\\':
		case '/':
			return Convert.ToChar(escChar);
		case 'n':
			return '\n';
		case 't':
			return '\t';
		case 'r':
			return '\r';
		case 'b':
			return '\b';
		case 'f':
			return '\f';
		default:
			// Unreachable
			return '?';
		}
	}

	private static bool State1(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar == ' ' ||
				ctx.L.inputChar >= '\t' && ctx.L.inputChar <= '\r') {
				continue;
			}
			if (ctx.L.inputChar >= '1' && ctx.L.inputChar <= '9') {
				ctx.L.stringBuffer.Append ((char) ctx.L.inputChar);
				ctx.NextState = 3;
				return true;
			}
			switch (ctx.L.inputChar) {
			case '"':
				ctx.NextState = 19;
				ctx.Return = true;
				return true;
			case ',':
			case ':':
			case '[':
			case ']':
			case '{':
			case '}':
				ctx.NextState = 1;
				ctx.Return = true;
				return true;
			case '-':
				ctx.L.stringBuffer.Append ((char) ctx.L.inputChar);
				ctx.NextState = 2;
				return true;
			case '0':
				ctx.L.stringBuffer.Append ((char) ctx.L.inputChar);
				ctx.NextState = 4;
				return true;
			case 'f':
				ctx.NextState = 12;
				return true;
			case 'n':
				ctx.NextState = 16;
				return true;
			case 't':
				ctx.NextState = 9;
				return true;
			case '\'':
				if (!ctx.L.AllowSingleQuotedStrings) {
					return false;
				}
				ctx.L.inputChar = '"';
				ctx.NextState = 23;
				ctx.Return = true;
				return true;
			case '/':
				if (!ctx.L.AllowComments) {
					return false;
				}
				ctx.NextState = 25;
				return true;
			default:
				return false;
			}
		}
		return true;
	}

	private static bool State2(FsmContext ctx) {
		ctx.L.GetChar();
		if (ctx.L.inputChar >= '1' && ctx.L.inputChar <= '9') {
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 3;
			return true;
		}
		switch (ctx.L.inputChar) {
		case '0':
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 4;
			return true;
		default:
			return false;
		}
	}

	private static bool State3(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9') {
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				continue;
			}
			if (ctx.L.inputChar == ' ' ||
				ctx.L.inputChar >= '\t' && ctx.L.inputChar <= '\r') {
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
			switch (ctx.L.inputChar) {
			case ',':
			case ']':
			case '}':
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			case '.':
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				ctx.NextState = 5;
				return true;
			case 'e':
			case 'E':
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				ctx.NextState = 7;
				return true;
			default:
				return false;
			}
		}
		return true;
	}

	private static bool State4(FsmContext ctx) {
		ctx.L.GetChar ();
		if (ctx.L.inputChar == ' ' ||
			ctx.L.inputChar >= '\t' && ctx.L.inputChar <= '\r') {
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		}
		switch (ctx.L.inputChar) {
		case ',':
		case ']':
		case '}':
			ctx.L.UngetChar ();
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		case '.':
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 5;
			return true;
		case 'e':
		case 'E':
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 7;
			return true;
		default:
			return false;
		}
	}

	private static bool State5(FsmContext ctx) {
		ctx.L.GetChar();
		if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9') {
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 6;
			return true;
		}
		return false;
	}

	private static bool State6(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9') {
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				continue;
			}
			if (ctx.L.inputChar == ' ' ||
				ctx.L.inputChar >= '\t' && ctx.L.inputChar <= '\r') {
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
			switch (ctx.L.inputChar) {
			case ',':
			case ']':
			case '}':
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			case 'e':
			case 'E':
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				ctx.NextState = 7;
				return true;
			default:
				return false;
			}
		}
		return true;
	}

	private static bool State7(FsmContext ctx) {
		ctx.L.GetChar();
		if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9') {
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 8;
			return true;
		}
		switch (ctx.L.inputChar) {
		case '+':
		case '-':
			ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
			ctx.NextState = 8;
			return true;
		default:
			return false;
		}
	}

	private static bool State8(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9') {
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				continue;
			}
			if (ctx.L.inputChar == ' ' ||
				ctx.L.inputChar >= '\t' && ctx.L.inputChar <= '\r') {
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			}
			switch (ctx.L.inputChar) {
			case ',':
			case ']':
			case '}':
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 1;
				return true;
			default:
				return false;
			}
		}
		return true;
	}

	private static bool State9(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'r':
			ctx.NextState = 10;
			return true;
		default:
			return false;
		}
	}

	private static bool State10(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'u':
			ctx.NextState = 11;
			return true;
		default:
			return false;
		}
	}

	private static bool State11(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'e':
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		default:
			return false;
		}
	}

	private static bool State12(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'a':
			ctx.NextState = 13;
			return true;
		default:
			return false;
		}
	}

	private static bool State13(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'l':
			ctx.NextState = 14;
			return true;
		default:
			return false;
		}
	}

	private static bool State14(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 's':
			ctx.NextState = 15;
			return true;
		default:
			return false;
		}
	}

	private static bool State15(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'e':
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		default:
			return false;
		}
	}

	private static bool State16(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'u':
			ctx.NextState = 17;
			return true;
		default:
			return false;
		}
	}

	private static bool State17(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'l':
			ctx.NextState = 18;
			return true;
		default:
			return false;
		}
	}

	private static bool State18(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'l':
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		default:
			return false;
		}
	}

	private static bool State19(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			switch (ctx.L.inputChar) {
			case '"':
				ctx.L.UngetChar ();
				ctx.Return = true;
				ctx.NextState = 20;
				return true;
			case '\\':
				ctx.StateStack = 19;
				ctx.NextState = 21;
				return true;
			default:
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				continue;
			}
		}
		return true;
	}

	private static bool State20(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case '"':
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		default:
			return false;
		}
	}

	private static bool State21(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case 'u':
			ctx.NextState = 22;
			return true;
		case '"':
		case '\'':
		case '/':
		case '\\':
		case 'b':
		case 'f':
		case 'n':
		case 'r':
		case 't':
			ctx.L.stringBuffer.Append(ProcessEscChar(ctx.L.inputChar));
			ctx.NextState = ctx.StateStack;
			return true;
		default:
			return false;
		}
	}

	private static bool State22(FsmContext ctx) {
		int counter = 0;
		int mult = 4096;
		ctx.L.unichar = 0;
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar >= '0' && ctx.L.inputChar <= '9' ||
				ctx.L.inputChar >= 'A' && ctx.L.inputChar <= 'F' ||
				ctx.L.inputChar >= 'a' && ctx.L.inputChar <= 'f') {

				ctx.L.unichar += HexValue (ctx.L.inputChar) * mult;
				counter++;
				mult /= 16;
				if (counter == 4) {
					ctx.L.stringBuffer.Append(Convert.ToChar(ctx.L.unichar));
					ctx.NextState = ctx.StateStack;
					return true;
				}
				continue;
			}
			return false;
		}
		return true;
	}

	private static bool State23(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			switch (ctx.L.inputChar) {
			case '\'':
				ctx.L.UngetChar();
				ctx.Return = true;
				ctx.NextState = 24;
				return true;
			case '\\':
				ctx.StateStack = 23;
				ctx.NextState = 21;
				return true;
			default:
				ctx.L.stringBuffer.Append((char)ctx.L.inputChar);
				continue;
			}
		}
		return true;
	}

	private static bool State24(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case '\'':
			ctx.L.inputChar = '"';
			ctx.Return = true;
			ctx.NextState = 1;
			return true;
		default:
			return false;
		}
	}

	private static bool State25(FsmContext ctx) {
		ctx.L.GetChar();
		switch (ctx.L.inputChar) {
		case '*':
			ctx.NextState = 27;
			return true;
		case '/':
			ctx.NextState = 26;
			return true;
		default:
			return false;
		}
	}

	private static bool State26(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar == '\n') {
				ctx.NextState = 1;
				return true;
			}
		}
		return true;
	}

	private static bool State27(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar == '*') {
				ctx.NextState = 28;
				return true;
			}
		}
		return true;
	}

	private static bool State28(FsmContext ctx) {
		while (ctx.L.GetChar()) {
			if (ctx.L.inputChar == '*') {
				continue;
			}
			if (ctx.L.inputChar == '/') {
				ctx.NextState = 1;
				return true;
			}
			ctx.NextState = 27;
			return true;
		}
		return true;
	}

	private bool GetChar() {
		if ((inputChar = NextChar()) != -1) {
			return true;
		}
		EndOfInput = true;
		return false;
	}

	private int NextChar() {
		if (inputBuffer != 0) {
			int tmp = inputBuffer;
			inputBuffer = 0;
			return tmp;
		}
		return reader.Read();
	}

	public bool NextToken() {
		StateHandler handler;
		context.Return = false;
		while (true) {
			handler = handlerTable[state - 1];
			if (!handler(context)) {
				throw new JsonException(inputChar);
			}
			if (EndOfInput) {
				return false;
			}
			if (context.Return) {
				StringValue = stringBuffer.ToString();
				stringBuffer.Remove(0, stringBuffer.Length);
				Token = returnTable[state - 1];
				if (Token == (int)ParserToken.Char) {
					Token = inputChar;
				}
				state = context.NextState;
				return true;
			}
			state = context.NextState;
		}
	}

	private void UngetChar() {
		inputBuffer = inputChar;
	}
}

}
