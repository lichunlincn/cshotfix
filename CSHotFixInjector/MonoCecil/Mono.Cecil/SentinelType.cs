using Mono.Cecil.Metadata;
using System;
namespace Mono.Cecil
{
	public sealed class SentinelType : TypeSpecification
	{
		public override bool IsValueType
		{
			get
			{
				return false;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public override bool IsSentinel
		{
			get
			{
				return true;
			}
		}
		public SentinelType(TypeReference type) : base(type)
		{
			Mixin.CheckType(type);
			this.etype = Mono.Cecil.Metadata.ElementType.Sentinel;
		}
	}
}
