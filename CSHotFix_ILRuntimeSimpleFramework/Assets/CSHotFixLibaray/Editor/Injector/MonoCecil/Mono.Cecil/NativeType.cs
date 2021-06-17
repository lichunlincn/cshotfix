using System;
namespace Editor_Mono.Cecil
{
	public enum NativeType
	{
		None = 102,
		Boolean = 2,
		I1,
		U1,
		I2,
		U2,
		I4,
		U4,
		I8,
		U8,
		R4,
		R8,
		LPStr = 20,
		Int = 31,
		UInt,
		Func = 38,
		Array = 42,
		Currency = 15,
		BStr = 19,
		LPWStr = 21,
		LPTStr,
		FixedSysString,
		IUnknown = 25,
		IDispatch,
		Struct,
		IntF,
		SafeArray,
		FixedArray,
		ByValStr = 34,
		ANSIBStr,
		TBStr,
		VariantBool,
		ASAny = 40,
		LPStruct = 43,
		CustomMarshaler,
		Error,
		Max = 80
	}
}
