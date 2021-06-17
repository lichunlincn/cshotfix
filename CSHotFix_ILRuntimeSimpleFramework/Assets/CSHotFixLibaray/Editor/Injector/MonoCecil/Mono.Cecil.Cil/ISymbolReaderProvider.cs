using System;
using System.IO;
namespace Editor_Mono.Cecil.Cil
{
	public interface ISymbolReaderProvider
	{
		ISymbolReader GetSymbolReader(ModuleDefinition module, string fileName);
		ISymbolReader GetSymbolReader(ModuleDefinition module, Stream symbolStream);
	}
}
