using System;
using System.IO;
namespace Mono.Cecil.Cil
{
	public interface ISymbolReaderProvider
	{
		ISymbolReader GetSymbolReader(ModuleDefinition module, string fileName);
		ISymbolReader GetSymbolReader(ModuleDefinition module, Stream symbolStream);
	}
}
