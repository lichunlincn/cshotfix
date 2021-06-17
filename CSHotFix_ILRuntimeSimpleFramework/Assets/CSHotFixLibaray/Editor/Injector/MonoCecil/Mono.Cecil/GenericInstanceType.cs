using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
using System.Text;
namespace Editor_Mono.Cecil
{
	public sealed class GenericInstanceType : TypeSpecification, IGenericInstance, IMetadataTokenProvider, IGenericContext
	{
		private Collection<TypeReference> arguments;
		public bool HasGenericArguments
		{
			get
			{
				return !this.arguments.IsNullOrEmpty<TypeReference>();
			}
		}
		public Collection<TypeReference> GenericArguments
		{
			get
			{
				Collection<TypeReference> arg_18_0;
				if ((arg_18_0 = this.arguments) == null)
				{
					arg_18_0 = (this.arguments = new Collection<TypeReference>());
				}
				return arg_18_0;
			}
		}
		public override TypeReference DeclaringType
		{
			get
			{
				return base.ElementType.DeclaringType;
			}
			set
			{
				throw new NotSupportedException();
			}
		}
		public override string FullName
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(base.FullName);
				this.GenericInstanceFullName(stringBuilder);
				return stringBuilder.ToString();
			}
		}
		public override bool IsGenericInstance
		{
			get
			{
				return true;
			}
		}
		public override bool ContainsGenericParameter
		{
			get
			{
				return this.ContainsGenericParameter() || base.ContainsGenericParameter;
			}
		}
		IGenericParameterProvider IGenericContext.Type
		{
			get
			{
				return base.ElementType;
			}
		}
		public GenericInstanceType(TypeReference type) : base(type)
		{
			base.IsValueType = type.IsValueType;
			this.etype = Editor_Mono.Cecil.Metadata.ElementType.GenericInst;
		}
	}
}
