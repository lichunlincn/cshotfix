using System;
namespace Editor_Mono.Cecil
{
	public abstract class Resource
	{
		private string name;
		private uint attributes;
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
		public ManifestResourceAttributes Attributes
		{
			get
			{
				return (ManifestResourceAttributes)this.attributes;
			}
			set
			{
				this.attributes = (uint)value;
			}
		}
		public abstract ResourceType ResourceType
		{
			get;
		}
		public bool IsPublic
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 1u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 1u, value);
			}
		}
		public bool IsPrivate
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 2u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 2u, value);
			}
		}
		internal Resource(string name, ManifestResourceAttributes attributes)
		{
			this.name = name;
			this.attributes = (uint)attributes;
		}
	}
}
