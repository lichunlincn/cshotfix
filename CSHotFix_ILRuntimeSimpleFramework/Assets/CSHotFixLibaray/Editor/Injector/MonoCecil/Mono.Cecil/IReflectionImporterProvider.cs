using System;
namespace Editor_Mono.Cecil
{
	public interface IReflectionImporterProvider
	{
		IReflectionImporter GetReflectionImporter(ModuleDefinition module);
	}
}
