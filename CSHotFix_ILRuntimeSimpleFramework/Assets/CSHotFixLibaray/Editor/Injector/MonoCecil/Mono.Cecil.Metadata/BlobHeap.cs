using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class BlobHeap : Heap
	{
		public BlobHeap(Section section, uint start, uint size) : base(section, start, size)
		{
		}
		public byte[] Read(uint index)
		{
			if (index == 0u || index > this.Size - 1u)
			{
				return Empty<byte>.Array;
			}
			byte[] data = this.Section.Data;
			int num = (int)(index + this.Offset);
			int num2 = (int)data.ReadCompressedUInt32(ref num);
			if (num2 > data.Length - num)
			{
				return Empty<byte>.Array;
			}
			byte[] array = new byte[num2];
			Buffer.BlockCopy(data, num, array, 0, num2);
			return array;
		}
	}
}
