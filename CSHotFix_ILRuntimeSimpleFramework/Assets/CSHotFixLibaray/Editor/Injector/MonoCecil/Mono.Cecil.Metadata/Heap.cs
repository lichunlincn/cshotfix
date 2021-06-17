using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal abstract class Heap
	{
		public int IndexSize;
		public readonly Section Section;
		public readonly uint Offset;
		public readonly uint Size;
		protected Heap(Section section, uint offset, uint size)
		{
			this.Section = section;
			this.Offset = offset;
			this.Size = size;
		}
	}
}
