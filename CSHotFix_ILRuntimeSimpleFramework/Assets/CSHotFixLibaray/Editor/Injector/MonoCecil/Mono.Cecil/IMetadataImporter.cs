using System;
namespace Editor_Mono.Cecil
{
	public interface IMetadataImporter
	{
		TypeReference ImportReference(TypeReference type, IGenericParameterProvider context);
		FieldReference ImportReference(FieldReference field, IGenericParameterProvider context);
		MethodReference ImportReference(MethodReference method, IGenericParameterProvider context);
	}
}
