using Mono.Cecil.Metadata;
using System;
namespace Mono.Cecil
{
	internal sealed class TypeSpecTable : MetadataTable<uint>
	{
		public override void Write(TableHeapBuffer buffer)
		{
			for (int i = 0; i < this.length; i++)
			{
				buffer.WriteBlob(this.rows[i]);
			}
		}
	}
}
