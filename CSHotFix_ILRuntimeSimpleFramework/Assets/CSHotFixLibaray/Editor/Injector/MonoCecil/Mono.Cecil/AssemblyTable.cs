using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class AssemblyTable : OneRowTable<Row<AssemblyHashAlgorithm, ushort, ushort, ushort, ushort, AssemblyAttributes, uint, uint, uint>>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			buffer.WriteUInt32((uint)this.row.Col1);
			buffer.WriteUInt16(this.row.Col2);
			buffer.WriteUInt16(this.row.Col3);
			buffer.WriteUInt16(this.row.Col4);
			buffer.WriteUInt16(this.row.Col5);
			buffer.WriteUInt32((uint)this.row.Col6);
			buffer.WriteBlob(this.row.Col7);
			buffer.WriteString(this.row.Col8);
			buffer.WriteString(this.row.Col9);
		}
	}
}
