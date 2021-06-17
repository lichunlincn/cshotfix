using System;
namespace Editor_Mono.Cecil.Cil
{
	public interface ISymbolWriter : IDisposable
	{
		bool GetDebugHeader(out ImageDebugDirectory directory, out byte[] header);
		void Write(MethodBody body);
		void Write(MethodSymbols symbols);
	}
}
