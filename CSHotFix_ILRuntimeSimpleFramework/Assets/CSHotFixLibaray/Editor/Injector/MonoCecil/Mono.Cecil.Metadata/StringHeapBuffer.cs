using System;
using System.Collections.Generic;
using System.Text;
namespace Editor_Mono.Cecil.Metadata
{
	internal class StringHeapBuffer : HeapBuffer
	{
		private readonly Dictionary<string, uint> strings = new Dictionary<string, uint>(StringComparer.Ordinal);
		public sealed override bool IsEmpty
		{
			get
			{
				return this.length <= 1;
			}
		}
		public StringHeapBuffer() : base(1)
		{
			base.WriteByte(0);
		}
		public uint GetStringIndex(string @string)
		{
			uint position;
			if (this.strings.TryGetValue(@string, out position))
			{
				return position;
			}
			position = (uint)this.position;
			this.WriteString(@string);
			this.strings.Add(@string, position);
			return position;
		}
		protected virtual void WriteString(string @string)
		{
			base.WriteBytes(Encoding.UTF8.GetBytes(@string));
			base.WriteByte(0);
		}
	}
}
