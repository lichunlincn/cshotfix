using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	internal abstract class MetadataTable
	{
		public abstract int Length
		{
			get;
		}
		public bool IsLarge
		{
			get
			{
				return this.Length > 65535;
			}
		}
		public abstract void Write(TableHeapBuffer buffer);
		public abstract void Sort();
	}
	internal abstract class MetadataTable<TRow> : MetadataTable where TRow : struct
	{
		internal TRow[] rows = new TRow[2];
		internal int length;
		public sealed override int Length
		{
			get
			{
				return this.length;
			}
		}
		public int AddRow(TRow row)
		{
			if (this.rows.Length == this.length)
			{
				this.Grow();
			}
			this.rows[this.length++] = row;
			return this.length;
		}
		private void Grow()
		{
			TRow[] destinationArray = new TRow[this.rows.Length * 2];
			Array.Copy(this.rows, destinationArray, this.rows.Length);
			this.rows = destinationArray;
		}
		public override void Sort()
		{
		}
	}
}
