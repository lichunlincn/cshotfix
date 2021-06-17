using System;
namespace Editor_Mono.Cecil
{
	public enum MetadataType : byte
	{
		Void = 1,
		Boolean,
		Char,
		SByte,
		Byte,
		Int16,
		UInt16,
		Int32,
		UInt32,
		Int64,
		UInt64,
		Single,
		Double,
		String,
		Pointer,
		ByReference,
		ValueType,
		Class,
		Var,
		Array,
		GenericInstance,
		TypedByReference,
		IntPtr = 24,
		UIntPtr,
		FunctionPointer = 27,
		Object,
		MVar = 30,
		RequiredModifier,
		OptionalModifier,
		Sentinel = 65,
		Pinned = 69
	}
}
