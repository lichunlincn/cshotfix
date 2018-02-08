using System;
namespace Mono.Cecil
{
	public interface IMetadataImporterProvider
	{
		IMetadataImporter GetMetadataImporter(ModuleDefinition module);
	}
}
