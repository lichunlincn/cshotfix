using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class TypeDefinition : TypeReference, IMemberDefinition, ICustomAttributeProvider, ISecurityDeclarationProvider, IMetadataTokenProvider
	{
		private uint attributes;
		private TypeReference base_type;
		internal Range fields_range;
		internal Range methods_range;
		private short packing_size = -2;
		private int class_size = -2;
		private InterfaceImplementationCollection interfaces;
		private Collection<TypeDefinition> nested_types;
		private Collection<MethodDefinition> methods;
		private Collection<FieldDefinition> fields;
		private Collection<EventDefinition> events;
		private Collection<PropertyDefinition> properties;
		private Collection<CustomAttribute> custom_attributes;
		private Collection<SecurityDeclaration> security_declarations;
		public TypeAttributes Attributes
		{
			get
			{
				return (TypeAttributes)this.attributes;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && (uint)((ushort)value) != this.attributes)
				{
					throw new InvalidOperationException("Projected type definition attributes can't be changed.");
				}
				this.attributes = (uint)value;
			}
		}
		public TypeReference BaseType
		{
			get
			{
				return this.base_type;
			}
			set
			{
				this.base_type = value;
			}
		}
		public override string Name
		{
			get
			{
				return base.Name;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && value != base.Name)
				{
					throw new InvalidOperationException("Projected type definition name can't be changed.");
				}
				base.Name = value;
			}
		}
		public bool HasLayoutInfo
		{
			get
			{
				if (this.packing_size >= 0 || this.class_size >= 0)
				{
					return true;
				}
				this.ResolveLayout();
				return this.packing_size >= 0 || this.class_size >= 0;
			}
		}
		public short PackingSize
		{
			get
			{
				if (this.packing_size >= 0)
				{
					return this.packing_size;
				}
				this.ResolveLayout();
				if (this.packing_size < 0)
				{
					return -1;
				}
				return this.packing_size;
			}
			set
			{
				this.packing_size = value;
			}
		}
		public int ClassSize
		{
			get
			{
				if (this.class_size >= 0)
				{
					return this.class_size;
				}
				this.ResolveLayout();
				if (this.class_size < 0)
				{
					return -1;
				}
				return this.class_size;
			}
			set
			{
				this.class_size = value;
			}
		}
		public bool HasInterfaces
		{
			get
			{
				if (this.interfaces != null)
				{
					return this.interfaces.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, bool>(this, (TypeDefinition type, MetadataReader reader) => reader.HasInterfaces(type));
				}
				return false;
			}
		}
		public Collection<InterfaceImplementation> Interfaces
		{
			get
			{
				if (this.interfaces != null)
				{
					return this.interfaces;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, InterfaceImplementationCollection>(ref this.interfaces, this, (TypeDefinition type, MetadataReader reader) => reader.ReadInterfaces(type));
				}
				return this.interfaces = new InterfaceImplementationCollection(this);
			}
		}
		public bool HasNestedTypes
		{
			get
			{
				if (this.nested_types != null)
				{
					return this.nested_types.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, bool>(this, (TypeDefinition type, MetadataReader reader) => reader.HasNestedTypes(type));
				}
				return false;
			}
		}
		public Collection<TypeDefinition> NestedTypes
		{
			get
			{
				if (this.nested_types != null)
				{
					return this.nested_types;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, Collection<TypeDefinition>>(ref this.nested_types, this, (TypeDefinition type, MetadataReader reader) => reader.ReadNestedTypes(type));
				}
				return this.nested_types = new MemberDefinitionCollection<TypeDefinition>(this);
			}
		}
		public bool HasMethods
		{
			get
			{
				if (this.methods != null)
				{
					return this.methods.Count > 0;
				}
				return base.HasImage && this.methods_range.Length > 0u;
			}
		}
		public Collection<MethodDefinition> Methods
		{
			get
			{
				if (this.methods != null)
				{
					return this.methods;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, Collection<MethodDefinition>>(ref this.methods, this, (TypeDefinition type, MetadataReader reader) => reader.ReadMethods(type));
				}
				return this.methods = new MemberDefinitionCollection<MethodDefinition>(this);
			}
		}
		public bool HasFields
		{
			get
			{
				if (this.fields != null)
				{
					return this.fields.Count > 0;
				}
				return base.HasImage && this.fields_range.Length > 0u;
			}
		}
		public Collection<FieldDefinition> Fields
		{
			get
			{
				if (this.fields != null)
				{
					return this.fields;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, Collection<FieldDefinition>>(ref this.fields, this, (TypeDefinition type, MetadataReader reader) => reader.ReadFields(type));
				}
				return this.fields = new MemberDefinitionCollection<FieldDefinition>(this);
			}
		}
		public bool HasEvents
		{
			get
			{
				if (this.events != null)
				{
					return this.events.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, bool>(this, (TypeDefinition type, MetadataReader reader) => reader.HasEvents(type));
				}
				return false;
			}
		}
		public Collection<EventDefinition> Events
		{
			get
			{
				if (this.events != null)
				{
					return this.events;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, Collection<EventDefinition>>(ref this.events, this, (TypeDefinition type, MetadataReader reader) => reader.ReadEvents(type));
				}
				return this.events = new MemberDefinitionCollection<EventDefinition>(this);
			}
		}
		public bool HasProperties
		{
			get
			{
				if (this.properties != null)
				{
					return this.properties.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, bool>(this, (TypeDefinition type, MetadataReader reader) => reader.HasProperties(type));
				}
				return false;
			}
		}
		public Collection<PropertyDefinition> Properties
		{
			get
			{
				if (this.properties != null)
				{
					return this.properties;
				}
				if (base.HasImage)
				{
					return this.Module.Read<TypeDefinition, Collection<PropertyDefinition>>(ref this.properties, this, (TypeDefinition type, MetadataReader reader) => reader.ReadProperties(type));
				}
				return this.properties = new MemberDefinitionCollection<PropertyDefinition>(this);
			}
		}
		public bool HasSecurityDeclarations
		{
			get
			{
				if (this.security_declarations != null)
				{
					return this.security_declarations.Count > 0;
				}
				return this.GetHasSecurityDeclarations(this.Module);
			}
		}
		public Collection<SecurityDeclaration> SecurityDeclarations
		{
			get
			{
				return this.security_declarations ?? this.GetSecurityDeclarations(ref this.security_declarations, this.Module);
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
		public override bool HasGenericParameters
		{
			get
			{
				if (this.generic_parameters != null)
				{
					return this.generic_parameters.Count > 0;
				}
				return this.GetHasGenericParameters(this.Module);
			}
		}
		public override Collection<GenericParameter> GenericParameters
		{
			get
			{
				return this.generic_parameters ?? this.GetGenericParameters(ref this.generic_parameters, this.Module);
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
		public bool IsWindowsRuntime
		{
			get
			{
				return this.attributes.GetAttributes(16384u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(16384u, value);
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
		public bool IsEnum
		{
			get
			{
				return this.base_type != null && this.base_type.IsTypeOf("System", "Enum");
			}
		}
		public override bool IsValueType
		{
			get
			{
				return this.base_type != null && (this.base_type.IsTypeOf("System", "Enum") || (this.base_type.IsTypeOf("System", "ValueType") && !this.IsTypeOf("System", "Enum")));
			}
		}
		public override bool IsPrimitive
		{
			get
			{
				ElementType elementType;
				return MetadataSystem.TryGetPrimitiveElementType(this, out elementType);
			}
		}
		public override MetadataType MetadataType
		{
			get
			{
				ElementType result;
				if (MetadataSystem.TryGetPrimitiveElementType(this, out result))
				{
					return (MetadataType)result;
				}
				return base.MetadataType;
			}
		}
		public override bool IsDefinition
		{
			get
			{
				return true;
			}
		}
		public new TypeDefinition DeclaringType
		{
			get
			{
				return (TypeDefinition)base.DeclaringType;
			}
			set
			{
				base.DeclaringType = value;
			}
		}
		internal new TypeDefinitionProjection WindowsRuntimeProjection
		{
			get
			{
				return (TypeDefinitionProjection)this.projection;
			}
			set
			{
				this.projection = value;
			}
		}
		private void ResolveLayout()
		{
			if (this.packing_size != -2 || this.class_size != -2)
			{
				return;
			}
			if (!base.HasImage)
			{
				this.packing_size = -1;
				this.class_size = -1;
				return;
			}
			Row<short, int> row = this.Module.Read<TypeDefinition, Row<short, int>>(this, (TypeDefinition type, MetadataReader reader) => reader.ReadTypeLayout(type));
			this.packing_size = row.Col1;
			this.class_size = row.Col2;
		}
		public TypeDefinition(string @namespace, string name, TypeAttributes attributes) : base(@namespace, name)
		{
			this.attributes = (uint)attributes;
			this.token = new MetadataToken(TokenType.TypeDef);
		}
		public TypeDefinition(string @namespace, string name, TypeAttributes attributes, TypeReference baseType) : this(@namespace, name, attributes)
		{
			this.BaseType = baseType;
		}
		protected override void ClearFullName()
		{
			base.ClearFullName();
			if (!this.HasNestedTypes)
			{
				return;
			}
			Collection<TypeDefinition> nestedTypes = this.NestedTypes;
			for (int i = 0; i < nestedTypes.Count; i++)
			{
				nestedTypes[i].ClearFullName();
			}
		}
		public override TypeDefinition Resolve()
		{
			return this;
		}
	}
}
