using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class SecurityAttribute : ICustomAttribute
	{
		private TypeReference attribute_type;
		internal Collection<CustomAttributeNamedArgument> fields;
		internal Collection<CustomAttributeNamedArgument> properties;
		public TypeReference AttributeType
		{
			get
			{
				return this.attribute_type;
			}
			set
			{
				this.attribute_type = value;
			}
		}
		public bool HasFields
		{
			get
			{
				return !this.fields.IsNullOrEmpty<CustomAttributeNamedArgument>();
			}
		}
		public Collection<CustomAttributeNamedArgument> Fields
		{
			get
			{
				Collection<CustomAttributeNamedArgument> arg_18_0;
				if ((arg_18_0 = this.fields) == null)
				{
					arg_18_0 = (this.fields = new Collection<CustomAttributeNamedArgument>());
				}
				return arg_18_0;
			}
		}
		public bool HasProperties
		{
			get
			{
				return !this.properties.IsNullOrEmpty<CustomAttributeNamedArgument>();
			}
		}
		public Collection<CustomAttributeNamedArgument> Properties
		{
			get
			{
				Collection<CustomAttributeNamedArgument> arg_18_0;
				if ((arg_18_0 = this.properties) == null)
				{
					arg_18_0 = (this.properties = new Collection<CustomAttributeNamedArgument>());
				}
				return arg_18_0;
			}
		}
		public SecurityAttribute(TypeReference attributeType)
		{
			this.attribute_type = attributeType;
		}
	}
}
