using System;
namespace Editor_Mono.Cecil
{
	public sealed class LinkedResource : Resource
	{
		internal byte[] hash;
		private string file;
		public byte[] Hash
		{
			get
			{
				return this.hash;
			}
		}
		public string File
		{
			get
			{
				return this.file;
			}
			set
			{
				this.file = value;
			}
		}
		public override ResourceType ResourceType
		{
			get
			{
				return ResourceType.Linked;
			}
		}
		public LinkedResource(string name, ManifestResourceAttributes flags) : base(name, flags)
		{
		}
		public LinkedResource(string name, ManifestResourceAttributes flags, string file) : base(name, flags)
		{
			this.file = file;
		}
	}
}
