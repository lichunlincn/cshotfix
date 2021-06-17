using System;
namespace Editor_Mono.Cecil
{
	public interface IMetadataImporterProvider
	{
		IMetadataImporter GetMetadataImporter(ModuleDefinition module);
	}
}
