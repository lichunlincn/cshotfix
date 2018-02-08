using Mono.Collections.Generic;
using System;
namespace Mono.Cecil
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
