using System;
namespace Mono.Cecil
{
	public interface IReflectionImporterProvider
	{
		IReflectionImporter GetReflectionImporter(ModuleDefinition module);
	}
}
