#region Header
/*
 * The authors disclaim copyright to this source code.
 * For more details, see the COPYING file included with this distribution.
 */
#endregion

using System;

namespace LITJson {

	/// <summary>
	/// Base class throwed by LitJson when a parsing error occurs.
	/// </summary>
	public class JsonException : Exception {

		public JsonException() : base() {}

		internal JsonException(ParserToken token) : base(string.Format("Invalid token '{0}' in input string", token)){ }

		internal JsonException(ParserToken token, Exception inner) : base(string.Format("Invalid token '{0}' in input string", token), inner){ }

		internal JsonException(int c) : base(string.Format("Invalid character '{0}' in input string", (char)c)){ }
		
		internal JsonException(int c, Exception inner) : base(string.Format("Invalid character '{0}' in input string", (char)c), inner){ }
		
		public JsonException(string message) : base(message){ }

		public JsonException(string message, Exception inner) : base(message, inner){ }
	}

}
