using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Cecil.PE;
using Editor_Mono.Collections.Generic;
using System;
using System.Text;
namespace Editor_Mono.Cecil
{
	internal sealed class SignatureReader : ByteBuffer
	{
		private readonly MetadataReader reader;
		private readonly uint start;
		private readonly uint sig_length;
		private TypeSystem TypeSystem
		{
			get
			{
				return this.reader.module.TypeSystem;
			}
		}
		public SignatureReader(uint blob, MetadataReader reader) : base(reader.buffer)
		{
			this.reader = reader;
			this.MoveToBlob(blob);
			this.sig_length = base.ReadCompressedUInt32();
			this.start = (uint)this.position;
		}
		private void MoveToBlob(uint blob)
		{
			this.position = (int)(this.reader.image.BlobHeap.Offset + blob);
		}
		private MetadataToken ReadTypeTokenSignature()
		{
			return CodedIndex.TypeDefOrRef.GetMetadataToken(base.ReadCompressedUInt32());
		}
		private GenericParameter GetGenericParameter(GenericParameterType type, uint var)
		{
			IGenericContext context = this.reader.context;
			if (context == null)
			{
				return this.GetUnboundGenericParameter(type, (int)var);
			}
			IGenericParameterProvider genericParameterProvider;
			switch (type)
			{
			case GenericParameterType.Type:
				genericParameterProvider = context.Type;
				break;
			case GenericParameterType.Method:
				genericParameterProvider = context.Method;
				break;
			default:
				throw new NotSupportedException();
			}
			if (!context.IsDefinition)
			{
				SignatureReader.CheckGenericContext(genericParameterProvider, (int)var);
			}
			if (var >= (uint)genericParameterProvider.GenericParameters.Count)
			{
				return this.GetUnboundGenericParameter(type, (int)var);
			}
			return genericParameterProvider.GenericParameters[(int)var];
		}
		private GenericParameter GetUnboundGenericParameter(GenericParameterType type, int index)
		{
			return new GenericParameter(index, type, this.reader.module);
		}
		private static void CheckGenericContext(IGenericParameterProvider owner, int index)
		{
			Collection<GenericParameter> genericParameters = owner.GenericParameters;
			for (int i = genericParameters.Count; i <= index; i++)
			{
				genericParameters.Add(new GenericParameter(owner));
			}
		}
		public void ReadGenericInstanceSignature(IGenericParameterProvider provider, IGenericInstance instance)
		{
			uint num = base.ReadCompressedUInt32();
			if (!provider.IsDefinition)
			{
				SignatureReader.CheckGenericContext(provider, (int)(num - 1u));
			}
			Collection<TypeReference> genericArguments = instance.GenericArguments;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				genericArguments.Add(this.ReadTypeSignature());
				num2++;
			}
		}
		private ArrayType ReadArrayTypeSignature()
		{
			ArrayType arrayType = new ArrayType(this.ReadTypeSignature());
			uint num = base.ReadCompressedUInt32();
			uint[] array = new uint[base.ReadCompressedUInt32()];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = base.ReadCompressedUInt32();
			}
			int[] array2 = new int[base.ReadCompressedUInt32()];
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = base.ReadCompressedInt32();
			}
			arrayType.Dimensions.Clear();
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				int? num3 = null;
				int? upperBound = null;
				if (num2 < array2.Length)
				{
					num3 = new int?(array2[num2]);
				}
				if (num2 < array.Length)
				{
					upperBound = num3 + (int)array[num2] - 1;
				}
				arrayType.Dimensions.Add(new ArrayDimension(num3, upperBound));
				num2++;
			}
			return arrayType;
		}
		private TypeReference GetTypeDefOrRef(MetadataToken token)
		{
			return this.reader.GetTypeDefOrRef(token);
		}
		public TypeReference ReadTypeSignature()
		{
			return this.ReadTypeSignature((ElementType)base.ReadByte());
		}
		private TypeReference ReadTypeSignature(ElementType etype)
		{
			switch (etype)
			{
			case ElementType.Void:
				return this.TypeSystem.Void;
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
			case ElementType.String:
			case (ElementType)23:
			case (ElementType)26:
				break;
			case ElementType.Ptr:
				return new PointerType(this.ReadTypeSignature());
			case ElementType.ByRef:
				return new ByReferenceType(this.ReadTypeSignature());
			case ElementType.ValueType:
			{
				TypeReference typeDefOrRef = this.GetTypeDefOrRef(this.ReadTypeTokenSignature());
				typeDefOrRef.IsValueType = true;
				return typeDefOrRef;
			}
			case ElementType.Class:
				return this.GetTypeDefOrRef(this.ReadTypeTokenSignature());
			case ElementType.Var:
				return this.GetGenericParameter(GenericParameterType.Type, base.ReadCompressedUInt32());
			case ElementType.Array:
				return this.ReadArrayTypeSignature();
			case ElementType.GenericInst:
			{
				bool flag = base.ReadByte() == 17;
				TypeReference typeDefOrRef2 = this.GetTypeDefOrRef(this.ReadTypeTokenSignature());
				GenericInstanceType genericInstanceType = new GenericInstanceType(typeDefOrRef2);
				this.ReadGenericInstanceSignature(typeDefOrRef2, genericInstanceType);
				if (flag)
				{
					genericInstanceType.IsValueType = true;
					typeDefOrRef2.GetElementType().IsValueType = true;
				}
				return genericInstanceType;
			}
			case ElementType.TypedByRef:
				return this.TypeSystem.TypedReference;
			case ElementType.I:
				return this.TypeSystem.IntPtr;
			case ElementType.U:
				return this.TypeSystem.UIntPtr;
			case ElementType.FnPtr:
			{
				FunctionPointerType functionPointerType = new FunctionPointerType();
				this.ReadMethodSignature(functionPointerType);
				return functionPointerType;
			}
			case ElementType.Object:
				return this.TypeSystem.Object;
			case ElementType.SzArray:
				return new ArrayType(this.ReadTypeSignature());
			case ElementType.MVar:
				return this.GetGenericParameter(GenericParameterType.Method, base.ReadCompressedUInt32());
			case ElementType.CModReqD:
				return new RequiredModifierType(this.GetTypeDefOrRef(this.ReadTypeTokenSignature()), this.ReadTypeSignature());
			case ElementType.CModOpt:
				return new OptionalModifierType(this.GetTypeDefOrRef(this.ReadTypeTokenSignature()), this.ReadTypeSignature());
			default:
				if (etype == ElementType.Sentinel)
				{
					return new SentinelType(this.ReadTypeSignature());
				}
				if (etype == ElementType.Pinned)
				{
					return new PinnedType(this.ReadTypeSignature());
				}
				break;
			}
			return this.GetPrimitiveType(etype);
		}
		public void ReadMethodSignature(IMethodSignature method)
		{
			byte b = base.ReadByte();
			if ((b & 32) != 0)
			{
				method.HasThis = true;
				b = (byte)((int)b & -33);
			}
			if ((b & 64) != 0)
			{
				method.ExplicitThis = true;
				b = (byte)((int)b & -65);
			}
			method.CallingConvention = (MethodCallingConvention)b;
			MethodReference methodReference = method as MethodReference;
			if (methodReference != null && !methodReference.DeclaringType.IsArray)
			{
				this.reader.context = methodReference;
			}
			if ((b & 16) != 0)
			{
				uint num = base.ReadCompressedUInt32();
				if (methodReference != null && !methodReference.IsDefinition)
				{
					SignatureReader.CheckGenericContext(methodReference, (int)(num - 1u));
				}
			}
			uint num2 = base.ReadCompressedUInt32();
			method.MethodReturnType.ReturnType = this.ReadTypeSignature();
			if (num2 == 0u)
			{
				return;
			}
			MethodReference methodReference2 = method as MethodReference;
			Collection<ParameterDefinition> collection;
			if (methodReference2 != null)
			{
				collection = (methodReference2.parameters = new ParameterDefinitionCollection(method, (int)num2));
			}
			else
			{
				collection = method.Parameters;
			}
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num2))
			{
				collection.Add(new ParameterDefinition(this.ReadTypeSignature()));
				num3++;
			}
		}
		public object ReadConstantSignature(ElementType type)
		{
			return this.ReadPrimitiveValue(type);
		}
		public void ReadCustomAttributeConstructorArguments(CustomAttribute attribute, Collection<ParameterDefinition> parameters)
		{
			int count = parameters.Count;
			if (count == 0)
			{
				return;
			}
			attribute.arguments = new Collection<CustomAttributeArgument>(count);
			for (int i = 0; i < count; i++)
			{
				attribute.arguments.Add(this.ReadCustomAttributeFixedArgument(parameters[i].ParameterType));
			}
		}
		private CustomAttributeArgument ReadCustomAttributeFixedArgument(TypeReference type)
		{
			if (type.IsArray)
			{
				return this.ReadCustomAttributeFixedArrayArgument((ArrayType)type);
			}
			return this.ReadCustomAttributeElement(type);
		}
		public void ReadCustomAttributeNamedArguments(ushort count, ref Collection<CustomAttributeNamedArgument> fields, ref Collection<CustomAttributeNamedArgument> properties)
		{
			for (int i = 0; i < (int)count; i++)
			{
				if (!this.CanReadMore())
				{
					return;
				}
				this.ReadCustomAttributeNamedArgument(ref fields, ref properties);
			}
		}
		private void ReadCustomAttributeNamedArgument(ref Collection<CustomAttributeNamedArgument> fields, ref Collection<CustomAttributeNamedArgument> properties)
		{
			byte b = base.ReadByte();
			TypeReference type = this.ReadCustomAttributeFieldOrPropType();
			string name = this.ReadUTF8String();
			Collection<CustomAttributeNamedArgument> customAttributeNamedArgumentCollection;
			switch (b)
			{
			case 83:
				customAttributeNamedArgumentCollection = SignatureReader.GetCustomAttributeNamedArgumentCollection(ref fields);
				break;
			case 84:
				customAttributeNamedArgumentCollection = SignatureReader.GetCustomAttributeNamedArgumentCollection(ref properties);
				break;
			default:
				throw new NotSupportedException();
			}
			customAttributeNamedArgumentCollection.Add(new CustomAttributeNamedArgument(name, this.ReadCustomAttributeFixedArgument(type)));
		}
		private static Collection<CustomAttributeNamedArgument> GetCustomAttributeNamedArgumentCollection(ref Collection<CustomAttributeNamedArgument> collection)
		{
			if (collection != null)
			{
				return collection;
			}
			Collection<CustomAttributeNamedArgument> result;
			collection = (result = new Collection<CustomAttributeNamedArgument>());
			return result;
		}
		private CustomAttributeArgument ReadCustomAttributeFixedArrayArgument(ArrayType type)
		{
			uint num = base.ReadUInt32();
			if (num == 4294967295u)
			{
				return new CustomAttributeArgument(type, null);
			}
			if (num == 0u)
			{
				return new CustomAttributeArgument(type, Empty<CustomAttributeArgument>.Array);
			}
			CustomAttributeArgument[] array = new CustomAttributeArgument[num];
			TypeReference elementType = type.ElementType;
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				array[num2] = this.ReadCustomAttributeElement(elementType);
				num2++;
			}
			return new CustomAttributeArgument(type, array);
		}
		private CustomAttributeArgument ReadCustomAttributeElement(TypeReference type)
		{
			if (type.IsArray)
			{
				return this.ReadCustomAttributeFixedArrayArgument((ArrayType)type);
			}
			return new CustomAttributeArgument(type, (type.etype == ElementType.Object) ? this.ReadCustomAttributeElement(this.ReadCustomAttributeFieldOrPropType()) : this.ReadCustomAttributeElementValue(type));
		}
		private object ReadCustomAttributeElementValue(TypeReference type)
		{
			ElementType etype = type.etype;
			ElementType elementType = etype;
			if (elementType != ElementType.None)
			{
				if (elementType == ElementType.String)
				{
					return this.ReadUTF8String();
				}
				return this.ReadPrimitiveValue(etype);
			}
			else
			{
				if (type.IsTypeOf("System", "Type"))
				{
					return this.ReadTypeReference();
				}
				return this.ReadCustomAttributeEnum(type);
			}
		}
		private object ReadPrimitiveValue(ElementType type)
		{
			switch (type)
			{
			case ElementType.Boolean:
				return base.ReadByte() == 1;
			case ElementType.Char:
				return (char)base.ReadUInt16();
			case ElementType.I1:
				return (sbyte)base.ReadByte();
			case ElementType.U1:
				return base.ReadByte();
			case ElementType.I2:
				return base.ReadInt16();
			case ElementType.U2:
				return base.ReadUInt16();
			case ElementType.I4:
				return base.ReadInt32();
			case ElementType.U4:
				return base.ReadUInt32();
			case ElementType.I8:
				return base.ReadInt64();
			case ElementType.U8:
				return base.ReadUInt64();
			case ElementType.R4:
				return base.ReadSingle();
			case ElementType.R8:
				return base.ReadDouble();
			default:
				throw new NotImplementedException(type.ToString());
			}
		}
		private TypeReference GetPrimitiveType(ElementType etype)
		{
			switch (etype)
			{
			case ElementType.Boolean:
				return this.TypeSystem.Boolean;
			case ElementType.Char:
				return this.TypeSystem.Char;
			case ElementType.I1:
				return this.TypeSystem.SByte;
			case ElementType.U1:
				return this.TypeSystem.Byte;
			case ElementType.I2:
				return this.TypeSystem.Int16;
			case ElementType.U2:
				return this.TypeSystem.UInt16;
			case ElementType.I4:
				return this.TypeSystem.Int32;
			case ElementType.U4:
				return this.TypeSystem.UInt32;
			case ElementType.I8:
				return this.TypeSystem.Int64;
			case ElementType.U8:
				return this.TypeSystem.UInt64;
			case ElementType.R4:
				return this.TypeSystem.Single;
			case ElementType.R8:
				return this.TypeSystem.Double;
			case ElementType.String:
				return this.TypeSystem.String;
			default:
				throw new NotImplementedException(etype.ToString());
			}
		}
		private TypeReference ReadCustomAttributeFieldOrPropType()
		{
			ElementType elementType = (ElementType)base.ReadByte();
			ElementType elementType2 = elementType;
			if (elementType2 == ElementType.SzArray)
			{
				return new ArrayType(this.ReadCustomAttributeFieldOrPropType());
			}
			switch (elementType2)
			{
			case ElementType.Type:
				return this.TypeSystem.LookupType("System", "Type");
			case ElementType.Boxed:
				return this.TypeSystem.Object;
			default:
				if (elementType2 != ElementType.Enum)
				{
					return this.GetPrimitiveType(elementType);
				}
				return this.ReadTypeReference();
			}
		}
		public TypeReference ReadTypeReference()
		{
			return TypeParser.ParseType(this.reader.module, this.ReadUTF8String());
		}
		private object ReadCustomAttributeEnum(TypeReference enum_type)
		{
			TypeDefinition typeDefinition = enum_type.CheckedResolve();
			if (!typeDefinition.IsEnum)
			{
				throw new ArgumentException();
			}
			return this.ReadCustomAttributeElementValue(typeDefinition.GetEnumUnderlyingType());
		}
		public SecurityAttribute ReadSecurityAttribute()
		{
			SecurityAttribute securityAttribute = new SecurityAttribute(this.ReadTypeReference());
			base.ReadCompressedUInt32();
			this.ReadCustomAttributeNamedArguments((ushort)base.ReadCompressedUInt32(), ref securityAttribute.fields, ref securityAttribute.properties);
			return securityAttribute;
		}
		public MarshalInfo ReadMarshalInfo()
		{
			NativeType nativeType = this.ReadNativeType();
			NativeType nativeType2 = nativeType;
			if (nativeType2 == NativeType.FixedSysString)
			{
				FixedSysStringMarshalInfo fixedSysStringMarshalInfo = new FixedSysStringMarshalInfo();
				if (this.CanReadMore())
				{
					fixedSysStringMarshalInfo.size = (int)base.ReadCompressedUInt32();
				}
				return fixedSysStringMarshalInfo;
			}
			switch (nativeType2)
			{
			case NativeType.SafeArray:
			{
				SafeArrayMarshalInfo safeArrayMarshalInfo = new SafeArrayMarshalInfo();
				if (this.CanReadMore())
				{
					safeArrayMarshalInfo.element_type = this.ReadVariantType();
				}
				return safeArrayMarshalInfo;
			}
			case NativeType.FixedArray:
			{
				FixedArrayMarshalInfo fixedArrayMarshalInfo = new FixedArrayMarshalInfo();
				if (this.CanReadMore())
				{
					fixedArrayMarshalInfo.size = (int)base.ReadCompressedUInt32();
				}
				if (this.CanReadMore())
				{
					fixedArrayMarshalInfo.element_type = this.ReadNativeType();
				}
				return fixedArrayMarshalInfo;
			}
			default:
				switch (nativeType2)
				{
				case NativeType.Array:
				{
					ArrayMarshalInfo arrayMarshalInfo = new ArrayMarshalInfo();
					if (this.CanReadMore())
					{
						arrayMarshalInfo.element_type = this.ReadNativeType();
					}
					if (this.CanReadMore())
					{
						arrayMarshalInfo.size_parameter_index = (int)base.ReadCompressedUInt32();
					}
					if (this.CanReadMore())
					{
						arrayMarshalInfo.size = (int)base.ReadCompressedUInt32();
					}
					if (this.CanReadMore())
					{
						arrayMarshalInfo.size_parameter_multiplier = (int)base.ReadCompressedUInt32();
					}
					return arrayMarshalInfo;
				}
				case NativeType.CustomMarshaler:
				{
					CustomMarshalInfo customMarshalInfo = new CustomMarshalInfo();
					string text = this.ReadUTF8String();
					customMarshalInfo.guid = ((!string.IsNullOrEmpty(text)) ? new Guid(text) : Guid.Empty);
					customMarshalInfo.unmanaged_type = this.ReadUTF8String();
					customMarshalInfo.managed_type = this.ReadTypeReference();
					customMarshalInfo.cookie = this.ReadUTF8String();
					return customMarshalInfo;
				}
				}
				return new MarshalInfo(nativeType);
			}
		}
		private NativeType ReadNativeType()
		{
			return (NativeType)base.ReadByte();
		}
		private VariantType ReadVariantType()
		{
			return (VariantType)base.ReadByte();
		}
		private string ReadUTF8String()
		{
			if (this.buffer[this.position] == 255)
			{
				this.position++;
				return null;
			}
			int num = (int)base.ReadCompressedUInt32();
			if (num == 0)
			{
				return string.Empty;
			}
			string @string = Encoding.UTF8.GetString(this.buffer, this.position, (this.buffer[this.position + num - 1] == 0) ? (num - 1) : num);
			this.position += num;
			return @string;
		}
		public bool CanReadMore()
		{
			return (long)this.position - (long)((ulong)this.start) < (long)((ulong)this.sig_length);
		}
	}
}
