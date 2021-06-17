using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public class TypeReference : MemberReference, IGenericParameterProvider, IMetadataTokenProvider, IGenericContext
	{
		private string @namespace;
		private bool value_type;
		internal IMetadataScope scope;
		internal ModuleDefinition module;
		internal ElementType etype;
		private string fullname;
		protected Collection<GenericParameter> generic_parameters;
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
					throw new InvalidOperationException("Projected type reference name can't be changed.");
				}
				base.Name = value;
				this.ClearFullName();
			}
		}
		public virtual string Namespace
		{
			get
			{
				return this.@namespace;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && value != this.@namespace)
				{
					throw new InvalidOperationException("Projected type reference namespace can't be changed.");
				}
				this.@namespace = value;
				this.ClearFullName();
			}
		}
		public virtual bool IsValueType
		{
			get
			{
				return this.value_type;
			}
			set
			{
				this.value_type = value;
			}
		}
		public override ModuleDefinition Module
		{
			get
			{
				if (this.module != null)
				{
					return this.module;
				}
				TypeReference declaringType = this.DeclaringType;
				if (declaringType != null)
				{
					return declaringType.Module;
				}
				return null;
			}
		}
		internal new TypeReferenceProjection WindowsRuntimeProjection
		{
			get
			{
				return (TypeReferenceProjection)this.projection;
			}
			set
			{
				this.projection = value;
			}
		}
		IGenericParameterProvider IGenericContext.Type
		{
			get
			{
				return this;
			}
		}
		IGenericParameterProvider IGenericContext.Method
		{
			get
			{
				return null;
			}
		}
		GenericParameterType IGenericParameterProvider.GenericParameterType
		{
			get
			{
				return GenericParameterType.Type;
			}
		}
		public virtual bool HasGenericParameters
		{
			get
			{
				return !this.generic_parameters.IsNullOrEmpty<GenericParameter>();
			}
		}
		public virtual Collection<GenericParameter> GenericParameters
		{
			get
			{
				if (this.generic_parameters != null)
				{
					return this.generic_parameters;
				}
				return this.generic_parameters = new GenericParameterCollection(this);
			}
		}
		public virtual IMetadataScope Scope
		{
			get
			{
				TypeReference declaringType = this.DeclaringType;
				if (declaringType != null)
				{
					return declaringType.Scope;
				}
				return this.scope;
			}
			set
			{
				TypeReference declaringType = this.DeclaringType;
				if (declaringType != null)
				{
					if (base.IsWindowsRuntimeProjection && value != declaringType.Scope)
					{
						throw new InvalidOperationException("Projected type scope can't be changed.");
					}
					declaringType.Scope = value;
					return;
				}
				else
				{
					if (base.IsWindowsRuntimeProjection && value != this.scope)
					{
						throw new InvalidOperationException("Projected type scope can't be changed.");
					}
					this.scope = value;
					return;
				}
			}
		}
		public bool IsNested
		{
			get
			{
				return this.DeclaringType != null;
			}
		}
		public override TypeReference DeclaringType
		{
			get
			{
				return base.DeclaringType;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && value != base.DeclaringType)
				{
					throw new InvalidOperationException("Projected type declaring type can't be changed.");
				}
				base.DeclaringType = value;
				this.ClearFullName();
			}
		}
		public override string FullName
		{
			get
			{
				if (this.fullname != null)
				{
					return this.fullname;
				}
				this.fullname = this.TypeFullName();
				if (this.IsNested)
				{
					this.fullname = this.DeclaringType.FullName + "/" + this.fullname;
				}
				return this.fullname;
			}
		}
		public virtual bool IsByReference
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsPointer
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsSentinel
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsArray
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsGenericParameter
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsGenericInstance
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsRequiredModifier
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsOptionalModifier
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsPinned
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsFunctionPointer
		{
			get
			{
				return false;
			}
		}
		public virtual bool IsPrimitive
		{
			get
			{
				return this.etype.IsPrimitive();
			}
		}
		public virtual MetadataType MetadataType
		{
			get
			{
				ElementType elementType = this.etype;
				if (elementType != ElementType.None)
				{
					return (MetadataType)this.etype;
				}
				if (!this.IsValueType)
				{
					return MetadataType.Class;
				}
				return MetadataType.ValueType;
			}
		}
		protected TypeReference(string @namespace, string name) : base(name)
		{
			this.@namespace = (@namespace ?? string.Empty);
			this.token = new MetadataToken(TokenType.TypeRef, 0);
		}
		public TypeReference(string @namespace, string name, ModuleDefinition module, IMetadataScope scope) : this(@namespace, name)
		{
			this.module = module;
			this.scope = scope;
		}
		public TypeReference(string @namespace, string name, ModuleDefinition module, IMetadataScope scope, bool valueType) : this(@namespace, name, module, scope)
		{
			this.value_type = valueType;
		}
		protected virtual void ClearFullName()
		{
			this.fullname = null;
		}
		public virtual TypeReference GetElementType()
		{
			return this;
		}
		public virtual TypeDefinition Resolve()
		{
			ModuleDefinition moduleDefinition = this.Module;
			if (moduleDefinition == null)
			{
				throw new NotSupportedException();
			}
			return moduleDefinition.Resolve(this);
		}
	}
}
