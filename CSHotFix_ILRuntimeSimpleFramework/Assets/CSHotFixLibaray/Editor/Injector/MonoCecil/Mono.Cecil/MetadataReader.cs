using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Cecil.PE;
using Editor_Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace Editor_Mono.Cecil
{
	internal sealed class MetadataReader : ByteBuffer
	{
		internal readonly Image image;
		internal readonly ModuleDefinition module;
		internal readonly MetadataSystem metadata;
		internal IGenericContext context;
		internal CodeReader code;
		private uint Position
		{
			get
			{
				return (uint)this.position;
			}
			set
			{
				this.position = (int)value;
			}
		}
		public MetadataReader(ModuleDefinition module) : base(module.Image.MetadataSection.Data)
		{
			this.image = module.Image;
			this.module = module;
			this.metadata = module.MetadataSystem;
			this.code = new CodeReader(this.image.MetadataSection, this);
		}
		private int GetCodedIndexSize(CodedIndex index)
		{
			return this.image.GetCodedIndexSize(index);
		}
		private uint ReadByIndexSize(int size)
		{
			if (size == 4)
			{
				return base.ReadUInt32();
			}
			return (uint)base.ReadUInt16();
		}
		private byte[] ReadBlob()
		{
			BlobHeap blobHeap = this.image.BlobHeap;
			if (blobHeap == null)
			{
				this.position += 2;
				return Empty<byte>.Array;
			}
			return blobHeap.Read(this.ReadBlobIndex());
		}
		private byte[] ReadBlob(uint signature)
		{
			BlobHeap blobHeap = this.image.BlobHeap;
			if (blobHeap == null)
			{
				return Empty<byte>.Array;
			}
			return blobHeap.Read(signature);
		}
		private uint ReadBlobIndex()
		{
			BlobHeap blobHeap = this.image.BlobHeap;
			return this.ReadByIndexSize((blobHeap != null) ? blobHeap.IndexSize : 2);
		}
		private string ReadString()
		{
			return this.image.StringHeap.Read(this.ReadByIndexSize(this.image.StringHeap.IndexSize));
		}
		private uint ReadStringIndex()
		{
			return this.ReadByIndexSize(this.image.StringHeap.IndexSize);
		}
		private uint ReadTableIndex(Table table)
		{
			return this.ReadByIndexSize(this.image.GetTableIndexSize(table));
		}
		private MetadataToken ReadMetadataToken(CodedIndex index)
		{
			return index.GetMetadataToken(this.ReadByIndexSize(this.GetCodedIndexSize(index)));
		}
		private int MoveTo(Table table)
		{
			TableInformation tableInformation = this.image.TableHeap[table];
			if (tableInformation.Length != 0u)
			{
				this.Position = tableInformation.Offset;
			}
			return (int)tableInformation.Length;
		}
		private bool MoveTo(Table table, uint row)
		{
			TableInformation tableInformation = this.image.TableHeap[table];
			uint length = tableInformation.Length;
			if (length == 0u || row > length)
			{
				return false;
			}
			this.Position = tableInformation.Offset + tableInformation.RowSize * (row - 1u);
			return true;
		}
		public AssemblyNameDefinition ReadAssemblyNameDefinition()
		{
			if (this.MoveTo(Table.Assembly) == 0)
			{
				return null;
			}
			AssemblyNameDefinition assemblyNameDefinition = new AssemblyNameDefinition();
			assemblyNameDefinition.HashAlgorithm = (AssemblyHashAlgorithm)base.ReadUInt32();
			this.PopulateVersionAndFlags(assemblyNameDefinition);
			assemblyNameDefinition.PublicKey = this.ReadBlob();
			this.PopulateNameAndCulture(assemblyNameDefinition);
			return assemblyNameDefinition;
		}
		public ModuleDefinition Populate(ModuleDefinition module)
		{
			if (this.MoveTo(Table.Module) == 0)
			{
				return module;
			}
			base.Advance(2);
			module.Name = this.ReadString();
			module.Mvid = this.image.GuidHeap.Read(this.ReadByIndexSize(this.image.GuidHeap.IndexSize));
			return module;
		}
		private void InitializeAssemblyReferences()
		{
			if (this.metadata.AssemblyReferences != null)
			{
				return;
			}
			int num = this.MoveTo(Table.AssemblyRef);
			AssemblyNameReference[] array = this.metadata.AssemblyReferences = new AssemblyNameReference[num];
			uint num2 = 0u;
			while ((ulong)num2 < (ulong)((long)num))
			{
				AssemblyNameReference assemblyNameReference = new AssemblyNameReference();
				assemblyNameReference.token = new MetadataToken(TokenType.AssemblyRef, num2 + 1u);
				this.PopulateVersionAndFlags(assemblyNameReference);
				byte[] array2 = this.ReadBlob();
				if (assemblyNameReference.HasPublicKey)
				{
					assemblyNameReference.PublicKey = array2;
				}
				else
				{
					assemblyNameReference.PublicKeyToken = array2;
				}
				this.PopulateNameAndCulture(assemblyNameReference);
				assemblyNameReference.Hash = this.ReadBlob();
				array[(int)((UIntPtr)num2)] = assemblyNameReference;
				num2 += 1u;
			}
		}
		public Collection<AssemblyNameReference> ReadAssemblyReferences()
		{
			this.InitializeAssemblyReferences();
			Collection<AssemblyNameReference> collection = new Collection<AssemblyNameReference>(this.metadata.AssemblyReferences);
			if (this.module.IsWindowsMetadata())
			{
				this.module.Projections.AddVirtualReferences(collection);
			}
			return collection;
		}
		public MethodDefinition ReadEntryPoint()
		{
			if (this.module.Image.EntryPointToken == 0u)
			{
				return null;
			}
			MetadataToken metadataToken = new MetadataToken(this.module.Image.EntryPointToken);
			return this.GetMethodDefinition(metadataToken.RID);
		}
		public Collection<ModuleDefinition> ReadModules()
		{
			Collection<ModuleDefinition> collection = new Collection<ModuleDefinition>(1);
			collection.Add(this.module);
			int num = this.MoveTo(Table.File);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				FileAttributes fileAttributes = (FileAttributes)base.ReadUInt32();
				string name = this.ReadString();
				this.ReadBlobIndex();
				if (fileAttributes == FileAttributes.ContainsMetaData)
				{
					ReaderParameters parameters = new ReaderParameters
					{
						ReadingMode = this.module.ReadingMode,
						SymbolReaderProvider = this.module.SymbolReaderProvider,
						AssemblyResolver = this.module.AssemblyResolver
					};
					collection.Add(ModuleDefinition.ReadModule(this.GetModuleFileName(name), parameters));
				}
				num2 += 1u;
			}
			return collection;
		}
		private string GetModuleFileName(string name)
		{
			if (this.module.FullyQualifiedName == null)
			{
				throw new NotSupportedException();
			}
			string directoryName = Path.GetDirectoryName(this.module.FullyQualifiedName);
			return Path.Combine(directoryName, name);
		}
		private void InitializeModuleReferences()
		{
			if (this.metadata.ModuleReferences != null)
			{
				return;
			}
			int num = this.MoveTo(Table.ModuleRef);
			ModuleReference[] array = this.metadata.ModuleReferences = new ModuleReference[num];
			uint num2 = 0u;
			while ((ulong)num2 < (ulong)((long)num))
			{
				ModuleReference moduleReference = new ModuleReference(this.ReadString());
				moduleReference.token = new MetadataToken(TokenType.ModuleRef, num2 + 1u);
				array[(int)((UIntPtr)num2)] = moduleReference;
				num2 += 1u;
			}
		}
		public Collection<ModuleReference> ReadModuleReferences()
		{
			this.InitializeModuleReferences();
			return new Collection<ModuleReference>(this.metadata.ModuleReferences);
		}
		public bool HasFileResource()
		{
			int num = this.MoveTo(Table.File);
			if (num == 0)
			{
				return false;
			}
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				if (this.ReadFileRecord(num2).Col1 == FileAttributes.ContainsNoMetaData)
				{
					return true;
				}
				num2 += 1u;
			}
			return false;
		}
		public Collection<Resource> ReadResources()
		{
			int num = this.MoveTo(Table.ManifestResource);
			Collection<Resource> collection = new Collection<Resource>(num);
			for (int i = 1; i <= num; i++)
			{
				uint offset = base.ReadUInt32();
				ManifestResourceAttributes manifestResourceAttributes = (ManifestResourceAttributes)base.ReadUInt32();
				string name = this.ReadString();
				MetadataToken scope = this.ReadMetadataToken(CodedIndex.Implementation);
				Resource item;
				if (scope.RID == 0u)
				{
					item = new EmbeddedResource(name, manifestResourceAttributes, offset, this);
				}
				else
				{
					if (scope.TokenType == TokenType.AssemblyRef)
					{
						item = new AssemblyLinkedResource(name, manifestResourceAttributes)
						{
							Assembly = (AssemblyNameReference)this.GetTypeReferenceScope(scope)
						};
					}
					else
					{
						if (scope.TokenType != TokenType.File)
						{
							throw new NotSupportedException();
						}
						Row<FileAttributes, string, uint> row = this.ReadFileRecord(scope.RID);
						item = new LinkedResource(name, manifestResourceAttributes)
						{
							File = row.Col2,
							hash = this.ReadBlob(row.Col3)
						};
					}
				}
				collection.Add(item);
			}
			return collection;
		}
		private Row<FileAttributes, string, uint> ReadFileRecord(uint rid)
		{
			int position = this.position;
			if (!this.MoveTo(Table.File, rid))
			{
				throw new ArgumentException();
			}
			Row<FileAttributes, string, uint> result = new Row<FileAttributes, string, uint>((FileAttributes)base.ReadUInt32(), this.ReadString(), this.ReadBlobIndex());
			this.position = position;
			return result;
		}
		public MemoryStream GetManagedResourceStream(uint offset)
		{
			uint virtualAddress = this.image.Resources.VirtualAddress;
			Section sectionAtVirtualAddress = this.image.GetSectionAtVirtualAddress(virtualAddress);
			uint num = virtualAddress - sectionAtVirtualAddress.VirtualAddress + offset;
			byte[] data = sectionAtVirtualAddress.Data;
			int count = (int)data[(int)((UIntPtr)num)] | (int)data[(int)((UIntPtr)(num + 1u))] << 8 | (int)data[(int)((UIntPtr)(num + 2u))] << 16 | (int)data[(int)((UIntPtr)(num + 3u))] << 24;
			return new MemoryStream(data, (int)(num + 4u), count);
		}
		private void PopulateVersionAndFlags(AssemblyNameReference name)
		{
			name.Version = new Version((int)base.ReadUInt16(), (int)base.ReadUInt16(), (int)base.ReadUInt16(), (int)base.ReadUInt16());
			name.Attributes = (AssemblyAttributes)base.ReadUInt32();
		}
		private void PopulateNameAndCulture(AssemblyNameReference name)
		{
			name.Name = this.ReadString();
			name.Culture = this.ReadString();
		}
		public TypeDefinitionCollection ReadTypes()
		{
			this.InitializeTypeDefinitions();
			TypeDefinition[] types = this.metadata.Types;
			int capacity = types.Length - this.metadata.NestedTypes.Count;
			TypeDefinitionCollection typeDefinitionCollection = new TypeDefinitionCollection(this.module, capacity);
			for (int i = 0; i < types.Length; i++)
			{
				TypeDefinition typeDefinition = types[i];
				if (!MetadataReader.IsNested(typeDefinition.Attributes))
				{
					typeDefinitionCollection.Add(typeDefinition);
				}
			}
			if (this.image.HasTable(Table.MethodPtr) || this.image.HasTable(Table.FieldPtr))
			{
				this.CompleteTypes();
			}
			return typeDefinitionCollection;
		}
		private void CompleteTypes()
		{
			TypeDefinition[] types = this.metadata.Types;
			for (int i = 0; i < types.Length; i++)
			{
				TypeDefinition typeDefinition = types[i];
				MetadataReader.InitializeCollection(typeDefinition.Fields);
				MetadataReader.InitializeCollection(typeDefinition.Methods);
			}
		}
		private void InitializeTypeDefinitions()
		{
			if (this.metadata.Types != null)
			{
				return;
			}
			this.InitializeNestedTypes();
			this.InitializeFields();
			this.InitializeMethods();
			int num = this.MoveTo(Table.TypeDef);
			TypeDefinition[] array = this.metadata.Types = new TypeDefinition[num];
			uint num2 = 0u;
			while ((ulong)num2 < (ulong)((long)num))
			{
				if (array[(int)((UIntPtr)num2)] == null)
				{
					array[(int)((UIntPtr)num2)] = this.ReadType(num2 + 1u);
				}
				num2 += 1u;
			}
		}
		private static bool IsNested(TypeAttributes attributes)
		{
			switch (attributes & TypeAttributes.VisibilityMask)
			{
			case TypeAttributes.NestedPublic:
			case TypeAttributes.NestedPrivate:
			case TypeAttributes.NestedFamily:
			case TypeAttributes.NestedAssembly:
			case TypeAttributes.NestedFamANDAssem:
			case TypeAttributes.VisibilityMask:
				return true;
			default:
				return false;
			}
		}
		public bool HasNestedTypes(TypeDefinition type)
		{
			this.InitializeNestedTypes();
			uint[] array;
			return this.metadata.TryGetNestedTypeMapping(type, out array) && array.Length > 0;
		}
		public Collection<TypeDefinition> ReadNestedTypes(TypeDefinition type)
		{
			this.InitializeNestedTypes();
			uint[] array;
			if (!this.metadata.TryGetNestedTypeMapping(type, out array))
			{
				return new MemberDefinitionCollection<TypeDefinition>(type);
			}
			MemberDefinitionCollection<TypeDefinition> memberDefinitionCollection = new MemberDefinitionCollection<TypeDefinition>(type, array.Length);
			for (int i = 0; i < array.Length; i++)
			{
				TypeDefinition typeDefinition = this.GetTypeDefinition(array[i]);
				if (typeDefinition != null)
				{
					memberDefinitionCollection.Add(typeDefinition);
				}
			}
			this.metadata.RemoveNestedTypeMapping(type);
			return memberDefinitionCollection;
		}
		private void InitializeNestedTypes()
		{
			if (this.metadata.NestedTypes != null)
			{
				return;
			}
			int num = this.MoveTo(Table.NestedClass);
			this.metadata.NestedTypes = new Dictionary<uint, uint[]>(num);
			this.metadata.ReverseNestedTypes = new Dictionary<uint, uint>(num);
			if (num == 0)
			{
				return;
			}
			for (int i = 1; i <= num; i++)
			{
				uint nested = this.ReadTableIndex(Table.TypeDef);
				uint declaring = this.ReadTableIndex(Table.TypeDef);
				this.AddNestedMapping(declaring, nested);
			}
		}
		private void AddNestedMapping(uint declaring, uint nested)
		{
			this.metadata.SetNestedTypeMapping(declaring, MetadataReader.AddMapping<uint, uint>(this.metadata.NestedTypes, declaring, nested));
			this.metadata.SetReverseNestedTypeMapping(nested, declaring);
		}
		private static TValue[] AddMapping<TKey, TValue>(Dictionary<TKey, TValue[]> cache, TKey key, TValue value)
		{
			TValue[] array;
			if (!cache.TryGetValue(key, out array))
			{
				array = new TValue[]
				{
					value
				};
				return array;
			}
			TValue[] array2 = new TValue[array.Length + 1];
			Array.Copy(array, array2, array.Length);
			array2[array.Length] = value;
			return array2;
		}
		private TypeDefinition ReadType(uint rid)
		{
			if (!this.MoveTo(Table.TypeDef, rid))
			{
				return null;
			}
			TypeAttributes attributes = (TypeAttributes)base.ReadUInt32();
			string name = this.ReadString();
			string @namespace = this.ReadString();
			TypeDefinition typeDefinition = new TypeDefinition(@namespace, name, attributes);
			typeDefinition.token = new MetadataToken(TokenType.TypeDef, rid);
			typeDefinition.scope = this.module;
			typeDefinition.module = this.module;
			this.metadata.AddTypeDefinition(typeDefinition);
			this.context = typeDefinition;
			typeDefinition.BaseType = this.GetTypeDefOrRef(this.ReadMetadataToken(CodedIndex.TypeDefOrRef));
			typeDefinition.fields_range = this.ReadFieldsRange(rid);
			typeDefinition.methods_range = this.ReadMethodsRange(rid);
			if (MetadataReader.IsNested(attributes))
			{
				typeDefinition.DeclaringType = this.GetNestedTypeDeclaringType(typeDefinition);
			}
			if (this.module.IsWindowsMetadata())
			{
				WindowsRuntimeProjections.Project(typeDefinition);
			}
			return typeDefinition;
		}
		private TypeDefinition GetNestedTypeDeclaringType(TypeDefinition type)
		{
			uint rid;
			if (!this.metadata.TryGetReverseNestedTypeMapping(type, out rid))
			{
				return null;
			}
			this.metadata.RemoveReverseNestedTypeMapping(type);
			return this.GetTypeDefinition(rid);
		}
		private Range ReadFieldsRange(uint type_index)
		{
			return this.ReadListRange(type_index, Table.TypeDef, Table.Field);
		}
		private Range ReadMethodsRange(uint type_index)
		{
			return this.ReadListRange(type_index, Table.TypeDef, Table.Method);
		}
		private Range ReadListRange(uint current_index, Table current, Table target)
		{
			Range result = default(Range);
			result.Start = this.ReadTableIndex(target);
			TableInformation tableInformation = this.image.TableHeap[current];
			uint num;
			if (current_index == tableInformation.Length)
			{
				num = this.image.TableHeap[target].Length + 1u;
			}
			else
			{
				uint position = this.Position;
				this.Position += (uint)((ulong)tableInformation.RowSize - (ulong)((long)this.image.GetTableIndexSize(target)));
				num = this.ReadTableIndex(target);
				this.Position = position;
			}
			result.Length = num - result.Start;
			return result;
		}
		public Row<short, int> ReadTypeLayout(TypeDefinition type)
		{
			this.InitializeTypeLayouts();
			uint rID = type.token.RID;
			Row<ushort, uint> row;
			if (!this.metadata.ClassLayouts.TryGetValue(rID, out row))
			{
				return new Row<short, int>(-1, -1);
			}
			type.PackingSize = (short)row.Col1;
			type.ClassSize = (int)row.Col2;
			this.metadata.ClassLayouts.Remove(rID);
			return new Row<short, int>((short)row.Col1, (int)row.Col2);
		}
		private void InitializeTypeLayouts()
		{
			if (this.metadata.ClassLayouts != null)
			{
				return;
			}
			int num = this.MoveTo(Table.ClassLayout);
			Dictionary<uint, Row<ushort, uint>> dictionary = this.metadata.ClassLayouts = new Dictionary<uint, Row<ushort, uint>>(num);
			uint num2 = 0u;
			while ((ulong)num2 < (ulong)((long)num))
			{
				ushort col = base.ReadUInt16();
				uint col2 = base.ReadUInt32();
				uint key = this.ReadTableIndex(Table.TypeDef);
				dictionary.Add(key, new Row<ushort, uint>(col, col2));
				num2 += 1u;
			}
		}
		public TypeReference GetTypeDefOrRef(MetadataToken token)
		{
			return (TypeReference)this.LookupToken(token);
		}
		public TypeDefinition GetTypeDefinition(uint rid)
		{
			this.InitializeTypeDefinitions();
			TypeDefinition typeDefinition = this.metadata.GetTypeDefinition(rid);
			if (typeDefinition != null)
			{
				return typeDefinition;
			}
			return this.ReadTypeDefinition(rid);
		}
		private TypeDefinition ReadTypeDefinition(uint rid)
		{
			if (!this.MoveTo(Table.TypeDef, rid))
			{
				return null;
			}
			return this.ReadType(rid);
		}
		private void InitializeTypeReferences()
		{
			if (this.metadata.TypeReferences != null)
			{
				return;
			}
			this.metadata.TypeReferences = new TypeReference[this.image.GetTableLength(Table.TypeRef)];
		}
		public TypeReference GetTypeReference(string scope, string full_name)
		{
			this.InitializeTypeReferences();
			int num = this.metadata.TypeReferences.Length;
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				TypeReference typeReference = this.GetTypeReference(num2);
				if (!(typeReference.FullName != full_name))
				{
					if (string.IsNullOrEmpty(scope))
					{
						return typeReference;
					}
					if (typeReference.Scope.Name == scope)
					{
						return typeReference;
					}
				}
				num2 += 1u;
			}
			return null;
		}
		private TypeReference GetTypeReference(uint rid)
		{
			this.InitializeTypeReferences();
			TypeReference typeReference = this.metadata.GetTypeReference(rid);
			if (typeReference != null)
			{
				return typeReference;
			}
			return this.ReadTypeReference(rid);
		}
		private TypeReference ReadTypeReference(uint rid)
		{
			if (!this.MoveTo(Table.TypeRef, rid))
			{
				return null;
			}
			TypeReference typeReference = null;
			MetadataToken metadataToken = this.ReadMetadataToken(CodedIndex.ResolutionScope);
			string name = this.ReadString();
			string @namespace = this.ReadString();
			TypeReference typeReference2 = new TypeReference(@namespace, name, this.module, null);
			typeReference2.token = new MetadataToken(TokenType.TypeRef, rid);
			this.metadata.AddTypeReference(typeReference2);
			IMetadataScope scope;
			if (metadataToken.TokenType == TokenType.TypeRef)
			{
				typeReference = this.GetTypeDefOrRef(metadataToken);
				scope = ((typeReference != null) ? typeReference.Scope : this.module);
			}
			else
			{
				scope = this.GetTypeReferenceScope(metadataToken);
			}
			typeReference2.scope = scope;
			typeReference2.DeclaringType = typeReference;
			MetadataSystem.TryProcessPrimitiveTypeReference(typeReference2);
			if (typeReference2.Module.IsWindowsMetadata())
			{
				WindowsRuntimeProjections.Project(typeReference2);
			}
			return typeReference2;
		}
		private IMetadataScope GetTypeReferenceScope(MetadataToken scope)
		{
			if (scope.TokenType == TokenType.Module)
			{
				return this.module;
			}
			TokenType tokenType = scope.TokenType;
			IMetadataScope[] array;
			if (tokenType != TokenType.ModuleRef)
			{
				if (tokenType != TokenType.AssemblyRef)
				{
					throw new NotSupportedException();
				}
				this.InitializeAssemblyReferences();
				array = this.metadata.AssemblyReferences;
			}
			else
			{
				this.InitializeModuleReferences();
				array = this.metadata.ModuleReferences;
			}
			uint num = scope.RID - 1u;
			if (num < 0u || (ulong)num >= (ulong)((long)array.Length))
			{
				return null;
			}
			return array[(int)((UIntPtr)num)];
		}
		public IEnumerable<TypeReference> GetTypeReferences()
		{
			this.InitializeTypeReferences();
			int tableLength = this.image.GetTableLength(Table.TypeRef);
			TypeReference[] array = new TypeReference[tableLength];
			uint num = 1u;
			while ((ulong)num <= (ulong)((long)tableLength))
			{
				array[(int)((UIntPtr)(num - 1u))] = this.GetTypeReference(num);
				num += 1u;
			}
			return array;
		}
		private TypeReference GetTypeSpecification(uint rid)
		{
			if (!this.MoveTo(Table.TypeSpec, rid))
			{
				return null;
			}
			SignatureReader signatureReader = this.ReadSignature(this.ReadBlobIndex());
			TypeReference typeReference = signatureReader.ReadTypeSignature();
			if (typeReference.token.RID == 0u)
			{
				typeReference.token = new MetadataToken(TokenType.TypeSpec, rid);
			}
			return typeReference;
		}
		private SignatureReader ReadSignature(uint signature)
		{
			return new SignatureReader(signature, this);
		}
		public bool HasInterfaces(TypeDefinition type)
		{
			this.InitializeInterfaces();
			Row<uint, MetadataToken>[] array;
			return this.metadata.TryGetInterfaceMapping(type, out array);
		}
		public InterfaceImplementationCollection ReadInterfaces(TypeDefinition type)
		{
			this.InitializeInterfaces();
			Row<uint, MetadataToken>[] array;
			if (!this.metadata.TryGetInterfaceMapping(type, out array))
			{
				return new InterfaceImplementationCollection(type);
			}
			InterfaceImplementationCollection interfaceImplementationCollection = new InterfaceImplementationCollection(type, array.Length);
			this.context = type;
			for (int i = 0; i < array.Length; i++)
			{
				interfaceImplementationCollection.Add(new InterfaceImplementation(this.GetTypeDefOrRef(array[i].Col2), new MetadataToken(TokenType.InterfaceImpl, array[i].Col1)));
			}
			this.metadata.RemoveInterfaceMapping(type);
			return interfaceImplementationCollection;
		}
		private void InitializeInterfaces()
		{
			if (this.metadata.Interfaces != null)
			{
				return;
			}
			int num = this.MoveTo(Table.InterfaceImpl);
			this.metadata.Interfaces = new Dictionary<uint, Row<uint, MetadataToken>[]>(num);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				uint type = this.ReadTableIndex(Table.TypeDef);
				MetadataToken col = this.ReadMetadataToken(CodedIndex.TypeDefOrRef);
				this.AddInterfaceMapping(type, new Row<uint, MetadataToken>(num2, col));
				num2 += 1u;
			}
		}
		private void AddInterfaceMapping(uint type, Row<uint, MetadataToken> @interface)
		{
			this.metadata.SetInterfaceMapping(type, MetadataReader.AddMapping<uint, Row<uint, MetadataToken>>(this.metadata.Interfaces, type, @interface));
		}
		public Collection<FieldDefinition> ReadFields(TypeDefinition type)
		{
			Range fields_range = type.fields_range;
			if (fields_range.Length == 0u)
			{
				return new MemberDefinitionCollection<FieldDefinition>(type);
			}
			MemberDefinitionCollection<FieldDefinition> memberDefinitionCollection = new MemberDefinitionCollection<FieldDefinition>(type, (int)fields_range.Length);
			this.context = type;
			if (!this.MoveTo(Table.FieldPtr, fields_range.Start))
			{
				if (!this.MoveTo(Table.Field, fields_range.Start))
				{
					return memberDefinitionCollection;
				}
				for (uint num = 0u; num < fields_range.Length; num += 1u)
				{
					this.ReadField(fields_range.Start + num, memberDefinitionCollection);
				}
			}
			else
			{
				this.ReadPointers<FieldDefinition>(Table.FieldPtr, Table.Field, fields_range, memberDefinitionCollection, new Action<uint, Collection<FieldDefinition>>(this.ReadField));
			}
			return memberDefinitionCollection;
		}
		private void ReadField(uint field_rid, Collection<FieldDefinition> fields)
		{
			FieldAttributes attributes = (FieldAttributes)base.ReadUInt16();
			string name = this.ReadString();
			uint signature = this.ReadBlobIndex();
			FieldDefinition fieldDefinition = new FieldDefinition(name, attributes, this.ReadFieldType(signature));
			fieldDefinition.token = new MetadataToken(TokenType.Field, field_rid);
			this.metadata.AddFieldDefinition(fieldDefinition);
			if (MetadataReader.IsDeleted(fieldDefinition))
			{
				return;
			}
			fields.Add(fieldDefinition);
			if (this.module.IsWindowsMetadata())
			{
				WindowsRuntimeProjections.Project(fieldDefinition);
			}
		}
		private void InitializeFields()
		{
			if (this.metadata.Fields != null)
			{
				return;
			}
			this.metadata.Fields = new FieldDefinition[this.image.GetTableLength(Table.Field)];
		}
		private TypeReference ReadFieldType(uint signature)
		{
			SignatureReader signatureReader = this.ReadSignature(signature);
			if (signatureReader.ReadByte() != 6)
			{
				throw new NotSupportedException();
			}
			return signatureReader.ReadTypeSignature();
		}
		public int ReadFieldRVA(FieldDefinition field)
		{
			this.InitializeFieldRVAs();
			uint rID = field.token.RID;
			uint num;
			if (!this.metadata.FieldRVAs.TryGetValue(rID, out num))
			{
				return 0;
			}
			int fieldTypeSize = MetadataReader.GetFieldTypeSize(field.FieldType);
			if (fieldTypeSize == 0 || num == 0u)
			{
				return 0;
			}
			this.metadata.FieldRVAs.Remove(rID);
			field.InitialValue = this.GetFieldInitializeValue(fieldTypeSize, num);
			return (int)num;
		}
		private byte[] GetFieldInitializeValue(int size, uint rva)
		{
			Section sectionAtVirtualAddress = this.image.GetSectionAtVirtualAddress(rva);
			if (sectionAtVirtualAddress == null)
			{
				return Empty<byte>.Array;
			}
			byte[] array = new byte[size];
			Buffer.BlockCopy(sectionAtVirtualAddress.Data, (int)(rva - sectionAtVirtualAddress.VirtualAddress), array, 0, size);
			return array;
		}
		private static int GetFieldTypeSize(TypeReference type)
		{
			int result = 0;
			switch (type.etype)
			{
			case ElementType.Boolean:
			case ElementType.I1:
			case ElementType.U1:
				result = 1;
				return result;
			case ElementType.Char:
			case ElementType.I2:
			case ElementType.U2:
				result = 2;
				return result;
			case ElementType.I4:
			case ElementType.U4:
			case ElementType.R4:
				result = 4;
				return result;
			case ElementType.I8:
			case ElementType.U8:
			case ElementType.R8:
				result = 8;
				return result;
			case ElementType.Ptr:
			case ElementType.FnPtr:
				result = IntPtr.Size;
				return result;
			case ElementType.CModReqD:
			case ElementType.CModOpt:
				return MetadataReader.GetFieldTypeSize(((IModifierType)type).ElementType);
			}
			TypeDefinition typeDefinition = type.Resolve();
			if (typeDefinition != null && typeDefinition.HasLayoutInfo)
			{
				result = typeDefinition.ClassSize;
			}
			return result;
		}
		private void InitializeFieldRVAs()
		{
			if (this.metadata.FieldRVAs != null)
			{
				return;
			}
			int num = this.MoveTo(Table.FieldRVA);
			Dictionary<uint, uint> dictionary = this.metadata.FieldRVAs = new Dictionary<uint, uint>(num);
			for (int i = 0; i < num; i++)
			{
				uint value = base.ReadUInt32();
				uint key = this.ReadTableIndex(Table.Field);
				dictionary.Add(key, value);
			}
		}
		public int ReadFieldLayout(FieldDefinition field)
		{
			this.InitializeFieldLayouts();
			uint rID = field.token.RID;
			uint result;
			if (!this.metadata.FieldLayouts.TryGetValue(rID, out result))
			{
				return -1;
			}
			this.metadata.FieldLayouts.Remove(rID);
			return (int)result;
		}
		private void InitializeFieldLayouts()
		{
			if (this.metadata.FieldLayouts != null)
			{
				return;
			}
			int num = this.MoveTo(Table.FieldLayout);
			Dictionary<uint, uint> dictionary = this.metadata.FieldLayouts = new Dictionary<uint, uint>(num);
			for (int i = 0; i < num; i++)
			{
				uint value = base.ReadUInt32();
				uint key = this.ReadTableIndex(Table.Field);
				dictionary.Add(key, value);
			}
		}
		public bool HasEvents(TypeDefinition type)
		{
			this.InitializeEvents();
			Range range;
			return this.metadata.TryGetEventsRange(type, out range) && range.Length > 0u;
		}
		public Collection<EventDefinition> ReadEvents(TypeDefinition type)
		{
			this.InitializeEvents();
			Range range;
			if (!this.metadata.TryGetEventsRange(type, out range))
			{
				return new MemberDefinitionCollection<EventDefinition>(type);
			}
			MemberDefinitionCollection<EventDefinition> memberDefinitionCollection = new MemberDefinitionCollection<EventDefinition>(type, (int)range.Length);
			this.metadata.RemoveEventsRange(type);
			if (range.Length == 0u)
			{
				return memberDefinitionCollection;
			}
			this.context = type;
			if (!this.MoveTo(Table.EventPtr, range.Start))
			{
				if (!this.MoveTo(Table.Event, range.Start))
				{
					return memberDefinitionCollection;
				}
				for (uint num = 0u; num < range.Length; num += 1u)
				{
					this.ReadEvent(range.Start + num, memberDefinitionCollection);
				}
			}
			else
			{
				this.ReadPointers<EventDefinition>(Table.EventPtr, Table.Event, range, memberDefinitionCollection, new Action<uint, Collection<EventDefinition>>(this.ReadEvent));
			}
			return memberDefinitionCollection;
		}
		private void ReadEvent(uint event_rid, Collection<EventDefinition> events)
		{
			EventAttributes attributes = (EventAttributes)base.ReadUInt16();
			string name = this.ReadString();
			TypeReference typeDefOrRef = this.GetTypeDefOrRef(this.ReadMetadataToken(CodedIndex.TypeDefOrRef));
			EventDefinition eventDefinition = new EventDefinition(name, attributes, typeDefOrRef);
			eventDefinition.token = new MetadataToken(TokenType.Event, event_rid);
			if (MetadataReader.IsDeleted(eventDefinition))
			{
				return;
			}
			events.Add(eventDefinition);
		}
		private void InitializeEvents()
		{
			if (this.metadata.Events != null)
			{
				return;
			}
			int num = this.MoveTo(Table.EventMap);
			this.metadata.Events = new Dictionary<uint, Range>(num);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				uint type_rid = this.ReadTableIndex(Table.TypeDef);
				Range range = this.ReadEventsRange(num2);
				this.metadata.AddEventsRange(type_rid, range);
				num2 += 1u;
			}
		}
		private Range ReadEventsRange(uint rid)
		{
			return this.ReadListRange(rid, Table.EventMap, Table.Event);
		}
		public bool HasProperties(TypeDefinition type)
		{
			this.InitializeProperties();
			Range range;
			return this.metadata.TryGetPropertiesRange(type, out range) && range.Length > 0u;
		}
		public Collection<PropertyDefinition> ReadProperties(TypeDefinition type)
		{
			this.InitializeProperties();
			Range range;
			if (!this.metadata.TryGetPropertiesRange(type, out range))
			{
				return new MemberDefinitionCollection<PropertyDefinition>(type);
			}
			this.metadata.RemovePropertiesRange(type);
			MemberDefinitionCollection<PropertyDefinition> memberDefinitionCollection = new MemberDefinitionCollection<PropertyDefinition>(type, (int)range.Length);
			if (range.Length == 0u)
			{
				return memberDefinitionCollection;
			}
			this.context = type;
			if (!this.MoveTo(Table.PropertyPtr, range.Start))
			{
				if (!this.MoveTo(Table.Property, range.Start))
				{
					return memberDefinitionCollection;
				}
				for (uint num = 0u; num < range.Length; num += 1u)
				{
					this.ReadProperty(range.Start + num, memberDefinitionCollection);
				}
			}
			else
			{
				this.ReadPointers<PropertyDefinition>(Table.PropertyPtr, Table.Property, range, memberDefinitionCollection, new Action<uint, Collection<PropertyDefinition>>(this.ReadProperty));
			}
			return memberDefinitionCollection;
		}
		private void ReadProperty(uint property_rid, Collection<PropertyDefinition> properties)
		{
			PropertyAttributes attributes = (PropertyAttributes)base.ReadUInt16();
			string name = this.ReadString();
			uint signature = this.ReadBlobIndex();
			SignatureReader signatureReader = this.ReadSignature(signature);
			byte b = signatureReader.ReadByte();
			if ((b & 8) == 0)
			{
				throw new NotSupportedException();
			}
			bool hasThis = (b & 32) != 0;
			signatureReader.ReadCompressedUInt32();
			PropertyDefinition propertyDefinition = new PropertyDefinition(name, attributes, signatureReader.ReadTypeSignature());
			propertyDefinition.HasThis = hasThis;
			propertyDefinition.token = new MetadataToken(TokenType.Property, property_rid);
			if (MetadataReader.IsDeleted(propertyDefinition))
			{
				return;
			}
			properties.Add(propertyDefinition);
		}
		private void InitializeProperties()
		{
			if (this.metadata.Properties != null)
			{
				return;
			}
			int num = this.MoveTo(Table.PropertyMap);
			this.metadata.Properties = new Dictionary<uint, Range>(num);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				uint type_rid = this.ReadTableIndex(Table.TypeDef);
				Range range = this.ReadPropertiesRange(num2);
				this.metadata.AddPropertiesRange(type_rid, range);
				num2 += 1u;
			}
		}
		private Range ReadPropertiesRange(uint rid)
		{
			return this.ReadListRange(rid, Table.PropertyMap, Table.Property);
		}
		private MethodSemanticsAttributes ReadMethodSemantics(MethodDefinition method)
		{
			this.InitializeMethodSemantics();
			Row<MethodSemanticsAttributes, MetadataToken> row;
			if (!this.metadata.Semantics.TryGetValue(method.token.RID, out row))
			{
				return MethodSemanticsAttributes.None;
			}
			TypeDefinition declaringType = method.DeclaringType;
			MethodSemanticsAttributes col = row.Col1;
			if (col <= MethodSemanticsAttributes.AddOn)
			{
				switch (col)
				{
				case MethodSemanticsAttributes.Setter:
					MetadataReader.GetProperty(declaringType, row.Col2).set_method = method;
					goto IL_174;
				case MethodSemanticsAttributes.Getter:
					MetadataReader.GetProperty(declaringType, row.Col2).get_method = method;
					goto IL_174;
				case MethodSemanticsAttributes.Setter | MethodSemanticsAttributes.Getter:
					break;
				case MethodSemanticsAttributes.Other:
				{
					TokenType tokenType = row.Col2.TokenType;
					if (tokenType == TokenType.Event)
					{
						EventDefinition @event = MetadataReader.GetEvent(declaringType, row.Col2);
						if (@event.other_methods == null)
						{
							@event.other_methods = new Collection<MethodDefinition>();
						}
						@event.other_methods.Add(method);
						goto IL_174;
					}
					if (tokenType != TokenType.Property)
					{
						throw new NotSupportedException();
					}
					PropertyDefinition property = MetadataReader.GetProperty(declaringType, row.Col2);
					if (property.other_methods == null)
					{
						property.other_methods = new Collection<MethodDefinition>();
					}
					property.other_methods.Add(method);
					goto IL_174;
				}
				default:
					if (col == MethodSemanticsAttributes.AddOn)
					{
						MetadataReader.GetEvent(declaringType, row.Col2).add_method = method;
						goto IL_174;
					}
					break;
				}
			}
			else
			{
				if (col == MethodSemanticsAttributes.RemoveOn)
				{
					MetadataReader.GetEvent(declaringType, row.Col2).remove_method = method;
					goto IL_174;
				}
				if (col == MethodSemanticsAttributes.Fire)
				{
					MetadataReader.GetEvent(declaringType, row.Col2).invoke_method = method;
					goto IL_174;
				}
			}
			throw new NotSupportedException();
			IL_174:
			this.metadata.Semantics.Remove(method.token.RID);
			return row.Col1;
		}
		private static EventDefinition GetEvent(TypeDefinition type, MetadataToken token)
		{
			if (token.TokenType != TokenType.Event)
			{
				throw new ArgumentException();
			}
			return MetadataReader.GetMember<EventDefinition>(type.Events, token);
		}
		private static PropertyDefinition GetProperty(TypeDefinition type, MetadataToken token)
		{
			if (token.TokenType != TokenType.Property)
			{
				throw new ArgumentException();
			}
			return MetadataReader.GetMember<PropertyDefinition>(type.Properties, token);
		}
		private static TMember GetMember<TMember>(Collection<TMember> members, MetadataToken token) where TMember : IMemberDefinition
		{
			for (int i = 0; i < members.Count; i++)
			{
				TMember result = members[i];
				if (result.MetadataToken == token)
				{
					return result;
				}
			}
			throw new ArgumentException();
		}
		private void InitializeMethodSemantics()
		{
			if (this.metadata.Semantics != null)
			{
				return;
			}
			int num = this.MoveTo(Table.MethodSemantics);
			Dictionary<uint, Row<MethodSemanticsAttributes, MetadataToken>> dictionary = this.metadata.Semantics = new Dictionary<uint, Row<MethodSemanticsAttributes, MetadataToken>>(0);
			uint num2 = 0u;
			while ((ulong)num2 < (ulong)((long)num))
			{
				MethodSemanticsAttributes col = (MethodSemanticsAttributes)base.ReadUInt16();
				uint key = this.ReadTableIndex(Table.Method);
				MetadataToken col2 = this.ReadMetadataToken(CodedIndex.HasSemantics);
				dictionary[key] = new Row<MethodSemanticsAttributes, MetadataToken>(col, col2);
				num2 += 1u;
			}
		}
		public PropertyDefinition ReadMethods(PropertyDefinition property)
		{
			this.ReadAllSemantics(property.DeclaringType);
			return property;
		}
		public EventDefinition ReadMethods(EventDefinition @event)
		{
			this.ReadAllSemantics(@event.DeclaringType);
			return @event;
		}
		public MethodSemanticsAttributes ReadAllSemantics(MethodDefinition method)
		{
			this.ReadAllSemantics(method.DeclaringType);
			return method.SemanticsAttributes;
		}
		private void ReadAllSemantics(TypeDefinition type)
		{
			Collection<MethodDefinition> methods = type.Methods;
			for (int i = 0; i < methods.Count; i++)
			{
				MethodDefinition methodDefinition = methods[i];
				if (!methodDefinition.sem_attrs_ready)
				{
					methodDefinition.sem_attrs = this.ReadMethodSemantics(methodDefinition);
					methodDefinition.sem_attrs_ready = true;
				}
			}
		}
		private Range ReadParametersRange(uint method_rid)
		{
			return this.ReadListRange(method_rid, Table.Method, Table.Param);
		}
		public Collection<MethodDefinition> ReadMethods(TypeDefinition type)
		{
			Range methods_range = type.methods_range;
			if (methods_range.Length == 0u)
			{
				return new MemberDefinitionCollection<MethodDefinition>(type);
			}
			MemberDefinitionCollection<MethodDefinition> memberDefinitionCollection = new MemberDefinitionCollection<MethodDefinition>(type, (int)methods_range.Length);
			if (!this.MoveTo(Table.MethodPtr, methods_range.Start))
			{
				if (!this.MoveTo(Table.Method, methods_range.Start))
				{
					return memberDefinitionCollection;
				}
				for (uint num = 0u; num < methods_range.Length; num += 1u)
				{
					this.ReadMethod(methods_range.Start + num, memberDefinitionCollection);
				}
			}
			else
			{
				this.ReadPointers<MethodDefinition>(Table.MethodPtr, Table.Method, methods_range, memberDefinitionCollection, new Action<uint, Collection<MethodDefinition>>(this.ReadMethod));
			}
			return memberDefinitionCollection;
		}
		private void ReadPointers<TMember>(Table ptr, Table table, Range range, Collection<TMember> members, Action<uint, Collection<TMember>> reader) where TMember : IMemberDefinition
		{
			for (uint num = 0u; num < range.Length; num += 1u)
			{
				this.MoveTo(ptr, range.Start + num);
				uint num2 = this.ReadTableIndex(table);
				this.MoveTo(table, num2);
				reader(num2, members);
			}
		}
		private static bool IsDeleted(IMemberDefinition member)
		{
			return member.IsSpecialName && member.Name == "_Deleted";
		}
		private void InitializeMethods()
		{
			if (this.metadata.Methods != null)
			{
				return;
			}
			this.metadata.Methods = new MethodDefinition[this.image.GetTableLength(Table.Method)];
		}
		private void ReadMethod(uint method_rid, Collection<MethodDefinition> methods)
		{
			MethodDefinition methodDefinition = new MethodDefinition();
			methodDefinition.rva = base.ReadUInt32();
			methodDefinition.ImplAttributes = (MethodImplAttributes)base.ReadUInt16();
			methodDefinition.Attributes = (MethodAttributes)base.ReadUInt16();
			methodDefinition.Name = this.ReadString();
			methodDefinition.token = new MetadataToken(TokenType.Method, method_rid);
			if (MetadataReader.IsDeleted(methodDefinition))
			{
				return;
			}
			methods.Add(methodDefinition);
			uint signature = this.ReadBlobIndex();
			Range param_range = this.ReadParametersRange(method_rid);
			this.context = methodDefinition;
			this.ReadMethodSignature(signature, methodDefinition);
			this.metadata.AddMethodDefinition(methodDefinition);
			if (param_range.Length != 0u)
			{
				int position = this.position;
				this.ReadParameters(methodDefinition, param_range);
				this.position = position;
			}
			if (this.module.IsWindowsMetadata())
			{
				WindowsRuntimeProjections.Project(methodDefinition);
			}
		}
		private void ReadParameters(MethodDefinition method, Range param_range)
		{
			if (this.MoveTo(Table.ParamPtr, param_range.Start))
			{
				this.ReadParameterPointers(method, param_range);
				return;
			}
			if (!this.MoveTo(Table.Param, param_range.Start))
			{
				return;
			}
			for (uint num = 0u; num < param_range.Length; num += 1u)
			{
				this.ReadParameter(param_range.Start + num, method);
			}
		}
		private void ReadParameterPointers(MethodDefinition method, Range range)
		{
			for (uint num = 0u; num < range.Length; num += 1u)
			{
				this.MoveTo(Table.ParamPtr, range.Start + num);
				uint num2 = this.ReadTableIndex(Table.Param);
				this.MoveTo(Table.Param, num2);
				this.ReadParameter(num2, method);
			}
		}
		private void ReadParameter(uint param_rid, MethodDefinition method)
		{
			ParameterAttributes attributes = (ParameterAttributes)base.ReadUInt16();
			ushort num = base.ReadUInt16();
			string name = this.ReadString();
			ParameterDefinition parameterDefinition = (num == 0) ? method.MethodReturnType.Parameter : method.Parameters[(int)(num - 1)];
			parameterDefinition.token = new MetadataToken(TokenType.Param, param_rid);
			parameterDefinition.Name = name;
			parameterDefinition.Attributes = attributes;
		}
		private void ReadMethodSignature(uint signature, IMethodSignature method)
		{
			SignatureReader signatureReader = this.ReadSignature(signature);
			signatureReader.ReadMethodSignature(method);
		}
		public PInvokeInfo ReadPInvokeInfo(MethodDefinition method)
		{
			this.InitializePInvokes();
			uint rID = method.token.RID;
			Row<PInvokeAttributes, uint, uint> row;
			if (!this.metadata.PInvokes.TryGetValue(rID, out row))
			{
				return null;
			}
			this.metadata.PInvokes.Remove(rID);
			return new PInvokeInfo(row.Col1, this.image.StringHeap.Read(row.Col2), this.module.ModuleReferences[(int)(row.Col3 - 1u)]);
		}
		private void InitializePInvokes()
		{
			if (this.metadata.PInvokes != null)
			{
				return;
			}
			int num = this.MoveTo(Table.ImplMap);
			Dictionary<uint, Row<PInvokeAttributes, uint, uint>> dictionary = this.metadata.PInvokes = new Dictionary<uint, Row<PInvokeAttributes, uint, uint>>(num);
			for (int i = 1; i <= num; i++)
			{
				PInvokeAttributes col = (PInvokeAttributes)base.ReadUInt16();
				MetadataToken metadataToken = this.ReadMetadataToken(CodedIndex.MemberForwarded);
				uint col2 = this.ReadStringIndex();
				uint col3 = this.ReadTableIndex(Table.File);
				if (metadataToken.TokenType == TokenType.Method)
				{
					dictionary.Add(metadataToken.RID, new Row<PInvokeAttributes, uint, uint>(col, col2, col3));
				}
			}
		}
		public bool HasGenericParameters(IGenericParameterProvider provider)
		{
			this.InitializeGenericParameters();
			Range[] ranges;
			return this.metadata.TryGetGenericParameterRanges(provider, out ranges) && MetadataReader.RangesSize(ranges) > 0;
		}
		public Collection<GenericParameter> ReadGenericParameters(IGenericParameterProvider provider)
		{
			this.InitializeGenericParameters();
			Range[] array;
			if (!this.metadata.TryGetGenericParameterRanges(provider, out array))
			{
				return new GenericParameterCollection(provider);
			}
			this.metadata.RemoveGenericParameterRange(provider);
			GenericParameterCollection genericParameterCollection = new GenericParameterCollection(provider, MetadataReader.RangesSize(array));
			for (int i = 0; i < array.Length; i++)
			{
				this.ReadGenericParametersRange(array[i], provider, genericParameterCollection);
			}
			return genericParameterCollection;
		}
		private void ReadGenericParametersRange(Range range, IGenericParameterProvider provider, GenericParameterCollection generic_parameters)
		{
			if (!this.MoveTo(Table.GenericParam, range.Start))
			{
				return;
			}
			for (uint num = 0u; num < range.Length; num += 1u)
			{
				base.ReadUInt16();
				GenericParameterAttributes attributes = (GenericParameterAttributes)base.ReadUInt16();
				this.ReadMetadataToken(CodedIndex.TypeOrMethodDef);
				string name = this.ReadString();
				generic_parameters.Add(new GenericParameter(name, provider)
				{
					token = new MetadataToken(TokenType.GenericParam, range.Start + num),
					Attributes = attributes
				});
			}
		}
		private void InitializeGenericParameters()
		{
			if (this.metadata.GenericParameters != null)
			{
				return;
			}
			this.metadata.GenericParameters = this.InitializeRanges(Table.GenericParam, delegate
			{
				base.Advance(4);
				MetadataToken result = this.ReadMetadataToken(CodedIndex.TypeOrMethodDef);
				this.ReadStringIndex();
				return result;
			});
		}
		private Dictionary<MetadataToken, Range[]> InitializeRanges(Table table, Func<MetadataToken> get_next)
		{
			int num = this.MoveTo(table);
			Dictionary<MetadataToken, Range[]> dictionary = new Dictionary<MetadataToken, Range[]>(num);
			if (num == 0)
			{
				return dictionary;
			}
			MetadataToken metadataToken = MetadataToken.Zero;
			Range range = new Range(1u, 0u);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				MetadataToken metadataToken2 = get_next();
				if (num2 == 1u)
				{
					metadataToken = metadataToken2;
					range.Length += 1u;
				}
				else
				{
					if (metadataToken2 != metadataToken)
					{
						MetadataReader.AddRange(dictionary, metadataToken, range);
						range = new Range(num2, 1u);
						metadataToken = metadataToken2;
					}
					else
					{
						range.Length += 1u;
					}
				}
				num2 += 1u;
			}
			MetadataReader.AddRange(dictionary, metadataToken, range);
			return dictionary;
		}
		private static void AddRange(Dictionary<MetadataToken, Range[]> ranges, MetadataToken owner, Range range)
		{
			if (owner.RID == 0u)
			{
				return;
			}
			Range[] array;
			if (!ranges.TryGetValue(owner, out array))
			{
				ranges.Add(owner, new Range[]
				{
					range
				});
				return;
			}
			array = array.Resize(array.Length + 1);
			array[array.Length - 1] = range;
			ranges[owner] = array;
		}
		public bool HasGenericConstraints(GenericParameter generic_parameter)
		{
			this.InitializeGenericConstraints();
			MetadataToken[] array;
			return this.metadata.TryGetGenericConstraintMapping(generic_parameter, out array) && array.Length > 0;
		}
		public Collection<TypeReference> ReadGenericConstraints(GenericParameter generic_parameter)
		{
			this.InitializeGenericConstraints();
			MetadataToken[] array;
			if (!this.metadata.TryGetGenericConstraintMapping(generic_parameter, out array))
			{
				return new Collection<TypeReference>();
			}
			Collection<TypeReference> collection = new Collection<TypeReference>(array.Length);
			this.context = (IGenericContext)generic_parameter.Owner;
			for (int i = 0; i < array.Length; i++)
			{
				collection.Add(this.GetTypeDefOrRef(array[i]));
			}
			this.metadata.RemoveGenericConstraintMapping(generic_parameter);
			return collection;
		}
		private void InitializeGenericConstraints()
		{
			if (this.metadata.GenericConstraints != null)
			{
				return;
			}
			int num = this.MoveTo(Table.GenericParamConstraint);
			this.metadata.GenericConstraints = new Dictionary<uint, MetadataToken[]>(num);
			for (int i = 1; i <= num; i++)
			{
				this.AddGenericConstraintMapping(this.ReadTableIndex(Table.GenericParam), this.ReadMetadataToken(CodedIndex.TypeDefOrRef));
			}
		}
		private void AddGenericConstraintMapping(uint generic_parameter, MetadataToken constraint)
		{
			this.metadata.SetGenericConstraintMapping(generic_parameter, MetadataReader.AddMapping<uint, MetadataToken>(this.metadata.GenericConstraints, generic_parameter, constraint));
		}
		public bool HasOverrides(MethodDefinition method)
		{
			this.InitializeOverrides();
			MetadataToken[] array;
			return this.metadata.TryGetOverrideMapping(method, out array) && array.Length > 0;
		}
		public Collection<MethodReference> ReadOverrides(MethodDefinition method)
		{
			this.InitializeOverrides();
			MetadataToken[] array;
			if (!this.metadata.TryGetOverrideMapping(method, out array))
			{
				return new Collection<MethodReference>();
			}
			Collection<MethodReference> collection = new Collection<MethodReference>(array.Length);
			this.context = method;
			for (int i = 0; i < array.Length; i++)
			{
				collection.Add((MethodReference)this.LookupToken(array[i]));
			}
			this.metadata.RemoveOverrideMapping(method);
			return collection;
		}
		private void InitializeOverrides()
		{
			if (this.metadata.Overrides != null)
			{
				return;
			}
			int num = this.MoveTo(Table.MethodImpl);
			this.metadata.Overrides = new Dictionary<uint, MetadataToken[]>(num);
			for (int i = 1; i <= num; i++)
			{
				this.ReadTableIndex(Table.TypeDef);
				MetadataToken metadataToken = this.ReadMetadataToken(CodedIndex.MethodDefOrRef);
				if (metadataToken.TokenType != TokenType.Method)
				{
					throw new NotSupportedException();
				}
				MetadataToken @override = this.ReadMetadataToken(CodedIndex.MethodDefOrRef);
				this.AddOverrideMapping(metadataToken.RID, @override);
			}
		}
		private void AddOverrideMapping(uint method_rid, MetadataToken @override)
		{
			this.metadata.SetOverrideMapping(method_rid, MetadataReader.AddMapping<uint, MetadataToken>(this.metadata.Overrides, method_rid, @override));
		}
		public MethodBody ReadMethodBody(MethodDefinition method)
		{
			return this.code.ReadMethodBody(method);
		}
		public CallSite ReadCallSite(MetadataToken token)
		{
			if (!this.MoveTo(Table.StandAloneSig, token.RID))
			{
				return null;
			}
			uint signature = this.ReadBlobIndex();
			CallSite callSite = new CallSite();
			this.ReadMethodSignature(signature, callSite);
			callSite.MetadataToken = token;
			return callSite;
		}
		public VariableDefinitionCollection ReadVariables(MetadataToken local_var_token)
		{
			if (!this.MoveTo(Table.StandAloneSig, local_var_token.RID))
			{
				return null;
			}
			SignatureReader signatureReader = this.ReadSignature(this.ReadBlobIndex());
			if (signatureReader.ReadByte() != 7)
			{
				throw new NotSupportedException();
			}
			uint num = signatureReader.ReadCompressedUInt32();
			if (num == 0u)
			{
				return null;
			}
			VariableDefinitionCollection variableDefinitionCollection = new VariableDefinitionCollection((int)num);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				variableDefinitionCollection.Add(new VariableDefinition(signatureReader.ReadTypeSignature()));
				num2++;
			}
			return variableDefinitionCollection;
		}
		public IMetadataTokenProvider LookupToken(MetadataToken token)
		{
			uint rID = token.RID;
			if (rID == 0u)
			{
				return null;
			}
			int position = this.position;
			IGenericContext genericContext = this.context;
			TokenType tokenType = token.TokenType;
			IMetadataTokenProvider result;
			if (tokenType <= TokenType.Field)
			{
				if (tokenType == TokenType.TypeRef)
				{
					result = this.GetTypeReference(rID);
					goto IL_C3;
				}
				if (tokenType == TokenType.TypeDef)
				{
					result = this.GetTypeDefinition(rID);
					goto IL_C3;
				}
				if (tokenType == TokenType.Field)
				{
					result = this.GetFieldDefinition(rID);
					goto IL_C3;
				}
			}
			else
			{
				if (tokenType <= TokenType.MemberRef)
				{
					if (tokenType == TokenType.Method)
					{
						result = this.GetMethodDefinition(rID);
						goto IL_C3;
					}
					if (tokenType == TokenType.MemberRef)
					{
						result = this.GetMemberReference(rID);
						goto IL_C3;
					}
				}
				else
				{
					if (tokenType == TokenType.TypeSpec)
					{
						result = this.GetTypeSpecification(rID);
						goto IL_C3;
					}
					if (tokenType == TokenType.MethodSpec)
					{
						result = this.GetMethodSpecification(rID);
						goto IL_C3;
					}
				}
			}
			return null;
			IL_C3:
			this.position = position;
			this.context = genericContext;
			return result;
		}
		public FieldDefinition GetFieldDefinition(uint rid)
		{
			this.InitializeTypeDefinitions();
			FieldDefinition fieldDefinition = this.metadata.GetFieldDefinition(rid);
			if (fieldDefinition != null)
			{
				return fieldDefinition;
			}
			return this.LookupField(rid);
		}
		private FieldDefinition LookupField(uint rid)
		{
			TypeDefinition fieldDeclaringType = this.metadata.GetFieldDeclaringType(rid);
			if (fieldDeclaringType == null)
			{
				return null;
			}
			MetadataReader.InitializeCollection(fieldDeclaringType.Fields);
			return this.metadata.GetFieldDefinition(rid);
		}
		public MethodDefinition GetMethodDefinition(uint rid)
		{
			this.InitializeTypeDefinitions();
			MethodDefinition methodDefinition = this.metadata.GetMethodDefinition(rid);
			if (methodDefinition != null)
			{
				return methodDefinition;
			}
			return this.LookupMethod(rid);
		}
		private MethodDefinition LookupMethod(uint rid)
		{
			TypeDefinition methodDeclaringType = this.metadata.GetMethodDeclaringType(rid);
			if (methodDeclaringType == null)
			{
				return null;
			}
			MetadataReader.InitializeCollection(methodDeclaringType.Methods);
			return this.metadata.GetMethodDefinition(rid);
		}
		private MethodSpecification GetMethodSpecification(uint rid)
		{
			if (!this.MoveTo(Table.MethodSpec, rid))
			{
				return null;
			}
			MethodReference method = (MethodReference)this.LookupToken(this.ReadMetadataToken(CodedIndex.MethodDefOrRef));
			uint signature = this.ReadBlobIndex();
			MethodSpecification methodSpecification = this.ReadMethodSpecSignature(signature, method);
			methodSpecification.token = new MetadataToken(TokenType.MethodSpec, rid);
			return methodSpecification;
		}
		private MethodSpecification ReadMethodSpecSignature(uint signature, MethodReference method)
		{
			SignatureReader signatureReader = this.ReadSignature(signature);
			byte b = signatureReader.ReadByte();
			if (b != 10)
			{
				throw new NotSupportedException();
			}
			GenericInstanceMethod genericInstanceMethod = new GenericInstanceMethod(method);
			signatureReader.ReadGenericInstanceSignature(method, genericInstanceMethod);
			return genericInstanceMethod;
		}
		private MemberReference GetMemberReference(uint rid)
		{
			this.InitializeMemberReferences();
			MemberReference memberReference = this.metadata.GetMemberReference(rid);
			if (memberReference != null)
			{
				return memberReference;
			}
			memberReference = this.ReadMemberReference(rid);
			if (memberReference != null && !memberReference.ContainsGenericParameter)
			{
				this.metadata.AddMemberReference(memberReference);
			}
			return memberReference;
		}
		private MemberReference ReadMemberReference(uint rid)
		{
			if (!this.MoveTo(Table.MemberRef, rid))
			{
				return null;
			}
			MetadataToken metadataToken = this.ReadMetadataToken(CodedIndex.MemberRefParent);
			string name = this.ReadString();
			uint signature = this.ReadBlobIndex();
			TokenType tokenType = metadataToken.TokenType;
			MemberReference memberReference;
			if (tokenType <= TokenType.TypeDef)
			{
				if (tokenType != TokenType.TypeRef && tokenType != TokenType.TypeDef)
				{
					goto IL_73;
				}
			}
			else
			{
				if (tokenType == TokenType.Method)
				{
					memberReference = this.ReadMethodMemberReference(metadataToken, name, signature);
					goto IL_79;
				}
				if (tokenType != TokenType.TypeSpec)
				{
					goto IL_73;
				}
			}
			memberReference = this.ReadTypeMemberReference(metadataToken, name, signature);
			goto IL_79;
			IL_73:
			throw new NotSupportedException();
			IL_79:
			memberReference.token = new MetadataToken(TokenType.MemberRef, rid);
			if (this.module.IsWindowsMetadata())
			{
				WindowsRuntimeProjections.Project(memberReference);
			}
			return memberReference;
		}
		private MemberReference ReadTypeMemberReference(MetadataToken type, string name, uint signature)
		{
			TypeReference typeDefOrRef = this.GetTypeDefOrRef(type);
			if (!typeDefOrRef.IsArray)
			{
				this.context = typeDefOrRef;
			}
			MemberReference memberReference = this.ReadMemberReferenceSignature(signature, typeDefOrRef);
			memberReference.Name = name;
			return memberReference;
		}
		private MemberReference ReadMemberReferenceSignature(uint signature, TypeReference declaring_type)
		{
			SignatureReader signatureReader = this.ReadSignature(signature);
			if (signatureReader.buffer[signatureReader.position] == 6)
			{
				signatureReader.position++;
				return new FieldReference
				{
					DeclaringType = declaring_type,
					FieldType = signatureReader.ReadTypeSignature()
				};
			}
			MethodReference methodReference = new MethodReference();
			methodReference.DeclaringType = declaring_type;
			signatureReader.ReadMethodSignature(methodReference);
			return methodReference;
		}
		private MemberReference ReadMethodMemberReference(MetadataToken token, string name, uint signature)
		{
			MethodDefinition methodDefinition = this.GetMethodDefinition(token.RID);
			this.context = methodDefinition;
			MemberReference memberReference = this.ReadMemberReferenceSignature(signature, methodDefinition.DeclaringType);
			memberReference.Name = name;
			return memberReference;
		}
		private void InitializeMemberReferences()
		{
			if (this.metadata.MemberReferences != null)
			{
				return;
			}
			this.metadata.MemberReferences = new MemberReference[this.image.GetTableLength(Table.MemberRef)];
		}
		public IEnumerable<MemberReference> GetMemberReferences()
		{
			this.InitializeMemberReferences();
			int tableLength = this.image.GetTableLength(Table.MemberRef);
			TypeSystem typeSystem = this.module.TypeSystem;
			MethodReference methodReference = new MethodReference(string.Empty, typeSystem.Void);
			methodReference.DeclaringType = new TypeReference(string.Empty, string.Empty, this.module, typeSystem.CoreLibrary);
			MemberReference[] array = new MemberReference[tableLength];
			uint num = 1u;
			while ((ulong)num <= (ulong)((long)tableLength))
			{
				this.context = methodReference;
				array[(int)((UIntPtr)(num - 1u))] = this.GetMemberReference(num);
				num += 1u;
			}
			return array;
		}
		private void InitializeConstants()
		{
			if (this.metadata.Constants != null)
			{
				return;
			}
			int num = this.MoveTo(Table.Constant);
			Dictionary<MetadataToken, Row<ElementType, uint>> dictionary = this.metadata.Constants = new Dictionary<MetadataToken, Row<ElementType, uint>>(num);
			uint num2 = 1u;
			while ((ulong)num2 <= (ulong)((long)num))
			{
				ElementType col = (ElementType)base.ReadUInt16();
				MetadataToken key = this.ReadMetadataToken(CodedIndex.HasConstant);
				uint col2 = this.ReadBlobIndex();
				dictionary.Add(key, new Row<ElementType, uint>(col, col2));
				num2 += 1u;
			}
		}
		public object ReadConstant(IConstantProvider owner)
		{
			this.InitializeConstants();
			Row<ElementType, uint> row;
			if (!this.metadata.Constants.TryGetValue(owner.MetadataToken, out row))
			{
				return Mixin.NoValue;
			}
			this.metadata.Constants.Remove(owner.MetadataToken);
			ElementType col = row.Col1;
			if (col == ElementType.String)
			{
				return MetadataReader.ReadConstantString(this.ReadBlob(row.Col2));
			}
			if (col == ElementType.Class || col == ElementType.Object)
			{
				return null;
			}
			return this.ReadConstantPrimitive(row.Col1, row.Col2);
		}
		private static string ReadConstantString(byte[] blob)
		{
			int num = blob.Length;
			if ((num & 1) == 1)
			{
				num--;
			}
			return Encoding.Unicode.GetString(blob, 0, num);
		}
		private object ReadConstantPrimitive(ElementType type, uint signature)
		{
			SignatureReader signatureReader = this.ReadSignature(signature);
			return signatureReader.ReadConstantSignature(type);
		}
		private void InitializeCustomAttributes()
		{
			if (this.metadata.CustomAttributes != null)
			{
				return;
			}
			this.metadata.CustomAttributes = this.InitializeRanges(Table.CustomAttribute, delegate
			{
				MetadataToken result = this.ReadMetadataToken(CodedIndex.HasCustomAttribute);
				this.ReadMetadataToken(CodedIndex.CustomAttributeType);
				this.ReadBlobIndex();
				return result;
			});
		}
		public bool HasCustomAttributes(ICustomAttributeProvider owner)
		{
			this.InitializeCustomAttributes();
			Range[] ranges;
			return this.metadata.TryGetCustomAttributeRanges(owner, out ranges) && MetadataReader.RangesSize(ranges) > 0;
		}
		public Collection<CustomAttribute> ReadCustomAttributes(ICustomAttributeProvider owner)
		{
			this.InitializeCustomAttributes();
			Range[] array;
			if (!this.metadata.TryGetCustomAttributeRanges(owner, out array))
			{
				return new Collection<CustomAttribute>();
			}
			Collection<CustomAttribute> collection = new Collection<CustomAttribute>(MetadataReader.RangesSize(array));
			for (int i = 0; i < array.Length; i++)
			{
				this.ReadCustomAttributeRange(array[i], collection);
			}
			this.metadata.RemoveCustomAttributeRange(owner);
			if (this.module.IsWindowsMetadata())
			{
				foreach (CustomAttribute current in collection)
				{
					WindowsRuntimeProjections.Project(owner, current);
				}
			}
			return collection;
		}
		private void ReadCustomAttributeRange(Range range, Collection<CustomAttribute> custom_attributes)
		{
			if (!this.MoveTo(Table.CustomAttribute, range.Start))
			{
				return;
			}
			int num = 0;
			while ((long)num < (long)((ulong)range.Length))
			{
				this.ReadMetadataToken(CodedIndex.HasCustomAttribute);
				MethodReference constructor = (MethodReference)this.LookupToken(this.ReadMetadataToken(CodedIndex.CustomAttributeType));
				uint signature = this.ReadBlobIndex();
				custom_attributes.Add(new CustomAttribute(signature, constructor));
				num++;
			}
		}
		private static int RangesSize(Range[] ranges)
		{
			uint num = 0u;
			for (int i = 0; i < ranges.Length; i++)
			{
				num += ranges[i].Length;
			}
			return (int)num;
		}
		public byte[] ReadCustomAttributeBlob(uint signature)
		{
			return this.ReadBlob(signature);
		}
		public void ReadCustomAttributeSignature(CustomAttribute attribute)
		{
			SignatureReader signatureReader = this.ReadSignature(attribute.signature);
			if (!signatureReader.CanReadMore())
			{
				return;
			}
			if (signatureReader.ReadUInt16() != 1)
			{
				throw new InvalidOperationException();
			}
			MethodReference constructor = attribute.Constructor;
			if (constructor.HasParameters)
			{
				signatureReader.ReadCustomAttributeConstructorArguments(attribute, constructor.Parameters);
			}
			if (!signatureReader.CanReadMore())
			{
				return;
			}
			ushort num = signatureReader.ReadUInt16();
			if (num == 0)
			{
				return;
			}
			signatureReader.ReadCustomAttributeNamedArguments(num, ref attribute.fields, ref attribute.properties);
		}
		private void InitializeMarshalInfos()
		{
			if (this.metadata.FieldMarshals != null)
			{
				return;
			}
			int num = this.MoveTo(Table.FieldMarshal);
			Dictionary<MetadataToken, uint> dictionary = this.metadata.FieldMarshals = new Dictionary<MetadataToken, uint>(num);
			for (int i = 0; i < num; i++)
			{
				MetadataToken key = this.ReadMetadataToken(CodedIndex.HasFieldMarshal);
				uint value = this.ReadBlobIndex();
				if (key.RID != 0u)
				{
					dictionary.Add(key, value);
				}
			}
		}
		public bool HasMarshalInfo(IMarshalInfoProvider owner)
		{
			this.InitializeMarshalInfos();
			return this.metadata.FieldMarshals.ContainsKey(owner.MetadataToken);
		}
		public MarshalInfo ReadMarshalInfo(IMarshalInfoProvider owner)
		{
			this.InitializeMarshalInfos();
			uint signature;
			if (!this.metadata.FieldMarshals.TryGetValue(owner.MetadataToken, out signature))
			{
				return null;
			}
			SignatureReader signatureReader = this.ReadSignature(signature);
			this.metadata.FieldMarshals.Remove(owner.MetadataToken);
			return signatureReader.ReadMarshalInfo();
		}
		private void InitializeSecurityDeclarations()
		{
			if (this.metadata.SecurityDeclarations != null)
			{
				return;
			}
			this.metadata.SecurityDeclarations = this.InitializeRanges(Table.DeclSecurity, delegate
			{
				base.ReadUInt16();
				MetadataToken result = this.ReadMetadataToken(CodedIndex.HasDeclSecurity);
				this.ReadBlobIndex();
				return result;
			});
		}
		public bool HasSecurityDeclarations(ISecurityDeclarationProvider owner)
		{
			this.InitializeSecurityDeclarations();
			Range[] ranges;
			return this.metadata.TryGetSecurityDeclarationRanges(owner, out ranges) && MetadataReader.RangesSize(ranges) > 0;
		}
		public Collection<SecurityDeclaration> ReadSecurityDeclarations(ISecurityDeclarationProvider owner)
		{
			this.InitializeSecurityDeclarations();
			Range[] array;
			if (!this.metadata.TryGetSecurityDeclarationRanges(owner, out array))
			{
				return new Collection<SecurityDeclaration>();
			}
			Collection<SecurityDeclaration> collection = new Collection<SecurityDeclaration>(MetadataReader.RangesSize(array));
			for (int i = 0; i < array.Length; i++)
			{
				this.ReadSecurityDeclarationRange(array[i], collection);
			}
			this.metadata.RemoveSecurityDeclarationRange(owner);
			return collection;
		}
		private void ReadSecurityDeclarationRange(Range range, Collection<SecurityDeclaration> security_declarations)
		{
			if (!this.MoveTo(Table.DeclSecurity, range.Start))
			{
				return;
			}
			int num = 0;
			while ((long)num < (long)((ulong)range.Length))
			{
				SecurityAction action = (SecurityAction)base.ReadUInt16();
				this.ReadMetadataToken(CodedIndex.HasDeclSecurity);
				uint signature = this.ReadBlobIndex();
				security_declarations.Add(new SecurityDeclaration(action, signature, this.module));
				num++;
			}
		}
		public byte[] ReadSecurityDeclarationBlob(uint signature)
		{
			return this.ReadBlob(signature);
		}
		public void ReadSecurityDeclarationSignature(SecurityDeclaration declaration)
		{
			uint signature = declaration.signature;
			SignatureReader signatureReader = this.ReadSignature(signature);
			if (signatureReader.buffer[signatureReader.position] != 46)
			{
				this.ReadXmlSecurityDeclaration(signature, declaration);
				return;
			}
			signatureReader.position++;
			uint num = signatureReader.ReadCompressedUInt32();
			Collection<SecurityAttribute> collection = new Collection<SecurityAttribute>((int)num);
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				collection.Add(signatureReader.ReadSecurityAttribute());
				num2++;
			}
			declaration.security_attributes = collection;
		}
		private void ReadXmlSecurityDeclaration(uint signature, SecurityDeclaration declaration)
		{
			byte[] array = this.ReadBlob(signature);
			declaration.security_attributes = new Collection<SecurityAttribute>(1)
			{
				new SecurityAttribute(this.module.TypeSystem.LookupType("System.Security.Permissions", "PermissionSetAttribute"))
				{
					properties = new Collection<CustomAttributeNamedArgument>(1)
					{
						new CustomAttributeNamedArgument("XML", new CustomAttributeArgument(this.module.TypeSystem.String, Encoding.Unicode.GetString(array, 0, array.Length)))
					}
				}
			};
		}
		public Collection<ExportedType> ReadExportedTypes()
		{
			int num = this.MoveTo(Table.ExportedType);
			if (num == 0)
			{
				return new Collection<ExportedType>();
			}
			Collection<ExportedType> collection = new Collection<ExportedType>(num);
			for (int i = 1; i <= num; i++)
			{
				TypeAttributes attributes = (TypeAttributes)base.ReadUInt32();
				uint identifier = base.ReadUInt32();
				string name = this.ReadString();
				string @namespace = this.ReadString();
				MetadataToken token = this.ReadMetadataToken(CodedIndex.Implementation);
				ExportedType declaringType = null;
				IMetadataScope scope = null;
				TokenType tokenType = token.TokenType;
				if (tokenType != TokenType.AssemblyRef && tokenType != TokenType.File)
				{
					if (tokenType == TokenType.ExportedType)
					{
						declaringType = collection[(int)(token.RID - 1u)];
					}
				}
				else
				{
					scope = this.GetExportedTypeScope(token);
				}
				ExportedType exportedType = new ExportedType(@namespace, name, this.module, scope)
				{
					Attributes = attributes,
					Identifier = (int)identifier,
					DeclaringType = declaringType
				};
				exportedType.token = new MetadataToken(TokenType.ExportedType, i);
				collection.Add(exportedType);
			}
			return collection;
		}
		private IMetadataScope GetExportedTypeScope(MetadataToken token)
		{
			int position = this.position;
			TokenType tokenType = token.TokenType;
			IMetadataScope result;
			if (tokenType != TokenType.AssemblyRef)
			{
				if (tokenType != TokenType.File)
				{
					throw new NotSupportedException();
				}
				this.InitializeModuleReferences();
				result = this.GetModuleReferenceFromFile(token);
			}
			else
			{
				this.InitializeAssemblyReferences();
				result = this.metadata.AssemblyReferences[(int)(token.RID - 1u)];
			}
			this.position = position;
			return result;
		}
		private ModuleReference GetModuleReferenceFromFile(MetadataToken token)
		{
			if (!this.MoveTo(Table.File, token.RID))
			{
				return null;
			}
			base.ReadUInt32();
			string text = this.ReadString();
			Collection<ModuleReference> moduleReferences = this.module.ModuleReferences;
			ModuleReference moduleReference;
			for (int i = 0; i < moduleReferences.Count; i++)
			{
				moduleReference = moduleReferences[i];
				if (moduleReference.Name == text)
				{
					return moduleReference;
				}
			}
			moduleReference = new ModuleReference(text);
			moduleReferences.Add(moduleReference);
			return moduleReference;
		}
		private static void InitializeCollection(object o)
		{
		}
	}
}
