using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil
{
	internal abstract class SortedTable<TRow> : MetadataTable<TRow>, IComparer<TRow> where TRow : struct
	{
		public sealed override void Sort()
		{
			Array.Sort<TRow>(this.rows, 0, this.length, this);
		}
		protected int Compare(uint x, uint y)
		{
			if (x == y)
			{
				return 0;
			}
			if (x <= y)
			{
				return -1;
			}
			return 1;
		}
		public abstract int Compare(TRow x, TRow y);
	}
}
