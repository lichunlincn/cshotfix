using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum PInvokeAttributes : ushort
	{
		NoMangle = 1,
		CharSetMask = 6,
		CharSetNotSpec = 0,
		CharSetAnsi = 2,
		CharSetUnicode = 4,
		CharSetAuto = 6,
		SupportsLastError = 64,
		CallConvMask = 1792,
		CallConvWinapi = 256,
		CallConvCdecl = 512,
		CallConvStdCall = 768,
		CallConvThiscall = 1024,
		CallConvFastcall = 1280,
		BestFitMask = 48,
		BestFitEnabled = 16,
		BestFitDisabled = 32,
		ThrowOnUnmappableCharMask = 12288,
		ThrowOnUnmappableCharEnabled = 4096,
		ThrowOnUnmappableCharDisabled = 8192
	}
}
