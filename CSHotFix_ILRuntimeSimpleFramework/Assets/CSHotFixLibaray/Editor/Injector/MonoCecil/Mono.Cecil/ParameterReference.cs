using System;
namespace Editor_Mono.Cecil
{
	public abstract class ParameterReference : IMetadataTokenProvider
	{
		private string name;
		internal int index = -1;
		protected TypeReference parameter_type;
		internal MetadataToken token;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}
		public int Index
		{
			get
			{
				return this.index;
			}
		}
		public TypeReference ParameterType
		{
			get
			{
				return this.parameter_type;
			}
			set
			{
				this.parameter_type = value;
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
		internal ParameterReference(string name, TypeReference parameterType)
		{
			if (parameterType == null)
			{
				throw new ArgumentNullException("parameterType");
			}
			this.name = (name ?? string.Empty);
			this.parameter_type = parameterType;
		}
		public override string ToString()
		{
			return this.name;
		}
		public abstract ParameterDefinition Resolve();
	}
}
