using Mono.Cecil.Metadata;
using System;
namespace Mono.Cecil
{
	public sealed class PinnedType : TypeSpecification
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
		public override bool IsPinned
		{
			get
			{
				return true;
			}
		}
		public PinnedType(TypeReference type) : base(type)
		{
			Mixin.CheckType(type);
			this.etype = Mono.Cecil.Metadata.ElementType.Pinned;
		}
	}
}
