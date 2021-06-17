using System;
namespace Editor_Mono.Cecil
{
	internal enum TypeReferenceTreatment
	{
		None,
		SystemDelegate,
		SystemAttribute,
		UseProjectionInfo
	}
}
