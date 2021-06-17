using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class ModuleRefTable : MetadataTable<uint>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteString(this.rows[i]);
			}
		}
	}
}
