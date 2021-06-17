using System;
namespace Editor_Mono.Cecil
{
	public sealed class CustomMarshalInfo : MarshalInfo
	{
		internal Guid guid;
		internal string unmanaged_type;
		internal TypeReference managed_type;
		internal string cookie;
		public Guid Guid
		{
			get
			{
				return this.guid;
			}
			set
			{
				this.guid = value;
			}
		}
		public string UnmanagedType
		{
			get
			{
				return this.unmanaged_type;
			}
			set
			{
				this.unmanaged_type = value;
			}
		}
		public TypeReference ManagedType
		{
			get
			{
				return this.managed_type;
			}
			set
			{
				this.managed_type = value;
			}
		}
		public string Cookie
		{
			get
			{
				return this.cookie;
			}
			set
			{
				this.cookie = value;
			}
		}
		public CustomMarshalInfo() : base(NativeType.CustomMarshaler)
		{
		}
	}
}
