using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public abstract class PropertyReference : MemberReference
	{
		private TypeReference property_type;
		public TypeReference PropertyType
		{
			get
			{
				return this.property_type;
			}
			set
			{
				this.property_type = value;
			}
		}
		public abstract Collection<ParameterDefinition> Parameters
		{
			get;
		}
		internal PropertyReference(string name, TypeReference propertyType) : base(name)
		{
			if (propertyType == null)
			{
				throw new ArgumentNullException("propertyType");
			}
			this.property_type = propertyType;
		}
		public abstract PropertyDefinition Resolve();
	}
}
