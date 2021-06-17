using System;
namespace Editor_Mono.Cecil
{
	public sealed class FixedSysStringMarshalInfo : MarshalInfo
	{
		internal int size;
		public int Size
		{
			get
			{
				return this.size;
			}
			set
			{
				this.size = value;
			}
		}
		public FixedSysStringMarshalInfo() : base(NativeType.FixedSysString)
		{
			this.size = -1;
		}
	}
}
