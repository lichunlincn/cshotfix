using System;
namespace Editor_Mono.Cecil
{
	internal enum CustomAttributeValueTreatment
	{
		None,
		AllowSingle,
		AllowMultiple,
		VersionAttribute,
		DeprecatedAttribute
	}
}
