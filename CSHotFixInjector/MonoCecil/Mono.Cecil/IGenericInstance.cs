using Mono.Collections.Generic;
using System;
namespace Mono.Cecil
{
	public interface IGenericInstance : IMetadataTokenProvider
	{
		bool HasGenericArguments
		{
			get;
		}
		Collection<TypeReference> GenericArguments
		{
			get;
		}
	}
}
