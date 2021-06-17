using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class ConstantTable : SortedTable<Row<ElementType, uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt16((ushort)this.rows[i].Col1);
				buffer.WriteCodedRID(this.rows[i].Col2, CodedIndex.HasConstant);
				buffer.WriteBlob(this.rows[i].Col3);
			}
		}
		public override int Compare(Row<ElementType, uint, uint> x, Row<ElementType, uint, uint> y)
		{
			return base.Compare(x.Col2, y.Col2);
		}
	}
}
