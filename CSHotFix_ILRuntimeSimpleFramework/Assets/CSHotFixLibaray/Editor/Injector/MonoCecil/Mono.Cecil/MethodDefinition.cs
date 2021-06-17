using Editor_Mono.Cecil.Cil;
using Editor_Mono.Collections.Generic;
using System;
using System.Threading;
namespace Editor_Mono.Cecil
{
	public sealed class MethodDefinition : MethodReference, IMemberDefinition, ICustomAttributeProvider, ISecurityDeclarationProvider, IMetadataTokenProvider
	{
		private ushort attributes;
		private ushort impl_attributes;
		internal volatile bool sem_attrs_ready;
		internal MethodSemanticsAttributes sem_attrs;
		private Collection<CustomAttribute> custom_attributes;
		private Collection<SecurityDeclaration> security_declarations;
		internal uint rva;
		internal PInvokeInfo pinvoke;
		private Collection<MethodReference> overrides;
		internal MethodBody body;
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
					throw new InvalidOperationException("Projected method name can't be changed.");
				}
				base.Name = value;
			}
		}
		public MethodAttributes Attributes
		{
			get
			{
				return (MethodAttributes)this.attributes;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && value != (MethodAttributes)this.attributes)
				{
					throw new InvalidOperationException("Projected method attributes can't be changed.");
				}
				this.attributes = (ushort)value;
			}
		}
		public MethodImplAttributes ImplAttributes
		{
			get
			{
				return (MethodImplAttributes)this.impl_attributes;
			}
			set
			{
				if (base.IsWindowsRuntimeProjection && value != (MethodImplAttributes)this.impl_attributes)
				{
					throw new InvalidOperationException("Projected method implementation attributes can't be changed.");
				}
				this.impl_attributes = (ushort)value;
			}
		}
		public MethodSemanticsAttributes SemanticsAttributes
		{
			get
			{
				if (this.sem_attrs_ready)
				{
					return this.sem_attrs;
				}
				if (base.HasImage)
				{
					this.ReadSemantics();
					return this.sem_attrs;
				}
				this.sem_attrs = MethodSemanticsAttributes.None;
				this.sem_attrs_ready = true;
				return this.sem_attrs;
			}
			set
			{
				this.sem_attrs = value;
			}
		}
		internal new MethodDefinitionProjection WindowsRuntimeProjection
		{
			get
			{
				return (MethodDefinitionProjection)this.projection;
			}
			set
			{
				this.projection = value;
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
		public int RVA
		{
			get
			{
				return (int)this.rva;
			}
		}
		public bool HasBody
		{
			get
			{
				return (this.attributes & 1024) == 0 && (this.attributes & 8192) == 0 && (this.impl_attributes & 4096) == 0 && (this.impl_attributes & 1) == 0 && (this.impl_attributes & 4) == 0 && (this.impl_attributes & 3) == 0;
			}
		}
		public MethodBody Body
		{
			get
			{
				MethodBody methodBody = this.body;
				if (methodBody != null)
				{
					return methodBody;
				}
				if (!this.HasBody)
				{
					return null;
				}
				if (base.HasImage && this.rva != 0u)
				{
					return this.Module.Read<MethodDefinition, MethodBody>(ref this.body, this, (MethodDefinition method, MetadataReader reader) => reader.ReadMethodBody(method));
				}
				return this.body = new MethodBody(this);
			}
			set
			{
				ModuleDefinition module = this.Module;
				if (module == null)
				{
					this.body = value;
					return;
				}
				object syncRoot;
				Monitor.Enter(syncRoot = module.SyncRoot);
				try
				{
					this.body = value;
				}
				finally
				{
					Monitor.Exit(syncRoot);
				}
			}
		}
		public bool HasPInvokeInfo
		{
			get
			{
				return this.pinvoke != null || this.IsPInvokeImpl;
			}
		}
		public PInvokeInfo PInvokeInfo
		{
			get
			{
				if (this.pinvoke != null)
				{
					return this.pinvoke;
				}
				if (base.HasImage && this.IsPInvokeImpl)
				{
					return this.Module.Read<MethodDefinition, PInvokeInfo>(ref this.pinvoke, this, (MethodDefinition method, MetadataReader reader) => reader.ReadPInvokeInfo(method));
				}
				return null;
			}
			set
			{
				this.IsPInvokeImpl = true;
				this.pinvoke = value;
			}
		}
		public bool HasOverrides
		{
			get
			{
				if (this.overrides != null)
				{
					return this.overrides.Count > 0;
				}
				if (base.HasImage)
				{
					return this.Module.Read<MethodDefinition, bool>(this, (MethodDefinition method, MetadataReader reader) => reader.HasOverrides(method));
				}
				return false;
			}
		}
		public Collection<MethodReference> Overrides
		{
			get
			{
				if (this.overrides != null)
				{
					return this.overrides;
				}
				if (base.HasImage)
				{
					return this.Module.Read<MethodDefinition, Collection<MethodReference>>(ref this.overrides, this, (MethodDefinition method, MetadataReader reader) => reader.ReadOverrides(method));
				}
				return this.overrides = new Collection<MethodReference>();
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
		public bool IsCompilerControlled
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 0u, value);
			}
		}
		public bool IsPrivate
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 1u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 1u, value);
			}
		}
		public bool IsFamilyAndAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 2u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 2u, value);
			}
		}
		public bool IsAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 3u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 3u, value);
			}
		}
		public bool IsFamily
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 4u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 4u, value);
			}
		}
		public bool IsFamilyOrAssembly
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 5u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 5u, value);
			}
		}
		public bool IsPublic
		{
			get
			{
				return this.attributes.GetMaskedAttributes(7, 6u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(7, 6u, value);
			}
		}
		public bool IsStatic
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
		public bool IsFinal
		{
			get
			{
				return this.attributes.GetAttributes(32);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(32, value);
			}
		}
		public bool IsVirtual
		{
			get
			{
				return this.attributes.GetAttributes(64);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(64, value);
			}
		}
		public bool IsHideBySig
		{
			get
			{
				return this.attributes.GetAttributes(128);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(128, value);
			}
		}
		public bool IsReuseSlot
		{
			get
			{
				return this.attributes.GetMaskedAttributes(256, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(256, 0u, value);
			}
		}
		public bool IsNewSlot
		{
			get
			{
				return this.attributes.GetMaskedAttributes(256, 256u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(256, 256u, value);
			}
		}
		public bool IsCheckAccessOnOverride
		{
			get
			{
				return this.attributes.GetAttributes(512);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(512, value);
			}
		}
		public bool IsAbstract
		{
			get
			{
				return this.attributes.GetAttributes(1024);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(1024, value);
			}
		}
		public bool IsSpecialName
		{
			get
			{
				return this.attributes.GetAttributes(2048);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(2048, value);
			}
		}
		public bool IsPInvokeImpl
		{
			get
			{
				return this.attributes.GetAttributes(8192);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(8192, value);
			}
		}
		public bool IsUnmanagedExport
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
		public bool IsRuntimeSpecialName
		{
			get
			{
				return this.attributes.GetAttributes(4096);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(4096, value);
			}
		}
		public bool HasSecurity
		{
			get
			{
				return this.attributes.GetAttributes(16384);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(16384, value);
			}
		}
		public bool IsIL
		{
			get
			{
				return this.impl_attributes.GetMaskedAttributes(3, 0u);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetMaskedAttributes(3, 0u, value);
			}
		}
		public bool IsNative
		{
			get
			{
				return this.impl_attributes.GetMaskedAttributes(3, 1u);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetMaskedAttributes(3, 1u, value);
			}
		}
		public bool IsRuntime
		{
			get
			{
				return this.impl_attributes.GetMaskedAttributes(3, 3u);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetMaskedAttributes(3, 3u, value);
			}
		}
		public bool IsUnmanaged
		{
			get
			{
				return this.impl_attributes.GetMaskedAttributes(4, 4u);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetMaskedAttributes(4, 4u, value);
			}
		}
		public bool IsManaged
		{
			get
			{
				return this.impl_attributes.GetMaskedAttributes(4, 0u);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetMaskedAttributes(4, 0u, value);
			}
		}
		public bool IsForwardRef
		{
			get
			{
				return this.impl_attributes.GetAttributes(16);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(16, value);
			}
		}
		public bool IsPreserveSig
		{
			get
			{
				return this.impl_attributes.GetAttributes(128);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(128, value);
			}
		}
		public bool IsInternalCall
		{
			get
			{
				return this.impl_attributes.GetAttributes(4096);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(4096, value);
			}
		}
		public bool IsSynchronized
		{
			get
			{
				return this.impl_attributes.GetAttributes(32);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(32, value);
			}
		}
		public bool NoInlining
		{
			get
			{
				return this.impl_attributes.GetAttributes(8);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(8, value);
			}
		}
		public bool NoOptimization
		{
			get
			{
				return this.impl_attributes.GetAttributes(64);
			}
			set
			{
				this.impl_attributes = this.impl_attributes.SetAttributes(64, value);
			}
		}
		public bool IsSetter
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.Setter);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.Setter, value);
			}
		}
		public bool IsGetter
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.Getter);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.Getter, value);
			}
		}
		public bool IsOther
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.Other);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.Other, value);
			}
		}
		public bool IsAddOn
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.AddOn);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.AddOn, value);
			}
		}
		public bool IsRemoveOn
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.RemoveOn);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.RemoveOn, value);
			}
		}
		public bool IsFire
		{
			get
			{
				return this.GetSemantics(MethodSemanticsAttributes.Fire);
			}
			set
			{
				this.SetSemantics(MethodSemanticsAttributes.Fire, value);
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
		public bool IsConstructor
		{
			get
			{
				return this.IsRuntimeSpecialName && this.IsSpecialName && (this.Name == ".cctor" || this.Name == ".ctor");
			}
		}
		public override bool IsDefinition
		{
			get
			{
				return true;
			}
		}
		internal void ReadSemantics()
		{
			if (this.sem_attrs_ready)
			{
				return;
			}
			ModuleDefinition module = this.Module;
			if (module == null)
			{
				return;
			}
			if (!module.HasImage)
			{
				return;
			}
			module.Read<MethodDefinition, MethodSemanticsAttributes>(this, (MethodDefinition method, MetadataReader reader) => reader.ReadAllSemantics(method));
		}
		internal MethodDefinition()
		{
			this.token = new MetadataToken(TokenType.Method);
		}
		public MethodDefinition(string name, MethodAttributes attributes, TypeReference returnType) : base(name, returnType)
		{
			this.attributes = (ushort)attributes;
			this.HasThis = !this.IsStatic;
			this.token = new MetadataToken(TokenType.Method);
		}
		public override MethodDefinition Resolve()
		{
			return this;
		}
	}
}
