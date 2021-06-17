using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class GenericParameter : TypeReference, ICustomAttributeProvider, IMetadataTokenProvider
	{
		internal int position;
		internal GenericParameterType type;
		internal IGenericParameterProvider owner;
		private ushort attributes;
		private Collection<TypeReference> constraints;
		private Collection<CustomAttribute> custom_attributes;
		public GenericParameterAttributes Attributes
		{
			get
			{
				return (GenericParameterAttributes)this.attributes;
			}
			set
			{
				this.attributes = (ushort)value;
			}
		}
		public int Position
		{
			get
			{
				return this.position;
			}
		}
		public GenericParameterType Type
		{
			get
			{
				return this.type;
			}
		}
		public IGenericParameterProvider Owner
		{
			get
			{
				return this.owner;
			}
		}
		public bool HasConstraints
		{
			get
			{
				if (this.constraints != null)
				{
					return this.constraints.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<GenericParameter, bool>(this, (GenericParameter generic_parameter, MetadataReader reader) => reader.HasGenericConstraints(generic_parameter));
				}
				return false;
			}
		}
		public Collection<TypeReference> Constraints
		{
			get
			{
				if (this.constraints != null)
				{
					return this.constraints;
				}
				if (base.HasImage)
				{
					return this.Module.Read<GenericParameter, Collection<TypeReference>>(ref this.constraints, this, (GenericParameter generic_parameter, MetadataReader reader) => reader.ReadGenericConstraints(generic_parameter));
				}
				return this.constraints = new Collection<TypeReference>();
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
				return this.GetHasCustomAttributes(this.Module);
			}
		}
		public Collection<CustomAttribute> CustomAttributes
		{
			get
			{
				return this.custom_attributes ?? this.GetCustomAttributes(ref this.custom_attributes, this.Module);
			}
		}
		public override IMetadataScope Scope
		{
			get
			{
				if (this.owner == null)
				{
					return null;
				}
				if (this.owner.GenericParameterType != GenericParameterType.Method)
				{
					return ((TypeReference)this.owner).Scope;
				}
				return ((MethodReference)this.owner).DeclaringType.Scope;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public override TypeReference DeclaringType
		{
			get
			{
				return this.owner as TypeReference;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public MethodReference DeclaringMethod
		{
			get
			{
				return this.owner as MethodReference;
			}
		}
		public override ModuleDefinition Module
		{
			get
			{
				return this.module ?? this.owner.Module;
			}
		}
		public override string Name
		{
			get
			{
				if (!string.IsNullOrEmpty(base.Name))
				{
					return base.Name;
				}
				return base.Name = ((this.type == GenericParameterType.Method) ? "!!" : "!") + this.position;
			}
		}
		public override string Namespace
		{
			get
			{
				return string.Empty;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public override string FullName
		{
			get
			{
				return this.Name;
			}
		}
		public override bool IsGenericParameter
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
				return true;
			}
		}
		public override MetadataType MetadataType
		{
			get
			{
				return (MetadataType)this.etype;
			}
		}
		public bool IsNonVariant
		{
			get
			{
				return this.attributes.GetMaskedAttributes(3, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(3, 0u, value);
			}
		}
		public bool IsCovariant
		{
			get
			{
				return this.attributes.GetMaskedAttributes(3, 1u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(3, 1u, value);
			}
		}
		public bool IsContravariant
		{
			get
			{
				return this.attributes.GetMaskedAttributes(3, 2u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(3, 2u, value);
			}
		}
		public bool HasReferenceTypeConstraint
		{
			get
			{
				return this.attributes.GetAttributes(4);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(4, value);
			}
		}
		public bool HasNotNullableValueTypeConstraint
		{
			get
			{
				return this.attributes.GetAttributes(8);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(8, value);
			}
		}
		public bool HasDefaultConstructorConstraint
		{
			get
			{
				return this.attributes.GetAttributes(16);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(16, value);
			}
		}
		public GenericParameter(IGenericParameterProvider owner) : this(string.Empty, owner)
		{
		}
		public GenericParameter(string name, IGenericParameterProvider owner) : base(string.Empty, name)
		{
			if (owner == null)
			{
				throw new ArgumentNullException();
			}
			this.position = -1;
			this.owner = owner;
			this.type = owner.GenericParameterType;
			this.etype = GenericParameter.ConvertGenericParameterType(this.type);
			this.token = new MetadataToken(TokenType.GenericParam);
		}
		internal GenericParameter(int position, GenericParameterType type, ModuleDefinition module) : base(string.Empty, string.Empty)
		{
			if (module == null)
			{
				throw new ArgumentNullException();
			}
			this.position = position;
			this.type = type;
			this.etype = GenericParameter.ConvertGenericParameterType(type);
			this.module = module;
			this.token = new MetadataToken(TokenType.GenericParam);
		}
		private static ElementType ConvertGenericParameterType(GenericParameterType type)
		{
			switch (type)
			{
			case GenericParameterType.Type:
				return ElementType.Var;
			case GenericParameterType.Method:
				return ElementType.MVar;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}
		public override TypeDefinition Resolve()
		{
			return null;
		}
	}
}
