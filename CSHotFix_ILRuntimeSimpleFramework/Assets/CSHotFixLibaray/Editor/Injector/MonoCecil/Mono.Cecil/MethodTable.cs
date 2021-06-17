using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class MethodTable : MetadataTable<Row<uint, MethodImplAttributes, MethodAttributes, uint, uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteUInt32(this.rows[i].Col1);
				buffer.WriteUInt16((ushort)this.rows[i].Col2);
				buffer.WriteUInt16((ushort)this.rows[i].Col3);
				buffer.WriteString(this.rows[i].Col4);
				buffer.WriteBlob(this.rows[i].Col5);
				buffer.WriteRID(this.rows[i].Col6, Table.Param);
			}
		}
	}
}
