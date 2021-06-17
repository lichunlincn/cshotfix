using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Reflection;
namespace Editor_Mono.Cecil
{
	public class ReflectionImporter : IReflectionImporter
	{
		private enum ImportGenericKind
		{
			Definition,
			Open
		}
		private readonly ModuleDefinition module;
		private static readonly Dictionary<Type, ElementType> type_etype_mapping = new Dictionary<Type, ElementType>(18)
		{

			{
				typeof(void),
				ElementType.Void
			},

			{
				typeof(bool),
				ElementType.Boolean
			},

			{
				typeof(char),
				ElementType.Char
			},

			{
				typeof(sbyte),
				ElementType.I1
			},

			{
				typeof(byte),
				ElementType.U1
			},

			{
				typeof(short),
				ElementType.I2
			},

			{
				typeof(ushort),
				ElementType.U2
			},

			{
				typeof(int),
				ElementType.I4
			},

			{
				typeof(uint),
				ElementType.U4
			},

			{
				typeof(long),
				ElementType.I8
			},

			{
				typeof(ulong),
				ElementType.U8
			},

			{
				typeof(float),
				ElementType.R4
			},

			{
				typeof(double),
				ElementType.R8
			},

			{
				typeof(string),
				ElementType.String
			},

			{
				typeof(TypedReference),
				ElementType.TypedByRef
			},

			{
				typeof(IntPtr),
				ElementType.I
			},

			{
				typeof(UIntPtr),
				ElementType.U
			},

			{
				typeof(object),
				ElementType.Object
			}
		};
		public ReflectionImporter(ModuleDefinition module)
		{
			Mixin.CheckModule(module);
			this.module = module;
		}
		private TypeReference ImportType(Type type, ImportGenericContext context)
		{
			return this.ImportType(type, context, ReflectionImporter.ImportGenericKind.Open);
		}
		private TypeReference ImportType(Type type, ImportGenericContext context, ReflectionImporter.ImportGenericKind import_kind)
		{
			if (ReflectionImporter.IsTypeSpecification(type) || ReflectionImporter.ImportOpenGenericType(type, import_kind))
			{
				return this.ImportTypeSpecification(type, context);
			}
			TypeReference typeReference = new TypeReference(string.Empty, type.Name, this.module, this.ImportScope(type.Assembly), type.IsValueType);
			typeReference.etype = ReflectionImporter.ImportElementType(type);
			if (ReflectionImporter.IsNestedType(type))
			{
				typeReference.DeclaringType = this.ImportType(type.DeclaringType, context, import_kind);
			}
			else
			{
				typeReference.Namespace = (type.Namespace ?? string.Empty);
			}
			if (type.IsGenericType)
			{
				ReflectionImporter.ImportGenericParameters(typeReference, type.GetGenericArguments());
			}
			return typeReference;
		}
		private static bool ImportOpenGenericType(Type type, ReflectionImporter.ImportGenericKind import_kind)
		{
			return type.IsGenericType && type.IsGenericTypeDefinition && import_kind == ReflectionImporter.ImportGenericKind.Open;
		}
		private static bool ImportOpenGenericMethod(MethodBase method, ReflectionImporter.ImportGenericKind import_kind)
		{
			return method.IsGenericMethod && method.IsGenericMethodDefinition && import_kind == ReflectionImporter.ImportGenericKind.Open;
		}
		private static bool IsNestedType(Type type)
		{
			return type.IsNested;
		}
		private TypeReference ImportTypeSpecification(Type type, ImportGenericContext context)
		{
			if (type.IsByRef)
			{
				return new ByReferenceType(this.ImportType(type.GetElementType(), context));
			}
			if (type.IsPointer)
			{
				return new PointerType(this.ImportType(type.GetElementType(), context));
			}
			if (type.IsArray)
			{
				return new ArrayType(this.ImportType(type.GetElementType(), context), type.GetArrayRank());
			}
			if (type.IsGenericType)
			{
				return this.ImportGenericInstance(type, context);
			}
			if (type.IsGenericParameter)
			{
				return ReflectionImporter.ImportGenericParameter(type, context);
			}
			throw new NotSupportedException(type.FullName);
		}
		private static TypeReference ImportGenericParameter(Type type, ImportGenericContext context)
		{
			if (context.IsEmpty)
			{
				throw new InvalidOperationException();
			}
			if (type.DeclaringMethod != null)
			{
				return context.MethodParameter(type.DeclaringMethod.Name, type.GenericParameterPosition);
			}
			if (type.DeclaringType != null)
			{
				return context.TypeParameter(ReflectionImporter.NormalizedFullName(type.DeclaringType), type.GenericParameterPosition);
			}
			throw new InvalidOperationException();
		}
		private static string NormalizedFullName(Type type)
		{
			if (ReflectionImporter.IsNestedType(type))
			{
				return ReflectionImporter.NormalizedFullName(type.DeclaringType) + "/" + type.Name;
			}
			return type.FullName;
		}
		private TypeReference ImportGenericInstance(Type type, ImportGenericContext context)
		{
			TypeReference typeReference = this.ImportType(type.GetGenericTypeDefinition(), context, ReflectionImporter.ImportGenericKind.Definition);
			GenericInstanceType genericInstanceType = new GenericInstanceType(typeReference);
			Type[] genericArguments = type.GetGenericArguments();
			Collection<TypeReference> genericArguments2 = genericInstanceType.GenericArguments;
			context.Push(typeReference);
			TypeReference result;
			try
			{
				for (int i = 0; i < genericArguments.Length; i++)
				{
					genericArguments2.Add(this.ImportType(genericArguments[i], context));
				}
				result = genericInstanceType;
			}
			finally
			{
				context.Pop();
			}
			return result;
		}
		private static bool IsTypeSpecification(Type type)
		{
			return type.HasElementType || ReflectionImporter.IsGenericInstance(type) || type.IsGenericParameter;
		}
		private static bool IsGenericInstance(Type type)
		{
			return type.IsGenericType && !type.IsGenericTypeDefinition;
		}
		private static ElementType ImportElementType(Type type)
		{
			ElementType result;
			if (!ReflectionImporter.type_etype_mapping.TryGetValue(type, out result))
			{
				return ElementType.None;
			}
			return result;
		}
		private AssemblyNameReference ImportScope(Assembly assembly)
		{
			AssemblyName name = assembly.GetName();
			AssemblyNameReference assemblyNameReference;
			if (this.TryGetAssemblyNameReference(name, out assemblyNameReference))
			{
				return assemblyNameReference;
			}
			assemblyNameReference = new AssemblyNameReference(name.Name, name.Version)
			{
				Culture = name.CultureInfo.Name,
				PublicKeyToken = name.GetPublicKeyToken(),
				HashAlgorithm = (AssemblyHashAlgorithm)name.HashAlgorithm
			};
			this.module.AssemblyReferences.Add(assemblyNameReference);
			return assemblyNameReference;
		}
		private bool TryGetAssemblyNameReference(AssemblyName name, out AssemblyNameReference assembly_reference)
		{
			Collection<AssemblyNameReference> assemblyReferences = this.module.AssemblyReferences;
			for (int i = 0; i < assemblyReferences.Count; i++)
			{
				AssemblyNameReference assemblyNameReference = assemblyReferences[i];
				if (!(name.FullName != assemblyNameReference.FullName))
				{
					assembly_reference = assemblyNameReference;
					return true;
				}
			}
			assembly_reference = null;
			return false;
		}
		private FieldReference ImportField(FieldInfo field, ImportGenericContext context)
		{
			TypeReference typeReference = this.ImportType(field.DeclaringType, context);
			if (ReflectionImporter.IsGenericInstance(field.DeclaringType))
			{
				field = ReflectionImporter.ResolveFieldDefinition(field);
			}
			context.Push(typeReference);
			FieldReference result;
			try
			{
				result = new FieldReference
				{
					Name = field.Name,
					DeclaringType = typeReference,
					FieldType = this.ImportType(field.FieldType, context)
				};
			}
			finally
			{
				context.Pop();
			}
			return result;
		}
		private static FieldInfo ResolveFieldDefinition(FieldInfo field)
		{
			return field.Module.ResolveField(field.MetadataToken);
		}
		private MethodReference ImportMethod(MethodBase method, ImportGenericContext context, ReflectionImporter.ImportGenericKind import_kind)
		{
			if (ReflectionImporter.IsMethodSpecification(method) || ReflectionImporter.ImportOpenGenericMethod(method, import_kind))
			{
				return this.ImportMethodSpecification(method, context);
			}
			TypeReference declaringType = this.ImportType(method.DeclaringType, context);
			if (ReflectionImporter.IsGenericInstance(method.DeclaringType))
			{
				method = method.Module.ResolveMethod(method.MetadataToken);
			}
			MethodReference methodReference = new MethodReference
			{
				Name = method.Name,
				HasThis = ReflectionImporter.HasCallingConvention(method, CallingConventions.HasThis),
				ExplicitThis = ReflectionImporter.HasCallingConvention(method, CallingConventions.ExplicitThis),
				DeclaringType = this.ImportType(method.DeclaringType, context, ReflectionImporter.ImportGenericKind.Definition)
			};
			if (ReflectionImporter.HasCallingConvention(method, CallingConventions.VarArgs))
			{
				MethodReference expr_9C = methodReference;
				expr_9C.CallingConvention &= MethodCallingConvention.VarArg;
			}
			if (method.IsGenericMethod)
			{
				ReflectionImporter.ImportGenericParameters(methodReference, method.GetGenericArguments());
			}
			context.Push(methodReference);
			MethodReference result;
			try
			{
				MethodInfo methodInfo = method as MethodInfo;
				methodReference.ReturnType = ((methodInfo != null) ? this.ImportType(methodInfo.ReturnType, context) : this.ImportType(typeof(void), default(ImportGenericContext)));
				ParameterInfo[] parameters = method.GetParameters();
				Collection<ParameterDefinition> parameters2 = methodReference.Parameters;
				for (int i = 0; i < parameters.Length; i++)
				{
					parameters2.Add(new ParameterDefinition(this.ImportType(parameters[i].ParameterType, context)));
				}
				methodReference.DeclaringType = declaringType;
				result = methodReference;
			}
			finally
			{
				context.Pop();
			}
			return result;
		}
		private static void ImportGenericParameters(IGenericParameterProvider provider, Type[] arguments)
		{
			Collection<GenericParameter> genericParameters = provider.GenericParameters;
			for (int i = 0; i < arguments.Length; i++)
			{
				genericParameters.Add(new GenericParameter(arguments[i].Name, provider));
			}
		}
		private static bool IsMethodSpecification(MethodBase method)
		{
			return method.IsGenericMethod && !method.IsGenericMethodDefinition;
		}
		private MethodReference ImportMethodSpecification(MethodBase method, ImportGenericContext context)
		{
			MethodInfo methodInfo = method as MethodInfo;
			if (methodInfo == null)
			{
				throw new InvalidOperationException();
			}
			MethodReference methodReference = this.ImportMethod(methodInfo.GetGenericMethodDefinition(), context, ReflectionImporter.ImportGenericKind.Definition);
			GenericInstanceMethod genericInstanceMethod = new GenericInstanceMethod(methodReference);
			Type[] genericArguments = method.GetGenericArguments();
			Collection<TypeReference> genericArguments2 = genericInstanceMethod.GenericArguments;
			context.Push(methodReference);
			MethodReference result;
			try
			{
				for (int i = 0; i < genericArguments.Length; i++)
				{
					genericArguments2.Add(this.ImportType(genericArguments[i], context));
				}
				result = genericInstanceMethod;
			}
			finally
			{
				context.Pop();
			}
			return result;
		}
		private static bool HasCallingConvention(MethodBase method, CallingConventions conventions)
		{
			return (method.CallingConvention & conventions) != (CallingConventions)0;
		}
		public virtual TypeReference ImportReference(Type type, IGenericParameterProvider context)
		{
			Mixin.CheckType(type);
			return this.ImportType(type, ImportGenericContext.For(context), (context != null) ? ReflectionImporter.ImportGenericKind.Open : ReflectionImporter.ImportGenericKind.Definition);
		}
		public virtual FieldReference ImportReference(FieldInfo field, IGenericParameterProvider context)
		{
			Mixin.CheckField(field);
			return this.ImportField(field, ImportGenericContext.For(context));
		}
		public virtual MethodReference ImportReference(MethodBase method, IGenericParameterProvider context)
		{
			Mixin.CheckMethod(method);
			return this.ImportMethod(method, ImportGenericContext.For(context), (context != null) ? ReflectionImporter.ImportGenericKind.Open : ReflectionImporter.ImportGenericKind.Definition);
		}
	}
}
