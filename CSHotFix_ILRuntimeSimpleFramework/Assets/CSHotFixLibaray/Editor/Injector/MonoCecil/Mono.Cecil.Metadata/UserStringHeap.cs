using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class UserStringHeap : StringHeap
	{
		public UserStringHeap(Section section, uint start, uint size) : base(section, start, size)
		{
		}
		protected override string ReadStringAt(uint index)
		{
			byte[] data = this.Section.Data;
			int num = (int)(index + this.Offset);
			uint num2 = (uint)((ulong)data.ReadCompressedUInt32(ref num) & 18446744073709551614uL);
			if (num2 < 1u)
			{
				return string.Empty;
			}
			char[] array = new char[num2 / 2u];
			int num3 = num;
			int num4 = 0;
			while ((long)num3 < (long)num + (long)((ulong)num2))
			{
				array[num4++] = (char)((int)data[num3] | (int)data[num3 + 1] << 8);
				num3 += 2;
			}
			return new string(array);
		}
	}
}
