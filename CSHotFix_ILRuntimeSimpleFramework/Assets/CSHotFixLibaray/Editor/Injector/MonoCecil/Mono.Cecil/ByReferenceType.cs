using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class ByReferenceType : TypeSpecification
	{
		public override string Name
		{
			get
			{
				return base.Name + "&";
			}
		}
		public override string FullName
		{
			get
			{
				return base.FullName + "&";
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
		public override bool IsByReference
		{
			get
			{
				return true;
			}
		}
		public ByReferenceType(TypeReference type) : base(type)
		{
			Mixin.CheckType(type);
			this.etype = Editor_Mono.Cecil.Metadata.ElementType.ByRef;
		}
	}
}
