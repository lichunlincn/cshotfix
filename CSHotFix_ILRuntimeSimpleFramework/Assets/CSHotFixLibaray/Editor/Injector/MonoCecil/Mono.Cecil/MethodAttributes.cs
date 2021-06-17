using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum MethodAttributes : ushort
	{
		MemberAccessMask = 7,
		CompilerControlled = 0,
		Private = 1,
		FamANDAssem = 2,
		Assembly = 3,
		Family = 4,
		FamORAssem = 5,
		Public = 6,
		Static = 16,
		Final = 32,
		Virtual = 64,
		HideBySig = 128,
		VtableLayoutMask = 256,
		ReuseSlot = 0,
		NewSlot = 256,
		CheckAccessOnOverride = 512,
		Abstract = 1024,
		SpecialName = 2048,
		PInvokeImpl = 8192,
		UnmanagedExport = 8,
		RTSpecialName = 4096,
		HasSecurity = 16384,
		RequireSecObject = 32768
	}
}
