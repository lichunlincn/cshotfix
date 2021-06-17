using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class UserStringHeapBuffer : StringHeapBuffer
	{
		protected override void WriteString(string @string)
		{
			base.WriteCompressedUInt32((uint)(@string.Length * 2 + 1));
			byte b = 0;
			for (int i = 0; i < @string.Length; i++)
			{
				char c = @string[i];
				base.WriteUInt16((ushort)c);
				if (b != 1 && (c < ' ' || c > '~') && (c > '~' || (c >= '\u0001' && c <= '\b') || (c >= '\u000e' && c <= '\u001f') || c == '\'' || c == '-'))
				{
					b = 1;
				}
			}
			base.WriteByte(b);
		}
	}
}
