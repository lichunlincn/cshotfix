using System;
namespace Editor_Mono.Cecil
{
	public struct CustomAttributeArgument
	{
		private readonly TypeReference type;
		private readonly object value;
		public TypeReference Type
		{
			get
			{
				return this.type;
			}
		}
		public object Value
		{
			get
			{
				return this.value;
			}
		}
		public CustomAttributeArgument(TypeReference type, object value)
		{
			Mixin.CheckType(type);
			this.type = type;
			this.value = value;
		}
	}
}
