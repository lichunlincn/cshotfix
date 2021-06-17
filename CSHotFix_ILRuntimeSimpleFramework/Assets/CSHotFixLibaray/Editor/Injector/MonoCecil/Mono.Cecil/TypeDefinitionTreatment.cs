using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	internal enum TypeDefinitionTreatment
	{
		None = 0,
		KindMask = 15,
		NormalType = 1,
		NormalAttribute = 2,
		UnmangleWindowsRuntimeName = 3,
		PrefixWindowsRuntimeName = 4,
		RedirectToClrType = 5,
		RedirectToClrAttribute = 6,
		Abstract = 16,
		Internal = 32
	}
}
