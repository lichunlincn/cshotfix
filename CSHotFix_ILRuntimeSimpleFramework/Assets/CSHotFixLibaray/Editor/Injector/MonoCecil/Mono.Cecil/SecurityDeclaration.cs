using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class SecurityDeclaration
	{
		internal readonly uint signature;
		private byte[] blob;
		private readonly ModuleDefinition module;
		internal bool resolved;
		private SecurityAction action;
		internal Collection<SecurityAttribute> security_attributes;
		public SecurityAction Action
		{
			get
			{
				return this.action;
			}
			set
			{
				this.action = value;
			}
		}
		public bool HasSecurityAttributes
		{
			get
			{
				this.Resolve();
				return !this.security_attributes.IsNullOrEmpty<SecurityAttribute>();
			}
		}
		public Collection<SecurityAttribute> SecurityAttributes
		{
			get
			{
				this.Resolve();
				Collection<SecurityAttribute> arg_1E_0;
				if ((arg_1E_0 = this.security_attributes) == null)
				{
					arg_1E_0 = (this.security_attributes = new Collection<SecurityAttribute>());
				}
				return arg_1E_0;
			}
		}
		internal bool HasImage
		{
			get
			{
				return this.module != null && this.module.HasImage;
			}
		}
		internal SecurityDeclaration(SecurityAction action, uint signature, ModuleDefinition module)
		{
			this.action = action;
			this.signature = signature;
			this.module = module;
		}
		public SecurityDeclaration(SecurityAction action)
		{
			this.action = action;
			this.resolved = true;
		}
		public SecurityDeclaration(SecurityAction action, byte[] blob)
		{
			this.action = action;
			this.resolved = false;
			this.blob = blob;
		}
		public byte[] GetBlob()
		{
			if (this.blob != null)
			{
				return this.blob;
			}
			if (!this.HasImage || this.signature == 0u)
			{
				throw new NotSupportedException();
			}
			return this.blob = this.module.Read<SecurityDeclaration, byte[]>(this, (SecurityDeclaration declaration, MetadataReader reader) => reader.ReadSecurityDeclarationBlob(declaration.signature));
		}
		private void Resolve()
		{
			if (this.resolved || !this.HasImage)
			{
				return;
			}
			this.module.Read<SecurityDeclaration, SecurityDeclaration>(this, delegate(SecurityDeclaration declaration, MetadataReader reader)
			{
				reader.ReadSecurityDeclarationSignature(declaration);
				return this;
			});
			this.resolved = true;
		}
	}
}
