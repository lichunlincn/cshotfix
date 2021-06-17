using System;
namespace Editor_Mono.Cecil.PE
{
	internal sealed class TextMap
	{
		private readonly Range[] map = new Range[16];
		public void AddMap(TextSegment segment, int length)
		{
			this.map[(int)segment] = new Range(this.GetStart(segment), (uint)length);
		}
		public void AddMap(TextSegment segment, int length, int align)
		{
			align--;
			this.AddMap(segment, length + align & ~align);
		}
		public void AddMap(TextSegment segment, Range range)
		{
			this.map[(int)segment] = range;
		}
		public Range GetRange(TextSegment segment)
		{
			return this.map[(int)segment];
		}
		public DataDirectory GetDataDirectory(TextSegment segment)
		{
			Range range = this.map[(int)segment];
			return new DataDirectory((range.Length == 0u) ? 0u : range.Start, range.Length);
		}
		public uint GetRVA(TextSegment segment)
		{
			return this.map[(int)segment].Start;
		}
		public uint GetNextRVA(TextSegment segment)
		{
			return this.map[(int)segment].Start + this.map[(int)segment].Length;
		}
		public int GetLength(TextSegment segment)
		{
			return (int)this.map[(int)segment].Length;
		}
		private uint GetStart(TextSegment segment)
		{
			if (segment != TextSegment.ImportAddressTable)
			{
				return this.ComputeStart((int)segment);
			}
			return 8192u;
		}
		private uint ComputeStart(int index)
		{
			index--;
			return this.map[index].Start + this.map[index].Length;
		}
		public uint GetLength()
		{
			Range range = this.map[15];
			return range.Start - 8192u + range.Length;
		}
	}
}
