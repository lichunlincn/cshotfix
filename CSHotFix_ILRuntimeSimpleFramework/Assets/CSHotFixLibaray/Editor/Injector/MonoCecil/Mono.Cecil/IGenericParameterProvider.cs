using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public interface IGenericParameterProvider : IMetadataTokenProvider
	{
		bool HasGenericParameters
		{
			get;
		}
		bool IsDefinition
		{
			get;
		}
		ModuleDefinition Module
		{
			get;
		}
		Collection<GenericParameter> GenericParameters
		{
			get;
		}
		GenericParameterType GenericParameterType
		{
			get;
		}
	}
}
