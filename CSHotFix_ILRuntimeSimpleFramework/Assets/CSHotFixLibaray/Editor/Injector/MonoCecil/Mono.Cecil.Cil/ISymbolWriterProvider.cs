using System;
using System.IO;
namespace Editor_Mono.Cecil.Cil
{
	public interface ISymbolWriterProvider
	{
		ISymbolWriter GetSymbolWriter(ModuleDefinition module, string fileName);
		ISymbolWriter GetSymbolWriter(ModuleDefinition module, Stream symbolStream);
	}
}
