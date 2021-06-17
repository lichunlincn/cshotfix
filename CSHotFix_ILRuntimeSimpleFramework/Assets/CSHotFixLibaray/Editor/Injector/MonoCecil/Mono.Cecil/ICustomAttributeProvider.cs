using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public interface ICustomAttributeProvider : IMetadataTokenProvider
	{
		Collection<CustomAttribute> CustomAttributes
		{
			get;
		}
		bool HasCustomAttributes
		{
			get;
		}
	}
}
