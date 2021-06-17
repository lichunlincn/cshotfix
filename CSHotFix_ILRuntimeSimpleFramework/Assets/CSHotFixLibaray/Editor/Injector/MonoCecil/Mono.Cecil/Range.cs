using System;
namespace Editor_Mono.Cecil
{
	internal struct Range
	{
		public uint Start;
		public uint Length;
		public Range(uint index, uint length)
		{
			this.Start = index;
			this.Length = length;
		}
	}
}
