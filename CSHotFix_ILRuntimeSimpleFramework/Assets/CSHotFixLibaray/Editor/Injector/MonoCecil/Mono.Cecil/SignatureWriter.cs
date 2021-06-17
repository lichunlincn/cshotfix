using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Cecil.PE;
using Editor_Mono.Collections.Generic;
using System;
using System.Text;
namespace Editor_Mono.Cecil
{
	internal sealed class SignatureWriter : ByteBuffer
	{
		private readonly MetadataBuilder metadata;
		public SignatureWriter(MetadataBuilder metadata) : base(6)
		{
			this.metadata = metadata;
		}
		public void WriteElementType(ElementType element_type)
		{
			base.WriteByte((byte)element_type);
		}
		public void WriteUTF8String(string @string)
		{
			if (@string == null)
			{
				base.WriteByte(255);
				return;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(@string);
			base.WriteCompressedUInt32((uint)bytes.Length);
			base.WriteBytes(bytes);
		}
		public void WriteMethodSignature(IMethodSignature method)
		{
			byte b = (byte)method.CallingConvention;
			if (method.HasThis)
			{
				b |= 32;
			}
			if (method.ExplicitThis)
			{
				b |= 64;
			}
			IGenericParameterProvider genericParameterProvider = method as IGenericParameterProvider;
			int num = (genericParameterProvider != null && genericParameterProvider.HasGenericParameters) ? genericParameterProvider.GenericParameters.Count : 0;
			if (num > 0)
			{
				b |= 16;
			}
			int num2 = method.HasParameters ? method.Parameters.Count : 0;
			base.WriteByte(b);
			if (num > 0)
			{
				base.WriteCompressedUInt32((uint)num);
			}
			base.WriteCompressedUInt32((uint)num2);
			this.WriteTypeSignature(method.ReturnType);
			if (num2 == 0)
			{
				return;
			}
			Collection<ParameterDefinition> parameters = method.Parameters;
			for (int i = 0; i < num2; i++)
			{
				this.WriteTypeSignature(parameters[i].ParameterType);
			}
		}
		private uint MakeTypeDefOrRefCodedRID(TypeReference type)
		{
			return CodedIndex.TypeDefOrRef.CompressMetadataToken(this.metadata.LookupToken(type));
		}
		public void WriteTypeSignature(TypeReference type)
		{
			if (type == null)
			{
				throw new ArgumentNullException();
			}
			ElementType etype = type.etype;
			ElementType elementType = etype;
			if (elementType <= ElementType.GenericInst)
			{
				if (elementType == ElementType.None)
				{
					this.WriteElementType(type.IsValueType ? ElementType.ValueType : ElementType.Class);
					base.WriteCompressedUInt32(this.MakeTypeDefOrRefCodedRID(type));
					return;
				}
				switch (elementType)
				{
				case ElementType.Ptr:
				case ElementType.ByRef:
					goto IL_E3;
				case ElementType.ValueType:
				case ElementType.Class:
					goto IL_17D;
				case ElementType.Var:
					break;
				case ElementType.Array:
				{
					ArrayType arrayType = (ArrayType)type;
					if (!arrayType.IsVector)
					{
						this.WriteArrayTypeSignature(arrayType);
						return;
					}
					this.WriteElementType(ElementType.SzArray);
					this.WriteTypeSignature(arrayType.ElementType);
					return;
				}
				case ElementType.GenericInst:
				{
					GenericInstanceType genericInstanceType = (GenericInstanceType)type;
					this.WriteElementType(ElementType.GenericInst);
					this.WriteElementType(genericInstanceType.IsValueType ? ElementType.ValueType : ElementType.Class);
					base.WriteCompressedUInt32(this.MakeTypeDefOrRefCodedRID(genericInstanceType.ElementType));
					this.WriteGenericInstanceSignature(genericInstanceType);
					return;
				}
				default:
					goto IL_17D;
				}
			}
			else
			{
				switch (elementType)
				{
				case ElementType.FnPtr:
				{
					FunctionPointerType method = (FunctionPointerType)type;
					this.WriteElementType(ElementType.FnPtr);
					this.WriteMethodSignature(method);
					return;
				}
				case ElementType.Object:
				case ElementType.SzArray:
					goto IL_17D;
				case ElementType.MVar:
					break;
				case ElementType.CModReqD:
				case ElementType.CModOpt:
				{
					IModifierType type2 = (IModifierType)type;
					this.WriteModifierSignature(etype, type2);
					return;
				}
				default:
					if (elementType != ElementType.Sentinel && elementType != ElementType.Pinned)
					{
						goto IL_17D;
					}
					goto IL_E3;
				}
			}
			GenericParameter genericParameter = (GenericParameter)type;
			this.WriteElementType(etype);
			int position = genericParameter.Position;
			if (position == -1)
			{
				throw new NotSupportedException();
			}
			base.WriteCompressedUInt32((uint)position);
			return;
			IL_E3:
			TypeSpecification typeSpecification = (TypeSpecification)type;
			this.WriteElementType(etype);
			this.WriteTypeSignature(typeSpecification.ElementType);
			return;
			IL_17D:
			if (!this.TryWriteElementType(type))
			{
				throw new NotSupportedException();
			}
		}
		private void WriteArrayTypeSignature(ArrayType array)
		{
			this.WriteElementType(ElementType.Array);
			this.WriteTypeSignature(array.ElementType);
			Collection<ArrayDimension> dimensions = array.Dimensions;
			int count = dimensions.Count;
			base.WriteCompressedUInt32((uint)count);
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < count; i++)
			{
				ArrayDimension arrayDimension = dimensions[i];
				if (arrayDimension.UpperBound.HasValue)
				{
					num++;
					num2++;
				}
				else
				{
					if (arrayDimension.LowerBound.HasValue)
					{
						num2++;
					}
				}
			}
			int[] array2 = new int[num];
			int[] array3 = new int[num2];
			for (int j = 0; j < num2; j++)
			{
				ArrayDimension arrayDimension2 = dimensions[j];
				array3[j] = arrayDimension2.LowerBound.GetValueOrDefault();
				if (arrayDimension2.UpperBound.HasValue)
				{
					array2[j] = arrayDimension2.UpperBound.Value - array3[j] + 1;
				}
			}
			base.WriteCompressedUInt32((uint)num);
			for (int k = 0; k < num; k++)
			{
				base.WriteCompressedUInt32((uint)array2[k]);
			}
			base.WriteCompressedUInt32((uint)num2);
			for (int l = 0; l < num2; l++)
			{
				base.WriteCompressedInt32(array3[l]);
			}
		}
		public void WriteGenericInstanceSignature(IGenericInstance instance)
		{
			Collection<TypeReference> genericArguments = instance.GenericArguments;
			int count = genericArguments.Count;
			base.WriteCompressedUInt32((uint)count);
			for (int i = 0; i < count; i++)
			{
				this.WriteTypeSignature(genericArguments[i]);
			}
		}
		private void WriteModifierSignature(ElementType element_type, IModifierType type)
		{
			this.WriteElementType(element_type);
			base.WriteCompressedUInt32(this.MakeTypeDefOrRefCodedRID(type.ModifierType));
			this.WriteTypeSignature(type.ElementType);
		}
		private bool TryWriteElementType(TypeReference type)
		{
			ElementType etype = type.etype;
			if (etype == ElementType.None)
			{
				return false;
			}
			this.WriteElementType(etype);
			return true;
		}
		public void WriteConstantString(string value)
		{
			base.WriteBytes(Encoding.Unicode.GetBytes(value));
		}
		public void WriteConstantPrimitive(object value)
		{
			this.WritePrimitiveValue(value);
		}
		public void WriteCustomAttributeConstructorArguments(CustomAttribute attribute)
		{
			if (!attribute.HasConstructorArguments)
			{
				return;
			}
			Collection<CustomAttributeArgument> constructorArguments = attribute.ConstructorArguments;
			Collection<ParameterDefinition> parameters = attribute.Constructor.Parameters;
			if (parameters.Count != constructorArguments.Count)
			{
				throw new InvalidOperationException();
			}
			for (int i = 0; i < constructorArguments.Count; i++)
			{
				this.WriteCustomAttributeFixedArgument(parameters[i].ParameterType, constructorArguments[i]);
			}
		}
		private void WriteCustomAttributeFixedArgument(TypeReference type, CustomAttributeArgument argument)
		{
			if (type.IsArray)
			{
				this.WriteCustomAttributeFixedArrayArgument((ArrayType)type, argument);
				return;
			}
			this.WriteCustomAttributeElement(type, argument);
		}
		private void WriteCustomAttributeFixedArrayArgument(ArrayType type, CustomAttributeArgument argument)
		{
			CustomAttributeArgument[] array = argument.Value as CustomAttributeArgument[];
			if (array == null)
			{
				base.WriteUInt32(4294967295u);
				return;
			}
			base.WriteInt32(array.Length);
			if (array.Length == 0)
			{
				return;
			}
			TypeReference elementType = type.ElementType;
			for (int i = 0; i < array.Length; i++)
			{
				this.WriteCustomAttributeElement(elementType, array[i]);
			}
		}
		private void WriteCustomAttributeElement(TypeReference type, CustomAttributeArgument argument)
		{
			if (type.IsArray)
			{
				this.WriteCustomAttributeFixedArrayArgument((ArrayType)type, argument);
				return;
			}
			if (type.etype == ElementType.Object)
			{
				argument = (CustomAttributeArgument)argument.Value;
				type = argument.Type;
				this.WriteCustomAttributeFieldOrPropType(type);
				this.WriteCustomAttributeElement(type, argument);
				return;
			}
			this.WriteCustomAttributeValue(type, argument.Value);
		}
		private void WriteCustomAttributeValue(TypeReference type, object value)
		{
			ElementType etype = type.etype;
			ElementType elementType = etype;
			if (elementType != ElementType.None)
			{
				if (elementType != ElementType.String)
				{
					this.WritePrimitiveValue(value);
					return;
				}
				string text = (string)value;
				if (text == null)
				{
					base.WriteByte(255);
					return;
				}
				this.WriteUTF8String(text);
				return;
			}
			else
			{
				if (type.IsTypeOf("System", "Type"))
				{
					this.WriteTypeReference((TypeReference)value);
					return;
				}
				this.WriteCustomAttributeEnumValue(type, value);
				return;
			}
		}
		private void WritePrimitiveValue(object value)
		{
			if (value == null)
			{
				throw new ArgumentNullException();
			}
			switch (Type.GetTypeCode(value.GetType()))
			{
			case TypeCode.Boolean:
				base.WriteByte((byte)(((bool)value) ? 1 : 0));
				return;
			case TypeCode.Char:
				base.WriteInt16((short)((char)value));
				return;
			case TypeCode.SByte:
				base.WriteSByte((sbyte)value);
				return;
			case TypeCode.Byte:
				base.WriteByte((byte)value);
				return;
			case TypeCode.Int16:
				base.WriteInt16((short)value);
				return;
			case TypeCode.UInt16:
				base.WriteUInt16((ushort)value);
				return;
			case TypeCode.Int32:
				base.WriteInt32((int)value);
				return;
			case TypeCode.UInt32:
				base.WriteUInt32((uint)value);
				return;
			case TypeCode.Int64:
				base.WriteInt64((long)value);
				return;
			case TypeCode.UInt64:
				base.WriteUInt64((ulong)value);
				return;
			case TypeCode.Single:
				base.WriteSingle((float)value);
				return;
			case TypeCode.Double:
				base.WriteDouble((double)value);
				return;
			default:
				throw new NotSupportedException(value.GetType().FullName);
			}
		}
		private void WriteCustomAttributeEnumValue(TypeReference enum_type, object value)
		{
			TypeDefinition typeDefinition = enum_type.CheckedResolve();
			if (!typeDefinition.IsEnum)
			{
				throw new ArgumentException();
			}
			this.WriteCustomAttributeValue(typeDefinition.GetEnumUnderlyingType(), value);
		}
		private void WriteCustomAttributeFieldOrPropType(TypeReference type)
		{
			if (type.IsArray)
			{
				ArrayType arrayType = (ArrayType)type;
				this.WriteElementType(ElementType.SzArray);
				this.WriteCustomAttributeFieldOrPropType(arrayType.ElementType);
				return;
			}
			ElementType etype = type.etype;
			ElementType elementType = etype;
			if (elementType != ElementType.None)
			{
				if (elementType == ElementType.Object)
				{
					this.WriteElementType(ElementType.Boxed);
					return;
				}
				this.WriteElementType(etype);
				return;
			}
			else
			{
				if (type.IsTypeOf("System", "Type"))
				{
					this.WriteElementType(ElementType.Type);
					return;
				}
				this.WriteElementType(ElementType.Enum);
				this.WriteTypeReference(type);
				return;
			}
		}
		public void WriteCustomAttributeNamedArguments(CustomAttribute attribute)
		{
			int namedArgumentCount = SignatureWriter.GetNamedArgumentCount(attribute);
			base.WriteUInt16((ushort)namedArgumentCount);
			if (namedArgumentCount == 0)
			{
				return;
			}
			this.WriteICustomAttributeNamedArguments(attribute);
		}
		private static int GetNamedArgumentCount(ICustomAttribute attribute)
		{
			int num = 0;
			if (attribute.HasFields)
			{
				num += attribute.Fields.Count;
			}
			if (attribute.HasProperties)
			{
				num += attribute.Properties.Count;
			}
			return num;
		}
		private void WriteICustomAttributeNamedArguments(ICustomAttribute attribute)
		{
			if (attribute.HasFields)
			{
				this.WriteCustomAttributeNamedArguments(83, attribute.Fields);
			}
			if (attribute.HasProperties)
			{
				this.WriteCustomAttributeNamedArguments(84, attribute.Properties);
			}
		}
		private void WriteCustomAttributeNamedArguments(byte kind, Collection<CustomAttributeNamedArgument> named_arguments)
		{
			for (int i = 0; i < named_arguments.Count; i++)
			{
				this.WriteCustomAttributeNamedArgument(kind, named_arguments[i]);
			}
		}
		private void WriteCustomAttributeNamedArgument(byte kind, CustomAttributeNamedArgument named_argument)
		{
			CustomAttributeArgument argument = named_argument.Argument;
			base.WriteByte(kind);
			this.WriteCustomAttributeFieldOrPropType(argument.Type);
			this.WriteUTF8String(named_argument.Name);
			this.WriteCustomAttributeFixedArgument(argument.Type, argument);
		}
		private void WriteSecurityAttribute(SecurityAttribute attribute)
		{
			this.WriteTypeReference(attribute.AttributeType);
			int namedArgumentCount = SignatureWriter.GetNamedArgumentCount(attribute);
			if (namedArgumentCount == 0)
			{
				base.WriteCompressedUInt32(1u);
				base.WriteCompressedUInt32(0u);
				return;
			}
			SignatureWriter signatureWriter = new SignatureWriter(this.metadata);
			signatureWriter.WriteCompressedUInt32((uint)namedArgumentCount);
			signatureWriter.WriteICustomAttributeNamedArguments(attribute);
			base.WriteCompressedUInt32((uint)signatureWriter.length);
			base.WriteBytes(signatureWriter);
		}
		public void WriteSecurityDeclaration(SecurityDeclaration declaration)
		{
			base.WriteByte(46);
			Collection<SecurityAttribute> security_attributes = declaration.security_attributes;
			if (security_attributes == null)
			{
				throw new NotSupportedException();
			}
			base.WriteCompressedUInt32((uint)security_attributes.Count);
			for (int i = 0; i < security_attributes.Count; i++)
			{
				this.WriteSecurityAttribute(security_attributes[i]);
			}
		}
		public void WriteXmlSecurityDeclaration(SecurityDeclaration declaration)
		{
			string xmlSecurityDeclaration = SignatureWriter.GetXmlSecurityDeclaration(declaration);
			if (xmlSecurityDeclaration == null)
			{
				throw new NotSupportedException();
			}
			base.WriteBytes(Encoding.Unicode.GetBytes(xmlSecurityDeclaration));
		}
		private static string GetXmlSecurityDeclaration(SecurityDeclaration declaration)
		{
			if (declaration.security_attributes == null || declaration.security_attributes.Count != 1)
			{
				return null;
			}
			SecurityAttribute securityAttribute = declaration.security_attributes[0];
			if (!securityAttribute.AttributeType.IsTypeOf("System.Security.Permissions", "PermissionSetAttribute"))
			{
				return null;
			}
			if (securityAttribute.properties == null || securityAttribute.properties.Count != 1)
			{
				return null;
			}
			CustomAttributeNamedArgument customAttributeNamedArgument = securityAttribute.properties[0];
			if (customAttributeNamedArgument.Name != "XML")
			{
				return null;
			}
			return (string)customAttributeNamedArgument.Argument.Value;
		}
		private void WriteTypeReference(TypeReference type)
		{
			this.WriteUTF8String(TypeParser.ToParseable(type));
		}
		public void WriteMarshalInfo(MarshalInfo marshal_info)
		{
			this.WriteNativeType(marshal_info.native);
			NativeType native = marshal_info.native;
			if (native == NativeType.FixedSysString)
			{
				FixedSysStringMarshalInfo fixedSysStringMarshalInfo = (FixedSysStringMarshalInfo)marshal_info;
				if (fixedSysStringMarshalInfo.size > -1)
				{
					base.WriteCompressedUInt32((uint)fixedSysStringMarshalInfo.size);
				}
				return;
			}
			switch (native)
			{
			case NativeType.SafeArray:
			{
				SafeArrayMarshalInfo safeArrayMarshalInfo = (SafeArrayMarshalInfo)marshal_info;
				if (safeArrayMarshalInfo.element_type != VariantType.None)
				{
					this.WriteVariantType(safeArrayMarshalInfo.element_type);
				}
				return;
			}
			case NativeType.FixedArray:
			{
				FixedArrayMarshalInfo fixedArrayMarshalInfo = (FixedArrayMarshalInfo)marshal_info;
				if (fixedArrayMarshalInfo.size > -1)
				{
					base.WriteCompressedUInt32((uint)fixedArrayMarshalInfo.size);
				}
				if (fixedArrayMarshalInfo.element_type != NativeType.None)
				{
					this.WriteNativeType(fixedArrayMarshalInfo.element_type);
				}
				return;
			}
			default:
				switch (native)
				{
				case NativeType.Array:
				{
					ArrayMarshalInfo arrayMarshalInfo = (ArrayMarshalInfo)marshal_info;
					if (arrayMarshalInfo.element_type != NativeType.None)
					{
						this.WriteNativeType(arrayMarshalInfo.element_type);
					}
					if (arrayMarshalInfo.size_parameter_index > -1)
					{
						base.WriteCompressedUInt32((uint)arrayMarshalInfo.size_parameter_index);
					}
					if (arrayMarshalInfo.size > -1)
					{
						base.WriteCompressedUInt32((uint)arrayMarshalInfo.size);
					}
					if (arrayMarshalInfo.size_parameter_multiplier > -1)
					{
						base.WriteCompressedUInt32((uint)arrayMarshalInfo.size_parameter_multiplier);
					}
					return;
				}
				case NativeType.LPStruct:
					break;
				case NativeType.CustomMarshaler:
				{
					CustomMarshalInfo customMarshalInfo = (CustomMarshalInfo)marshal_info;
					this.WriteUTF8String((customMarshalInfo.guid != Guid.Empty) ? customMarshalInfo.guid.ToString() : string.Empty);
					this.WriteUTF8String(customMarshalInfo.unmanaged_type);
					this.WriteTypeReference(customMarshalInfo.managed_type);
					this.WriteUTF8String(customMarshalInfo.cookie);
					break;
				}
				default:
					return;
				}
				return;
			}
		}
		private void WriteNativeType(NativeType native)
		{
			base.WriteByte((byte)native);
		}
		private void WriteVariantType(VariantType variant)
		{
			base.WriteByte((byte)variant);
		}
	}
}
