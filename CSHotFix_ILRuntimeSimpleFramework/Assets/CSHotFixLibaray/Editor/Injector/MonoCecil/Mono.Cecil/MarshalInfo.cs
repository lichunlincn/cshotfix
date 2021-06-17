using System;
namespace Editor_Mono.Cecil
{
	public class MarshalInfo
	{
		internal NativeType native;
		public NativeType NativeType
		{
			get
			{
				return this.native;
			}
			set
			{
				this.native = value;
			}
		}
		public MarshalInfo(NativeType native)
		{
			this.native = native;
		}
	}
}
