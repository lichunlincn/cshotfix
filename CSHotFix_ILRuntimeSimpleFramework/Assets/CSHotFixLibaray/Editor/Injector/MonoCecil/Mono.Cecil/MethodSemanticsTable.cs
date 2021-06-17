using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class MethodSemanticsTable : SortedTable<Row<MethodSemanticsAttributes, uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt16((ushort)this.rows[i].Col1);
				buffer.WriteRID(this.rows[i].Col2, Table.Method);
				buffer.WriteCodedRID(this.rows[i].Col3, CodedIndex.HasSemantics);
			}
		}
		public override int Compare(Row<MethodSemanticsAttributes, uint, uint> x, Row<MethodSemanticsAttributes, uint, uint> y)
		{
			return base.Compare(x.Col3, y.Col3);
		}
	}
}
