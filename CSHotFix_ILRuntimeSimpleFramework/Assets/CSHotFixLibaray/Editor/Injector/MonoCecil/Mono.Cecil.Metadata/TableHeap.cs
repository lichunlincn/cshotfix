using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class TableHeap : Heap
	{
		public const int TableCount = 45;
		public long Valid;
		public long Sorted;
		public readonly TableInformation[] Tables = new TableInformation[45];
		public TableInformation this[Table table]
		{
			get
			{
				return this.Tables[(int)table];
			}
		}
		public TableHeap(Section section, uint start, uint size) : base(section, start, size)
		{
		}
		public bool HasTable(Table table)
		{
			return (this.Valid & 1L << (int)table) != 0L;
		}
	}
}
