using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class ModuleTable : OneRowTable<uint>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			buffer.WriteUInt16(0);
			buffer.WriteString(this.row);
			buffer.WriteUInt16(1);
			buffer.WriteUInt16(0);
			buffer.WriteUInt16(0);
		}
	}
}
