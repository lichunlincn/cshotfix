using System;
namespace Editor_Mono.Cecil
{
	public class ExportedType : IMetadataTokenProvider
	{
		private string @namespace;
		private string name;
		private uint attributes;
		private IMetadataScope scope;
		private ModuleDefinition module;
		private int identifier;
		private ExportedType declaring_type;
		internal MetadataToken token;
		public string Namespace
		{
			get
			{
				return this.@namespace;
			}
			set
			{
				this.@namespace = value;
			}
		}
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
		public TypeAttributes Attributes
		{
			get
			{
				return (TypeAttributes)this.attributes;
			}
			set
			{
				this.attributes = (uint)value;
			}
		}
		public IMetadataScope Scope
		{
			get
			{
				if (this.declaring_type != null)
				{
					return this.declaring_type.Scope;
				}
				return this.scope;
			}
		}
		public ExportedType DeclaringType
		{
			get
			{
				return this.declaring_type;
			}
			set
			{
				this.declaring_type = value;
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
		public int Identifier
		{
			get
			{
				return this.identifier;
			}
			set
			{
				this.identifier = value;
			}
		}
		public bool IsNotPublic
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 0u, value);
			}
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
		public bool IsNestedPublic
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
		public bool IsNestedPrivate
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 3u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 3u, value);
			}
		}
		public bool IsNestedFamily
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 4u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 4u, value);
			}
		}
		public bool IsNestedAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 5u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 5u, value);
			}
		}
		public bool IsNestedFamilyAndAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 6u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 6u, value);
			}
		}
		public bool IsNestedFamilyOrAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7u, 7u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7u, 7u, value);
			}
		}
		public bool IsAutoLayout
		{
			get
			{
				return this.attributes.GetMaskedAttributes(24u, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(24u, 0u, value);
			}
		}
		public bool IsSequentialLayout
		{
			get
			{
				return this.attributes.GetMaskedAttributes(24u, 8u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(24u, 8u, value);
			}
		}
		public bool IsExplicitLayout
		{
			get
			{
				return this.attributes.GetMaskedAttributes(24u, 16u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(24u, 16u, value);
			}
		}
		public bool IsClass
		{
			get
			{
				return this.attributes.GetMaskedAttributes(32u, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(32u, 0u, value);
			}
		}
		public bool IsInterface
		{
			get
			{
				return this.attributes.GetMaskedAttributes(32u, 32u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(32u, 32u, value);
			}
		}
		public bool IsAbstract
		{
			get
			{
				return this.attributes.GetAttributes(128u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(128u, value);
			}
		}
		public bool IsSealed
		{
			get
			{
				return this.attributes.GetAttributes(256u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(256u, value);
			}
		}
		public bool IsSpecialName
		{
			get
			{
				return this.attributes.GetAttributes(1024u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(1024u, value);
			}
		}
		public bool IsImport
		{
			get
			{
				return this.attributes.GetAttributes(4096u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(4096u, value);
			}
		}
		public bool IsSerializable
		{
			get
			{
				return this.attributes.GetAttributes(8192u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(8192u, value);
			}
		}
		public bool IsAnsiClass
		{
			get
			{
				return this.attributes.GetMaskedAttributes(196608u, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(196608u, 0u, value);
			}
		}
		public bool IsUnicodeClass
		{
			get
			{
				return this.attributes.GetMaskedAttributes(196608u, 65536u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(196608u, 65536u, value);
			}
		}
		public bool IsAutoClass
		{
			get
			{
				return this.attributes.GetMaskedAttributes(196608u, 131072u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(196608u, 131072u, value);
			}
		}
		public bool IsBeforeFieldInit
		{
			get
			{
				return this.attributes.GetAttributes(1048576u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(1048576u, value);
			}
		}
		public bool IsRuntimeSpecialName
		{
			get
			{
				return this.attributes.GetAttributes(2048u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(2048u, value);
			}
		}
		public bool HasSecurity
		{
			get
			{
				return this.attributes.GetAttributes(262144u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(262144u, value);
			}
		}
		public bool IsForwarder
		{
			get
			{
				return this.attributes.GetAttributes(2097152u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(2097152u, value);
			}
		}
		public string FullName
		{
			get
			{
				string text = string.IsNullOrEmpty(this.@namespace) ? this.name : (this.@namespace + '.' + this.name);
				if (this.declaring_type != null)
				{
					return this.declaring_type.FullName + "/" + text;
				}
				return text;
			}
		}
		public ExportedType(string @namespace, string name, ModuleDefinition module, IMetadataScope scope)
		{
			this.@namespace = @namespace;
			this.name = name;
			this.scope = scope;
			this.module = module;
		}
		public override string ToString()
		{
			return this.FullName;
		}
		public TypeDefinition Resolve()
		{
			return this.module.Resolve(this.CreateReference());
		}
		internal TypeReference CreateReference()
		{
			return new TypeReference(this.@namespace, this.name, this.module, this.scope)
			{
				DeclaringType = (this.declaring_type != null) ? this.declaring_type.CreateReference() : null
			};
		}
	}
}
