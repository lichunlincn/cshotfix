using System;
namespace Editor_Mono.Cecil
{
	internal abstract class OneRowTable<TRow> : MetadataTable where TRow : struct
	{
		internal TRow row;
		public sealed override int Length
		{
			get
			{
				return 1;
			}
		}
		public sealed override void Sort()
		{
		}
	}
}
