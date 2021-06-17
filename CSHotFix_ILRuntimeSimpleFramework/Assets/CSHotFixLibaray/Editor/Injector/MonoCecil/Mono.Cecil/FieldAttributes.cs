using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum FieldAttributes : ushort
	{
		FieldAccessMask = 7,
		CompilerControlled = 0,
		Private = 1,
		FamANDAssem = 2,
		Assembly = 3,
		Family = 4,
		FamORAssem = 5,
		Public = 6,
		Static = 16,
		InitOnly = 32,
		Literal = 64,
		NotSerialized = 128,
		SpecialName = 512,
		PInvokeImpl = 8192,
		RTSpecialName = 1024,
		HasFieldMarshal = 4096,
		HasDefault = 32768,
		HasFieldRVA = 256
	}
}
