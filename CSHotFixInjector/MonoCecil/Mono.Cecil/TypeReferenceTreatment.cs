using System;
namespace Mono.Cecil
{
	internal enum TypeReferenceTreatment
	{
		None,
		SystemDelegate,
		SystemAttribute,
		UseProjectionInfo
	}
}
