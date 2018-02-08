using System;
namespace Mono.Cecil
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
