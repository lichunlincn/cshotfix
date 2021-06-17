using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class ImplMapTable : SortedTable<Row<PInvokeAttributes, uint, uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt16((ushort)this.rows[i].Col1);
				buffer.WriteCodedRID(this.rows[i].Col2, CodedIndex.MemberForwarded);
				buffer.WriteString(this.rows[i].Col3);
				buffer.WriteRID(this.rows[i].Col4, Table.ModuleRef);
			}
		}
		public override int Compare(Row<PInvokeAttributes, uint, uint, uint> x, Row<PInvokeAttributes, uint, uint, uint> y)
		{
			return base.Compare(x.Col2, y.Col2);
		}
	}
}
