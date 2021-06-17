using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
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
