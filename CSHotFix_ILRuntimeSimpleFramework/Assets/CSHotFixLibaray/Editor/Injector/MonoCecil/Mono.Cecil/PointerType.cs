using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class PointerType : TypeSpecification
	{
		public override string Name
		{
			get
			{
				return base.Name + "*";
			}
		}
		public override string FullName
		{
			get
			{
				return base.FullName + "*";
			}
		}
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
		public override bool IsPointer
		{
			get
			{
				return true;
			}
		}
		public PointerType(TypeReference type) : base(type)
		{
			Mixin.CheckType(type);
			this.etype = Editor_Mono.Cecil.Metadata.ElementType.Ptr;
		}
	}
}
