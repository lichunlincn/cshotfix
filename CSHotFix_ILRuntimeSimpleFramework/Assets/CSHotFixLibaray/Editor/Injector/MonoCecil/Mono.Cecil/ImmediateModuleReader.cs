using Editor_Mono.Cecil.PE;
using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class ImmediateModuleReader : ModuleReader
	{
		private bool resolve;
		public ImmediateModuleReader(Image image) : base(image, ReadingMode.Immediate)
		{
		}
		protected override void ReadModule()
		{
			this.module.Read<ModuleDefinition, ModuleDefinition>(this.module, delegate(ModuleDefinition module, MetadataReader reader)
			{
				base.ReadModuleManifest(reader);
				this.ReadModule(module, true);
				return module;
			});
		}
		public void ReadModule(ModuleDefinition module, bool resolve)
		{
			this.resolve = resolve;
			if (module.HasAssemblyReferences)
			{
				ImmediateModuleReader.Read(module.AssemblyReferences);
			}
			if (module.HasResources)
			{
				ImmediateModuleReader.Read(module.Resources);
			}
			if (module.HasModuleReferences)
			{
				ImmediateModuleReader.Read(module.ModuleReferences);
			}
			if (module.HasTypes)
			{
				this.ReadTypes(module.Types);
			}
			if (module.HasExportedTypes)
			{
				ImmediateModuleReader.Read(module.ExportedTypes);
			}
			this.ReadCustomAttributes(module);
			AssemblyDefinition assembly = module.Assembly;
			if (assembly == null)
			{
				return;
			}
			this.ReadCustomAttributes(assembly);
			this.ReadSecurityDeclarations(assembly);
		}
		private void ReadTypes(Collection<TypeDefinition> types)
		{
			for (int i = 0; i < types.Count; i++)
			{
				this.ReadType(types[i]);
			}
		}
		private void ReadType(TypeDefinition type)
		{
			this.ReadGenericParameters(type);
			if (type.HasInterfaces)
			{
				ImmediateModuleReader.Read(type.Interfaces);
			}
			if (type.HasNestedTypes)
			{
				this.ReadTypes(type.NestedTypes);
			}
			if (type.HasLayoutInfo)
			{
				ImmediateModuleReader.Read(type.ClassSize);
			}
			if (type.HasFields)
			{
				this.ReadFields(type);
			}
			if (type.HasMethods)
			{
				this.ReadMethods(type);
			}
			if (type.HasProperties)
			{
				this.ReadProperties(type);
			}
			if (type.HasEvents)
			{
				this.ReadEvents(type);
			}
			this.ReadSecurityDeclarations(type);
			this.ReadCustomAttributes(type);
		}
		private void ReadGenericParameters(IGenericParameterProvider provider)
		{
			if (!provider.HasGenericParameters)
			{
				return;
			}
			Collection<GenericParameter> genericParameters = provider.GenericParameters;
			for (int i = 0; i < genericParameters.Count; i++)
			{
				GenericParameter genericParameter = genericParameters[i];
				if (genericParameter.HasConstraints)
				{
					ImmediateModuleReader.Read(genericParameter.Constraints);
				}
				this.ReadCustomAttributes(genericParameter);
			}
		}
		private void ReadSecurityDeclarations(ISecurityDeclarationProvider provider)
		{
			if (!provider.HasSecurityDeclarations)
			{
				return;
			}
			Collection<SecurityDeclaration> securityDeclarations = provider.SecurityDeclarations;
			if (!this.resolve)
			{
				return;
			}
			for (int i = 0; i < securityDeclarations.Count; i++)
			{
				SecurityDeclaration securityDeclaration = securityDeclarations[i];
				ImmediateModuleReader.Read(securityDeclaration.SecurityAttributes);
			}
		}
		private void ReadCustomAttributes(ICustomAttributeProvider provider)
		{
			if (!provider.HasCustomAttributes)
			{
				return;
			}
			Collection<CustomAttribute> customAttributes = provider.CustomAttributes;
			if (!this.resolve)
			{
				return;
			}
			for (int i = 0; i < customAttributes.Count; i++)
			{
				CustomAttribute customAttribute = customAttributes[i];
				ImmediateModuleReader.Read(customAttribute.ConstructorArguments);
			}
		}
		private void ReadFields(TypeDefinition type)
		{
			Collection<FieldDefinition> fields = type.Fields;
			for (int i = 0; i < fields.Count; i++)
			{
				FieldDefinition fieldDefinition = fields[i];
				if (fieldDefinition.HasConstant)
				{
					ImmediateModuleReader.Read(fieldDefinition.Constant);
				}
				if (fieldDefinition.HasLayoutInfo)
				{
					ImmediateModuleReader.Read(fieldDefinition.Offset);
				}
				if (fieldDefinition.RVA > 0)
				{
					ImmediateModuleReader.Read(fieldDefinition.InitialValue);
				}
				if (fieldDefinition.HasMarshalInfo)
				{
					ImmediateModuleReader.Read(fieldDefinition.MarshalInfo);
				}
				this.ReadCustomAttributes(fieldDefinition);
			}
		}
		private void ReadMethods(TypeDefinition type)
		{
			Collection<MethodDefinition> methods = type.Methods;
			for (int i = 0; i < methods.Count; i++)
			{
				MethodDefinition methodDefinition = methods[i];
				this.ReadGenericParameters(methodDefinition);
				if (methodDefinition.HasParameters)
				{
					this.ReadParameters(methodDefinition);
				}
				if (methodDefinition.HasOverrides)
				{
					ImmediateModuleReader.Read(methodDefinition.Overrides);
				}
				if (methodDefinition.IsPInvokeImpl)
				{
					ImmediateModuleReader.Read(methodDefinition.PInvokeInfo);
				}
				this.ReadSecurityDeclarations(methodDefinition);
				this.ReadCustomAttributes(methodDefinition);
				MethodReturnType methodReturnType = methodDefinition.MethodReturnType;
				if (methodReturnType.HasConstant)
				{
					ImmediateModuleReader.Read(methodReturnType.Constant);
				}
				if (methodReturnType.HasMarshalInfo)
				{
					ImmediateModuleReader.Read(methodReturnType.MarshalInfo);
				}
				this.ReadCustomAttributes(methodReturnType);
			}
		}
		private void ReadParameters(MethodDefinition method)
		{
			Collection<ParameterDefinition> parameters = method.Parameters;
			for (int i = 0; i < parameters.Count; i++)
			{
				ParameterDefinition parameterDefinition = parameters[i];
				if (parameterDefinition.HasConstant)
				{
					ImmediateModuleReader.Read(parameterDefinition.Constant);
				}
				if (parameterDefinition.HasMarshalInfo)
				{
					ImmediateModuleReader.Read(parameterDefinition.MarshalInfo);
				}
				this.ReadCustomAttributes(parameterDefinition);
			}
		}
		private void ReadProperties(TypeDefinition type)
		{
			Collection<PropertyDefinition> properties = type.Properties;
			for (int i = 0; i < properties.Count; i++)
			{
				PropertyDefinition propertyDefinition = properties[i];
				ImmediateModuleReader.Read(propertyDefinition.GetMethod);
				if (propertyDefinition.HasConstant)
				{
					ImmediateModuleReader.Read(propertyDefinition.Constant);
				}
				this.ReadCustomAttributes(propertyDefinition);
			}
		}
		private void ReadEvents(TypeDefinition type)
		{
			Collection<EventDefinition> events = type.Events;
			for (int i = 0; i < events.Count; i++)
			{
				EventDefinition eventDefinition = events[i];
				ImmediateModuleReader.Read(eventDefinition.AddMethod);
				this.ReadCustomAttributes(eventDefinition);
			}
		}
		private static void Read(object collection)
		{
		}
	}
}
