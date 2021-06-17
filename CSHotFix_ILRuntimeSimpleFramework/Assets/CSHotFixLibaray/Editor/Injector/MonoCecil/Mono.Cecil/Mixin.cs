using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using Editor_Mono.Security.Cryptography;
using System;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
namespace Editor_Mono.Cecil
{
	internal static class Mixin
	{
		public const int NotResolvedMarker = -2;
		public const int NoDataMarker = -1;
		public static Version ZeroVersion = new Version(0, 0, 0, 0);
		internal static object NoValue = new object();
		internal static object NotResolved = new object();
		public static uint ReadCompressedUInt32(this byte[] data, ref int position)
		{
			uint num;
			if ((data[position] & 128) == 0)
			{
				num = (uint)data[position];
				position++;
			}
			else
			{
				if ((data[position] & 64) == 0)
				{
					num = ((uint)data[position] & 4294967167u) << 8;
					num |= (uint)data[position + 1];
					position += 2;
				}
				else
				{
					num = ((uint)data[position] & 4294967103u) << 24;
					num |= (uint)((uint)data[position + 1] << 16);
					num |= (uint)((uint)data[position + 2] << 8);
					num |= (uint)data[position + 3];
					position += 4;
				}
			}
			return num;
		}
		public static MetadataToken GetMetadataToken(this CodedIndex self, uint data)
		{
			uint rid;
			TokenType type;
			switch (self)
			{
			case CodedIndex.TypeDefOrRef:
				rid = data >> 2;
				switch (data & 3u)
				{
				case 0u:
					type = TokenType.TypeDef;
					break;
				case 1u:
					type = TokenType.TypeRef;
					break;
				case 2u:
					type = TokenType.TypeSpec;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.HasConstant:
				rid = data >> 2;
				switch (data & 3u)
				{
				case 0u:
					type = TokenType.Field;
					break;
				case 1u:
					type = TokenType.Param;
					break;
				case 2u:
					type = TokenType.Property;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.HasCustomAttribute:
				rid = data >> 5;
				switch (data & 31u)
				{
				case 0u:
					type = TokenType.Method;
					break;
				case 1u:
					type = TokenType.Field;
					break;
				case 2u:
					type = TokenType.TypeRef;
					break;
				case 3u:
					type = TokenType.TypeDef;
					break;
				case 4u:
					type = TokenType.Param;
					break;
				case 5u:
					type = TokenType.InterfaceImpl;
					break;
				case 6u:
					type = TokenType.MemberRef;
					break;
				case 7u:
					type = TokenType.Module;
					break;
				case 8u:
					type = TokenType.Permission;
					break;
				case 9u:
					type = TokenType.Property;
					break;
				case 10u:
					type = TokenType.Event;
					break;
				case 11u:
					type = TokenType.Signature;
					break;
				case 12u:
					type = TokenType.ModuleRef;
					break;
				case 13u:
					type = TokenType.TypeSpec;
					break;
				case 14u:
					type = TokenType.Assembly;
					break;
				case 15u:
					type = TokenType.AssemblyRef;
					break;
				case 16u:
					type = TokenType.File;
					break;
				case 17u:
					type = TokenType.ExportedType;
					break;
				case 18u:
					type = TokenType.ManifestResource;
					break;
				case 19u:
					type = TokenType.GenericParam;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.HasFieldMarshal:
				rid = data >> 1;
				switch (data & 1u)
				{
				case 0u:
					type = TokenType.Field;
					break;
				case 1u:
					type = TokenType.Param;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.HasDeclSecurity:
				rid = data >> 2;
				switch (data & 3u)
				{
				case 0u:
					type = TokenType.TypeDef;
					break;
				case 1u:
					type = TokenType.Method;
					break;
				case 2u:
					type = TokenType.Assembly;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.MemberRefParent:
				rid = data >> 3;
				switch (data & 7u)
				{
				case 0u:
					type = TokenType.TypeDef;
					break;
				case 1u:
					type = TokenType.TypeRef;
					break;
				case 2u:
					type = TokenType.ModuleRef;
					break;
				case 3u:
					type = TokenType.Method;
					break;
				case 4u:
					type = TokenType.TypeSpec;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.HasSemantics:
				rid = data >> 1;
				switch (data & 1u)
				{
				case 0u:
					type = TokenType.Event;
					break;
				case 1u:
					type = TokenType.Property;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.MethodDefOrRef:
				rid = data >> 1;
				switch (data & 1u)
				{
				case 0u:
					type = TokenType.Method;
					break;
				case 1u:
					type = TokenType.MemberRef;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.MemberForwarded:
				rid = data >> 1;
				switch (data & 1u)
				{
				case 0u:
					type = TokenType.Field;
					break;
				case 1u:
					type = TokenType.Method;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.Implementation:
				rid = data >> 2;
				switch (data & 3u)
				{
				case 0u:
					type = TokenType.File;
					break;
				case 1u:
					type = TokenType.AssemblyRef;
					break;
				case 2u:
					type = TokenType.ExportedType;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.CustomAttributeType:
				rid = data >> 3;
				switch (data & 7u)
				{
				case 2u:
					type = TokenType.Method;
					break;
				case 3u:
					type = TokenType.MemberRef;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.ResolutionScope:
				rid = data >> 2;
				switch (data & 3u)
				{
				case 0u:
					type = TokenType.Module;
					break;
				case 1u:
					type = TokenType.ModuleRef;
					break;
				case 2u:
					type = TokenType.AssemblyRef;
					break;
				case 3u:
					type = TokenType.TypeRef;
					break;
				default:
					goto IL_44B;
				}
				break;
			case CodedIndex.TypeOrMethodDef:
				rid = data >> 1;
				switch (data & 1u)
				{
				case 0u:
					type = TokenType.TypeDef;
					break;
				case 1u:
					type = TokenType.Method;
					break;
				default:
					goto IL_44B;
				}
				break;
			default:
				goto IL_44B;
			}
			return new MetadataToken(type, rid);
			IL_44B:
			return MetadataToken.Zero;
		}
		public static uint CompressMetadataToken(this CodedIndex self, MetadataToken token)
		{
			uint num = 0u;
			if (token.RID == 0u)
			{
				return num;
			}
			switch (self)
			{
			case CodedIndex.TypeDefOrRef:
			{
				num = token.RID << 2;
				TokenType tokenType = token.TokenType;
				if (tokenType == TokenType.TypeRef)
				{
					return num | 1u;
				}
				if (tokenType == TokenType.TypeDef)
				{
					return num;
				}
				if (tokenType == TokenType.TypeSpec)
				{
					return num | 2u;
				}
				break;
			}
			case CodedIndex.HasConstant:
			{
				num = token.RID << 2;
				TokenType tokenType2 = token.TokenType;
				if (tokenType2 == TokenType.Field)
				{
					return num;
				}
				if (tokenType2 == TokenType.Param)
				{
					return num | 1u;
				}
				if (tokenType2 == TokenType.Property)
				{
					return num | 2u;
				}
				break;
			}
			case CodedIndex.HasCustomAttribute:
			{
				num = token.RID << 5;
				TokenType tokenType3 = token.TokenType;
				if (tokenType3 <= TokenType.Signature)
				{
					if (tokenType3 <= TokenType.Method)
					{
						if (tokenType3 <= TokenType.TypeRef)
						{
							if (tokenType3 == TokenType.Module)
							{
								return num | 7u;
							}
							if (tokenType3 == TokenType.TypeRef)
							{
								return num | 2u;
							}
						}
						else
						{
							if (tokenType3 == TokenType.TypeDef)
							{
								return num | 3u;
							}
							if (tokenType3 == TokenType.Field)
							{
								return num | 1u;
							}
							if (tokenType3 == TokenType.Method)
							{
								return num;
							}
						}
					}
					else
					{
						if (tokenType3 <= TokenType.InterfaceImpl)
						{
							if (tokenType3 == TokenType.Param)
							{
								return num | 4u;
							}
							if (tokenType3 == TokenType.InterfaceImpl)
							{
								return num | 5u;
							}
						}
						else
						{
							if (tokenType3 == TokenType.MemberRef)
							{
								return num | 6u;
							}
							if (tokenType3 == TokenType.Permission)
							{
								return num | 8u;
							}
							if (tokenType3 == TokenType.Signature)
							{
								return num | 11u;
							}
						}
					}
				}
				else
				{
					if (tokenType3 <= TokenType.Assembly)
					{
						if (tokenType3 <= TokenType.Property)
						{
							if (tokenType3 == TokenType.Event)
							{
								return num | 10u;
							}
							if (tokenType3 == TokenType.Property)
							{
								return num | 9u;
							}
						}
						else
						{
							if (tokenType3 == TokenType.ModuleRef)
							{
								return num | 12u;
							}
							if (tokenType3 == TokenType.TypeSpec)
							{
								return num | 13u;
							}
							if (tokenType3 == TokenType.Assembly)
							{
								return num | 14u;
							}
						}
					}
					else
					{
						if (tokenType3 <= TokenType.File)
						{
							if (tokenType3 == TokenType.AssemblyRef)
							{
								return num | 15u;
							}
							if (tokenType3 == TokenType.File)
							{
								return num | 16u;
							}
						}
						else
						{
							if (tokenType3 == TokenType.ExportedType)
							{
								return num | 17u;
							}
							if (tokenType3 == TokenType.ManifestResource)
							{
								return num | 18u;
							}
							if (tokenType3 == TokenType.GenericParam)
							{
								return num | 19u;
							}
						}
					}
				}
				break;
			}
			case CodedIndex.HasFieldMarshal:
			{
				num = token.RID << 1;
				TokenType tokenType4 = token.TokenType;
				if (tokenType4 == TokenType.Field)
				{
					return num;
				}
				if (tokenType4 == TokenType.Param)
				{
					return num | 1u;
				}
				break;
			}
			case CodedIndex.HasDeclSecurity:
			{
				num = token.RID << 2;
				TokenType tokenType5 = token.TokenType;
				if (tokenType5 == TokenType.TypeDef)
				{
					return num;
				}
				if (tokenType5 == TokenType.Method)
				{
					return num | 1u;
				}
				if (tokenType5 == TokenType.Assembly)
				{
					return num | 2u;
				}
				break;
			}
			case CodedIndex.MemberRefParent:
			{
				num = token.RID << 3;
				TokenType tokenType6 = token.TokenType;
				if (tokenType6 <= TokenType.TypeDef)
				{
					if (tokenType6 == TokenType.TypeRef)
					{
						return num | 1u;
					}
					if (tokenType6 == TokenType.TypeDef)
					{
						return num;
					}
				}
				else
				{
					if (tokenType6 == TokenType.Method)
					{
						return num | 3u;
					}
					if (tokenType6 == TokenType.ModuleRef)
					{
						return num | 2u;
					}
					if (tokenType6 == TokenType.TypeSpec)
					{
						return num | 4u;
					}
				}
				break;
			}
			case CodedIndex.HasSemantics:
			{
				num = token.RID << 1;
				TokenType tokenType7 = token.TokenType;
				if (tokenType7 == TokenType.Event)
				{
					return num;
				}
				if (tokenType7 == TokenType.Property)
				{
					return num | 1u;
				}
				break;
			}
			case CodedIndex.MethodDefOrRef:
			{
				num = token.RID << 1;
				TokenType tokenType8 = token.TokenType;
				if (tokenType8 == TokenType.Method)
				{
					return num;
				}
				if (tokenType8 == TokenType.MemberRef)
				{
					return num | 1u;
				}
				break;
			}
			case CodedIndex.MemberForwarded:
			{
				num = token.RID << 1;
				TokenType tokenType9 = token.TokenType;
				if (tokenType9 == TokenType.Field)
				{
					return num;
				}
				if (tokenType9 == TokenType.Method)
				{
					return num | 1u;
				}
				break;
			}
			case CodedIndex.Implementation:
			{
				num = token.RID << 2;
				TokenType tokenType10 = token.TokenType;
				if (tokenType10 == TokenType.AssemblyRef)
				{
					return num | 1u;
				}
				if (tokenType10 == TokenType.File)
				{
					return num;
				}
				if (tokenType10 == TokenType.ExportedType)
				{
					return num | 2u;
				}
				break;
			}
			case CodedIndex.CustomAttributeType:
			{
				num = token.RID << 3;
				TokenType tokenType11 = token.TokenType;
				if (tokenType11 == TokenType.Method)
				{
					return num | 2u;
				}
				if (tokenType11 == TokenType.MemberRef)
				{
					return num | 3u;
				}
				break;
			}
			case CodedIndex.ResolutionScope:
			{
				num = token.RID << 2;
				TokenType tokenType12 = token.TokenType;
				if (tokenType12 <= TokenType.TypeRef)
				{
					if (tokenType12 == TokenType.Module)
					{
						return num;
					}
					if (tokenType12 == TokenType.TypeRef)
					{
						return num | 3u;
					}
				}
				else
				{
					if (tokenType12 == TokenType.ModuleRef)
					{
						return num | 1u;
					}
					if (tokenType12 == TokenType.AssemblyRef)
					{
						return num | 2u;
					}
				}
				break;
			}
			case CodedIndex.TypeOrMethodDef:
			{
				num = token.RID << 1;
				TokenType tokenType13 = token.TokenType;
				if (tokenType13 == TokenType.TypeDef)
				{
					return num;
				}
				if (tokenType13 == TokenType.Method)
				{
					return num | 1u;
				}
				break;
			}
			}
			throw new ArgumentException();
		}
		public static int GetSize(this CodedIndex self, Func<Table, int> counter)
		{
			int num;
			Table[] array;
			switch (self)
			{
			case CodedIndex.TypeDefOrRef:
				num = 2;
				array = new Table[]
				{
					Table.TypeDef,
					Table.TypeRef,
					Table.TypeSpec
				};
				break;
			case CodedIndex.HasConstant:
				num = 2;
				array = new Table[]
				{
					Table.Field,
					Table.Param,
					Table.Property
				};
				break;
			case CodedIndex.HasCustomAttribute:
				num = 5;
				array = new Table[]
				{
					Table.Method,
					Table.Field,
					Table.TypeRef,
					Table.TypeDef,
					Table.Param,
					Table.InterfaceImpl,
					Table.MemberRef,
					Table.Module,
					Table.DeclSecurity,
					Table.Property,
					Table.Event,
					Table.StandAloneSig,
					Table.ModuleRef,
					Table.TypeSpec,
					Table.Assembly,
					Table.AssemblyRef,
					Table.File,
					Table.ExportedType,
					Table.ManifestResource,
					Table.GenericParam
				};
				break;
			case CodedIndex.HasFieldMarshal:
				num = 1;
				array = new Table[]
				{
					Table.Field,
					Table.Param
				};
				break;
			case CodedIndex.HasDeclSecurity:
				num = 2;
				array = new Table[]
				{
					Table.TypeDef,
					Table.Method,
					Table.Assembly
				};
				break;
			case CodedIndex.MemberRefParent:
				num = 3;
				array = new Table[]
				{
					Table.TypeDef,
					Table.TypeRef,
					Table.ModuleRef,
					Table.Method,
					Table.TypeSpec
				};
				break;
			case CodedIndex.HasSemantics:
				num = 1;
				array = new Table[]
				{
					Table.Event,
					Table.Property
				};
				break;
			case CodedIndex.MethodDefOrRef:
				num = 1;
				array = new Table[]
				{
					Table.Method,
					Table.MemberRef
				};
				break;
			case CodedIndex.MemberForwarded:
				num = 1;
				array = new Table[]
				{
					Table.Field,
					Table.Method
				};
				break;
			case CodedIndex.Implementation:
				num = 2;
				array = new Table[]
				{
					Table.File,
					Table.AssemblyRef,
					Table.ExportedType
				};
				break;
			case CodedIndex.CustomAttributeType:
				num = 3;
				array = new Table[]
				{
					Table.Method,
					Table.MemberRef
				};
				break;
			case CodedIndex.ResolutionScope:
				num = 2;
				array = new Table[]
				{
					Table.Module,
					Table.ModuleRef,
					Table.AssemblyRef,
					Table.TypeRef
				};
				break;
			case CodedIndex.TypeOrMethodDef:
				num = 1;
				array = new Table[]
				{
					Table.TypeDef,
					Table.Method
				};
				break;
			default:
				throw new ArgumentException();
			}
			int num2 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				num2 = System.Math.Max(counter(array[i]), num2);
			}
			if (num2 >= 1 << 16 - num)
			{
				return 4;
			}
			return 2;
		}
		public static Version CheckVersion(Version version)
		{
			if (version == null)
			{
				return Mixin.ZeroVersion;
			}
			if (version.Build == -1)
			{
				return new Version(version.Major, version.Minor, 0, 0);
			}
			if (version.Revision == -1)
			{
				return new Version(version.Major, version.Minor, version.Build, 0);
			}
			return version;
		}
		public static void CheckModule(ModuleDefinition module)
		{
			if (module == null)
			{
				throw new ArgumentNullException("module");
			}
		}
		public static bool TryGetAssemblyNameReference(this ModuleDefinition module, AssemblyNameReference name_reference, out AssemblyNameReference assembly_reference)
		{
			Collection<AssemblyNameReference> assemblyReferences = module.AssemblyReferences;
			for (int i = 0; i < assemblyReferences.Count; i++)
			{
				AssemblyNameReference assemblyNameReference = assemblyReferences[i];
				if (Mixin.Equals(name_reference, assemblyNameReference))
				{
					assembly_reference = assemblyNameReference;
					return true;
				}
			}
			assembly_reference = null;
			return false;
		}
		private static bool Equals(byte[] a, byte[] b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			if (a == null)
			{
				return false;
			}
			if (a.Length != b.Length)
			{
				return false;
			}
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] != b[i])
				{
					return false;
				}
			}
			return true;
		}
		private static bool Equals<T>(T a, T b) where T : class, IEquatable<T>
		{
			return object.ReferenceEquals(a, b) || (a != null && a.Equals(b));
		}
		private static bool Equals(AssemblyNameReference a, AssemblyNameReference b)
		{
			return object.ReferenceEquals(a, b) || (!(a.Name != b.Name) && Mixin.Equals<Version>(a.Version, b.Version) && !(a.Culture != b.Culture) && Mixin.Equals(a.PublicKeyToken, b.PublicKeyToken));
		}
		public static bool GetHasSecurityDeclarations(this ISecurityDeclarationProvider self, ModuleDefinition module)
		{
			if (module.HasImage())
			{
				return module.Read<ISecurityDeclarationProvider, bool>(self, (ISecurityDeclarationProvider provider, MetadataReader reader) => reader.HasSecurityDeclarations(provider));
			}
			return false;
		}
		public static Collection<SecurityDeclaration> GetSecurityDeclarations(this ISecurityDeclarationProvider self, ref Collection<SecurityDeclaration> variable, ModuleDefinition module)
		{
			if (!module.HasImage())
			{
				Collection<SecurityDeclaration> result;
				variable = (result = new Collection<SecurityDeclaration>());
				return result;
			}
			return module.Read<ISecurityDeclarationProvider, Collection<SecurityDeclaration>>(ref variable, self, (ISecurityDeclarationProvider provider, MetadataReader reader) => reader.ReadSecurityDeclarations(provider));
		}
		public static void CheckName(string name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (name.Length == 0)
			{
				throw new ArgumentException("Empty name");
			}
		}
		public static void ResolveConstant(this IConstantProvider self, ref object constant, ModuleDefinition module)
		{
			if (module == null)
			{
				constant = Mixin.NoValue;
				return;
			}
			object syncRoot;
			Monitor.Enter(syncRoot = module.SyncRoot);
			try
			{
				if (constant == Mixin.NotResolved)
				{
					if (module.HasImage())
					{
						constant = module.Read<IConstantProvider, object>(self, (IConstantProvider provider, MetadataReader reader) => reader.ReadConstant(provider));
					}
					else
					{
						constant = Mixin.NoValue;
					}
				}
			}
			finally
			{
				Monitor.Exit(syncRoot);
			}
		}
		public static bool GetHasCustomAttributes(this ICustomAttributeProvider self, ModuleDefinition module)
		{
			if (module.HasImage())
			{
				return module.Read<ICustomAttributeProvider, bool>(self, (ICustomAttributeProvider provider, MetadataReader reader) => reader.HasCustomAttributes(provider));
			}
			return false;
		}
		public static Collection<CustomAttribute> GetCustomAttributes(this ICustomAttributeProvider self, ref Collection<CustomAttribute> variable, ModuleDefinition module)
		{
			if (!module.HasImage())
			{
				Collection<CustomAttribute> result;
				variable = (result = new Collection<CustomAttribute>());
				return result;
			}
			return module.Read<ICustomAttributeProvider, Collection<CustomAttribute>>(ref variable, self, (ICustomAttributeProvider provider, MetadataReader reader) => reader.ReadCustomAttributes(provider));
		}
		public static bool ContainsGenericParameter(this IGenericInstance self)
		{
			Collection<TypeReference> genericArguments = self.GenericArguments;
			for (int i = 0; i < genericArguments.Count; i++)
			{
				if (genericArguments[i].ContainsGenericParameter)
				{
					return true;
				}
			}
			return false;
		}
		public static void GenericInstanceFullName(this IGenericInstance self, StringBuilder builder)
		{
			builder.Append("<");
			Collection<TypeReference> genericArguments = self.GenericArguments;
			for (int i = 0; i < genericArguments.Count; i++)
			{
				if (i > 0)
				{
					builder.Append(",");
				}
				builder.Append(genericArguments[i].FullName);
			}
			builder.Append(">");
		}
		public static bool GetHasGenericParameters(this IGenericParameterProvider self, ModuleDefinition module)
		{
			if (module.HasImage())
			{
				return module.Read<IGenericParameterProvider, bool>(self, (IGenericParameterProvider provider, MetadataReader reader) => reader.HasGenericParameters(provider));
			}
			return false;
		}
		public static Collection<GenericParameter> GetGenericParameters(this IGenericParameterProvider self, ref Collection<GenericParameter> collection, ModuleDefinition module)
		{
			if (!module.HasImage())
			{
				Collection<GenericParameter> result;
				collection = (result = new GenericParameterCollection(self));
				return result;
			}
			return module.Read<IGenericParameterProvider, Collection<GenericParameter>>(ref collection, self, (IGenericParameterProvider provider, MetadataReader reader) => reader.ReadGenericParameters(provider));
		}
		public static bool GetHasMarshalInfo(this IMarshalInfoProvider self, ModuleDefinition module)
		{
			if (module.HasImage())
			{
				return module.Read<IMarshalInfoProvider, bool>(self, (IMarshalInfoProvider provider, MetadataReader reader) => reader.HasMarshalInfo(provider));
			}
			return false;
		}
		public static MarshalInfo GetMarshalInfo(this IMarshalInfoProvider self, ref MarshalInfo variable, ModuleDefinition module)
		{
			if (!module.HasImage())
			{
				return null;
			}
			return module.Read<IMarshalInfoProvider, MarshalInfo>(ref variable, self, (IMarshalInfoProvider provider, MetadataReader reader) => reader.ReadMarshalInfo(provider));
		}
		public static void CheckModifier(TypeReference modifierType, TypeReference type)
		{
			if (modifierType == null)
			{
				throw new ArgumentNullException("modifierType");
			}
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
		}
		public static bool HasImplicitThis(this IMethodSignature self)
		{
			return self.HasThis && !self.ExplicitThis;
		}
		public static void MethodSignatureFullName(this IMethodSignature self, StringBuilder builder)
		{
			builder.Append("(");
			if (self.HasParameters)
			{
				Collection<ParameterDefinition> parameters = self.Parameters;
				for (int i = 0; i < parameters.Count; i++)
				{
					ParameterDefinition parameterDefinition = parameters[i];
					if (i > 0)
					{
						builder.Append(",");
					}
					if (parameterDefinition.ParameterType.IsSentinel)
					{
						builder.Append("...,");
					}
					builder.Append(parameterDefinition.ParameterType.FullName);
				}
			}
			builder.Append(")");
		}
		public static bool GetAttributes(this uint self, uint attributes)
		{
			return (self & attributes) != 0u;
		}
		public static uint SetAttributes(this uint self, uint attributes, bool value)
		{
			if (value)
			{
				return self | attributes;
			}
			return self & ~attributes;
		}
		public static bool GetMaskedAttributes(this uint self, uint mask, uint attributes)
		{
			return (self & mask) == attributes;
		}
		public static uint SetMaskedAttributes(this uint self, uint mask, uint attributes, bool value)
		{
			if (value)
			{
				self &= ~mask;
				return self | attributes;
			}
			return self & ~(mask & attributes);
		}
		public static bool GetAttributes(this ushort self, ushort attributes)
		{
			return (self & attributes) != 0;
		}
        public static ushort SetAttributes(this ushort self, ushort attributes, bool value)
        {
            if (value)
                return (ushort)(self | attributes);

            return (ushort)(self & ~attributes);
        }
        public static bool GetMaskedAttributes(this ushort self, ushort mask, uint attributes)
		{
			return (long)(self & mask) == (long)((ulong)attributes);
		}
        public static ushort SetMaskedAttributes(this ushort self, ushort mask, uint attributes, bool value)
        {
            if (value)
            {
                self = (ushort)(self & ~mask);
                return (ushort)(self | attributes);
            }

            return (ushort)(self & ~(mask & attributes));
        }
        public static ParameterDefinition GetParameter(this Editor_Mono.Cecil.Cil.MethodBody self, int index)
		{
			MethodDefinition method = self.method;
			if (method.HasThis)
			{
				if (index == 0)
				{
					return self.ThisParameter;
				}
				index--;
			}
			Collection<ParameterDefinition> parameters = method.Parameters;
			if (index < 0 || index >= parameters.size)
			{
				return null;
			}
			return parameters[index];
		}
		public static VariableDefinition GetVariable(this Editor_Mono.Cecil.Cil.MethodBody self, int index)
		{
			Collection<VariableDefinition> variables = self.Variables;
			if (index < 0 || index >= variables.size)
			{
				return null;
			}
			return variables[index];
		}
		public static bool GetSemantics(this MethodDefinition self, MethodSemanticsAttributes semantics)
		{
			return (ushort)(self.SemanticsAttributes & semantics) != 0;
		}
		public static void SetSemantics(this MethodDefinition self, MethodSemanticsAttributes semantics, bool value)
		{
			if (value)
			{
				self.SemanticsAttributes |= semantics;
				return;
			}
			self.SemanticsAttributes &= ~semantics;
		}
		public static bool IsVarArg(this IMethodSignature self)
		{
			return (byte)(self.CallingConvention & MethodCallingConvention.VarArg) != 0;
		}
		public static int GetSentinelPosition(this IMethodSignature self)
		{
			if (!self.HasParameters)
			{
				return -1;
			}
			Collection<ParameterDefinition> parameters = self.Parameters;
			for (int i = 0; i < parameters.Count; i++)
			{
				if (parameters[i].ParameterType.IsSentinel)
				{
					return i;
				}
			}
			return -1;
		}
		public static void CheckStream(object stream)
		{
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
		}
		public static void CheckType(object type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
		}
		public static void CheckField(object field)
		{
			if (field == null)
			{
				throw new ArgumentNullException("field");
			}
		}
		public static void CheckMethod(object method)
		{
			if (method == null)
			{
				throw new ArgumentNullException("method");
			}
		}
		public static void CheckParameters(object parameters)
		{
			if (parameters == null)
			{
				throw new ArgumentNullException("parameters");
			}
		}
		public static bool HasImage(this ModuleDefinition self)
		{
			return self != null && self.HasImage;
		}
		public static bool IsCoreLibrary(this ModuleDefinition module)
		{
			if (module.Assembly == null)
			{
				return false;
			}
			string name = module.Assembly.Name.Name;
			if (name != "mscorlib" && name != "System.Runtime")
			{
				return false;
			}
			if (module.HasImage)
			{
				if (!module.Read<ModuleDefinition, bool>(module, (ModuleDefinition m, MetadataReader reader) => reader.image.GetTableLength(Table.TypeDef) > 1))
				{
					return false;
				}
			}
			return true;
		}
		public static string GetFullyQualifiedName(this Stream self)
		{
			FileStream fileStream = self as FileStream;
			if (fileStream == null)
			{
				return string.Empty;
			}
			return Path.GetFullPath(fileStream.Name);
		}
		public static TargetRuntime ParseRuntime(this string self)
		{
			switch (self[1])
			{
			case '1':
				if (self[3] != '0')
				{
					return TargetRuntime.Net_1_1;
				}
				return TargetRuntime.Net_1_0;
			case '2':
				return TargetRuntime.Net_2_0;
			}
			return TargetRuntime.Net_4_0;
		}
		public static string RuntimeVersionString(this TargetRuntime runtime)
		{
			switch (runtime)
			{
			case TargetRuntime.Net_1_0:
				return "v1.0.3705";
			case TargetRuntime.Net_1_1:
				return "v1.1.4322";
			case TargetRuntime.Net_2_0:
				return "v2.0.50727";
			}
			return "v4.0.30319";
		}
		public static bool IsWindowsMetadata(this ModuleDefinition module)
		{
			return module.MetadataKind != MetadataKind.Ecma335;
		}
		public static TypeReference GetEnumUnderlyingType(this TypeDefinition self)
		{
			Collection<FieldDefinition> fields = self.Fields;
			for (int i = 0; i < fields.Count; i++)
			{
				FieldDefinition fieldDefinition = fields[i];
				if (!fieldDefinition.IsStatic)
				{
					return fieldDefinition.FieldType;
				}
			}
			throw new ArgumentException();
		}
		public static TypeDefinition GetNestedType(this TypeDefinition self, string fullname)
		{
			if (!self.HasNestedTypes)
			{
				return null;
			}
			Collection<TypeDefinition> nestedTypes = self.NestedTypes;
			for (int i = 0; i < nestedTypes.Count; i++)
			{
				TypeDefinition typeDefinition = nestedTypes[i];
				if (typeDefinition.TypeFullName() == fullname)
				{
					return typeDefinition;
				}
			}
			return null;
		}
		public static bool IsPrimitive(this ElementType self)
		{
			switch (self)
			{
			case ElementType.Boolean:
			case ElementType.Char:
			case ElementType.I1:
			case ElementType.U1:
			case ElementType.I2:
			case ElementType.U2:
			case ElementType.I4:
			case ElementType.U4:
			case ElementType.I8:
			case ElementType.U8:
			case ElementType.R4:
			case ElementType.R8:
			case ElementType.I:
			case ElementType.U:
				return true;
			}
			return false;
		}
		public static string TypeFullName(this TypeReference self)
		{
			if (!string.IsNullOrEmpty(self.Namespace))
			{
				return self.Namespace + '.' + self.Name;
			}
			return self.Name;
		}
		public static bool IsTypeOf(this TypeReference self, string @namespace, string name)
		{
			return self.Name == name && self.Namespace == @namespace;
		}
		public static bool IsTypeSpecification(this TypeReference type)
		{
			ElementType etype = type.etype;
			switch (etype)
			{
			case ElementType.Ptr:
			case ElementType.ByRef:
			case ElementType.Var:
			case ElementType.Array:
			case ElementType.GenericInst:
			case ElementType.FnPtr:
			case ElementType.SzArray:
			case ElementType.MVar:
			case ElementType.CModReqD:
			case ElementType.CModOpt:
				break;
			case ElementType.ValueType:
			case ElementType.Class:
			case ElementType.TypedByRef:
			case (ElementType)23:
			case ElementType.I:
			case ElementType.U:
			case (ElementType)26:
			case ElementType.Object:
				return false;
			default:
				if (etype != ElementType.Sentinel && etype != ElementType.Pinned)
				{
					return false;
				}
				break;
			}
			return true;
		}
		public static TypeDefinition CheckedResolve(this TypeReference self)
		{
			TypeDefinition typeDefinition = self.Resolve();
			if (typeDefinition == null)
			{
				throw new ResolutionException(self);
			}
			return typeDefinition;
		}
		public static void CheckType(TypeReference type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
		}
		public static RSA CreateRSA(this StrongNameKeyPair key_pair)
		{
			byte[] blob;
			string keyContainerName;
			if (!Mixin.TryGetKeyContainer(key_pair, out blob, out keyContainerName))
			{
				return CryptoConvert.FromCapiKeyBlob(blob);
			}
			CspParameters parameters = new CspParameters
			{
				Flags = CspProviderFlags.UseMachineKeyStore,
				KeyContainerName = keyContainerName,
				KeyNumber = 2
			};
			return new RSACryptoServiceProvider(parameters);
		}
		private static bool TryGetKeyContainer(ISerializable key_pair, out byte[] key, out string key_container)
		{
			SerializationInfo serializationInfo = new SerializationInfo(typeof(StrongNameKeyPair), new FormatterConverter());
			key_pair.GetObjectData(serializationInfo, default(StreamingContext));
			key = (byte[])serializationInfo.GetValue("_keyPairArray", typeof(byte[]));
			key_container = serializationInfo.GetString("_keyPairContainer");
			return key_container != null;
		}
		public static bool IsNullOrEmpty<T>(this T[] self)
		{
			return self == null || self.Length == 0;
		}
		public static bool IsNullOrEmpty<T>(this Collection<T> self)
		{
			return self == null || self.size == 0;
		}
		public static T[] Resize<T>(this T[] self, int length)
		{
			Array.Resize<T>(ref self, length);
			return self;
		}
	}
}
