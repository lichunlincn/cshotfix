using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class FieldLayoutTable : SortedTable<Row<uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt32(this.rows[i].Col1);
				buffer.WriteRID(this.rows[i].Col2, Table.Field);
			}
		}
		public override int Compare(Row<uint, uint> x, Row<uint, uint> y)
		{
			return base.Compare(x.Col2, y.Col2);
		}
	}
}
