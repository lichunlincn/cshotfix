using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class GuidHeap : Heap
	{
		public GuidHeap(Section section, uint start, uint size) : base(section, start, size)
		{
		}
		public Guid Read(uint index)
		{
			if (index == 0u)
			{
				return default(Guid);
			}
			byte[] array = new byte[16];
			index -= 1u;
			Buffer.BlockCopy(this.Section.Data, (int)(this.Offset + index), array, 0, 16);
			return new Guid(array);
		}
	}
}
