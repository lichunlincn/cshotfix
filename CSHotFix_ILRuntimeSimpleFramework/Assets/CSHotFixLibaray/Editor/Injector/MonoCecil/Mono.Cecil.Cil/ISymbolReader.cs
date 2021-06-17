using System;
namespace Editor_Mono.Cecil.Cil
{
	public interface ISymbolReader : IDisposable
	{
		bool ProcessDebugHeader(ImageDebugDirectory directory, byte[] header);
		void Read(MethodBody body, InstructionMapper mapper);
		void Read(MethodSymbols symbols);
	}
}
