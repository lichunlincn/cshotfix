using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class TableHeapBuffer : HeapBuffer
	{
		private readonly ModuleDefinition module;
		private readonly MetadataBuilder metadata;
		internal MetadataTable[] tables = new MetadataTable[45];
		private bool large_string;
		private bool large_blob;
		private readonly int[] coded_index_sizes = new int[13];
		private readonly Func<Table, int> counter;
		public override bool IsEmpty
		{
			get
			{
				return false;
			}
		}
		public TableHeapBuffer(ModuleDefinition module, MetadataBuilder metadata) : base(24)
		{
			this.module = module;
			this.metadata = metadata;
			this.counter = new Func<Table, int>(this.GetTableLength);
		}
		private int GetTableLength(Table table)
		{
			MetadataTable metadataTable = this.tables[(int)table];
			if (metadataTable == null)
			{
				return 0;
			}
			return metadataTable.Length;
		}
		public TTable GetTable<TTable>(Table table) where TTable : MetadataTable, new()
		{
			TTable tTable = (TTable)((object)this.tables[(int)table]);
			if (tTable != null)
			{
				return tTable;
			}
			tTable = Activator.CreateInstance<TTable>();
			this.tables[(int)table] = tTable;
			return tTable;
		}
		public void WriteBySize(uint value, int size)
		{
			if (size == 4)
			{
				base.WriteUInt32(value);
				return;
			}
			base.WriteUInt16((ushort)value);
		}
		public void WriteBySize(uint value, bool large)
		{
			if (large)
			{
				base.WriteUInt32(value);
				return;
			}
			base.WriteUInt16((ushort)value);
		}
		public void WriteString(uint @string)
		{
			this.WriteBySize(@string, this.large_string);
		}
		public void WriteBlob(uint blob)
		{
			this.WriteBySize(blob, this.large_blob);
		}
		public void WriteRID(uint rid, Table table)
		{
			MetadataTable metadataTable = this.tables[(int)table];
			this.WriteBySize(rid, metadataTable != null && metadataTable.IsLarge);
		}
		private int GetCodedIndexSize(CodedIndex coded_index)
		{
			int num = this.coded_index_sizes[(int)coded_index];
			if (num != 0)
			{
				return num;
			}
			return this.coded_index_sizes[(int)coded_index] = coded_index.GetSize(this.counter);
		}
		public void WriteCodedRID(uint rid, CodedIndex coded_index)
		{
			this.WriteBySize(rid, this.GetCodedIndexSize(coded_index));
		}
		public void WriteTableHeap()
		{
			base.WriteUInt32(0u);
			base.WriteByte(this.GetTableHeapVersion());
			base.WriteByte(0);
			base.WriteByte(this.GetHeapSizes());
			base.WriteByte(10);
			base.WriteUInt64(this.GetValid());
			base.WriteUInt64(24190111578624uL);
			this.WriteRowCount();
			this.WriteTables();
		}
		private void WriteRowCount()
		{
			for (int i = 0; i < this.tables.Length; i++)
			{
				MetadataTable metadataTable = this.tables[i];
				if (metadataTable != null && metadataTable.Length != 0)
				{
					base.WriteUInt32((uint)metadataTable.Length);
				}
			}
		}
		private void WriteTables()
		{
			for (int i = 0; i < this.tables.Length; i++)
			{
				MetadataTable metadataTable = this.tables[i];
				if (metadataTable != null && metadataTable.Length != 0)
				{
					metadataTable.Write(this);
				}
			}
		}
		private ulong GetValid()
		{
			ulong num = 0uL;
			for (int i = 0; i < this.tables.Length; i++)
			{
				MetadataTable metadataTable = this.tables[i];
				if (metadataTable != null && metadataTable.Length != 0)
				{
					metadataTable.Sort();
					num |= 1uL << i;
				}
			}
			return num;
		}
		private byte GetHeapSizes()
		{
			byte b = 0;
			if (this.metadata.string_heap.IsLarge)
			{
				this.large_string = true;
				b |= 1;
			}
			if (this.metadata.blob_heap.IsLarge)
			{
				this.large_blob = true;
				b |= 4;
			}
			return b;
		}
		private byte GetTableHeapVersion()
		{
			switch (this.module.Runtime)
			{
			case TargetRuntime.Net_1_0:
			case TargetRuntime.Net_1_1:
				return 1;
			default:
				return 2;
			}
		}
		public void FixupData(uint data_rva)
		{
			FieldRVATable table = this.GetTable<FieldRVATable>(Table.FieldRVA);
			if (table.length == 0)
			{
				return;
			}
			int num = this.GetTable<FieldTable>(Table.Field).IsLarge ? 4 : 2;
			int position = this.position;
			this.position = table.position;
			for (int i = 0; i < table.length; i++)
			{
				uint num2 = base.ReadUInt32();
				this.position -= 4;
				base.WriteUInt32(num2 + data_rva);
				this.position += num;
			}
			this.position = position;
		}
	}
}
