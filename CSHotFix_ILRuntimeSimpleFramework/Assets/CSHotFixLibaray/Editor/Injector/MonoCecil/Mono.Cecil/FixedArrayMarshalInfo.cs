using System;
namespace Editor_Mono.Cecil
{
	public sealed class FixedArrayMarshalInfo : MarshalInfo
	{
		internal NativeType element_type;
		internal int size;
		public NativeType ElementType
		{
			get
			{
				return this.element_type;
			}
			set
			{
				this.element_type = value;
			}
		}
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
		public FixedArrayMarshalInfo() : base(NativeType.FixedArray)
		{
			this.element_type = NativeType.None;
		}
	}
}
