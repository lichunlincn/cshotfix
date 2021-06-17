using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public class InterfaceImplementation : ICustomAttributeProvider, IMetadataTokenProvider
	{
		internal TypeDefinition type;
		internal MetadataToken token;
		private TypeReference interface_type;
		private Collection<CustomAttribute> custom_attributes;
		public TypeReference InterfaceType
		{
			get
			{
				return this.interface_type;
			}
			set
			{
				this.interface_type = value;
			}
		}
		public bool HasCustomAttributes
		{
			get
			{
				if (this.custom_attributes != null)
				{
					return this.custom_attributes.Count > 0;
				}
				return this.GetHasCustomAttributes(this.type.Module);
			}
		}
		public Collection<CustomAttribute> CustomAttributes
		{
			get
			{
				return this.custom_attributes ?? this.GetCustomAttributes(ref this.custom_attributes, this.type.Module);
			}
		}
		public MetadataToken MetadataToken
		{
			get
			{
				return this.token;
			}
			set
			{
				this.token = value;
			}
		}
		internal InterfaceImplementation(TypeReference interfaceType, MetadataToken token)
		{
			this.interface_type = interfaceType;
			this.token = token;
		}
		public InterfaceImplementation(TypeReference interfaceType)
		{
			if (interfaceType == null)
			{
				throw new ArgumentNullException("interfaceType");
			}
			this.interface_type = interfaceType;
			this.token = new MetadataToken(TokenType.InterfaceImpl);
		}
	}
}
