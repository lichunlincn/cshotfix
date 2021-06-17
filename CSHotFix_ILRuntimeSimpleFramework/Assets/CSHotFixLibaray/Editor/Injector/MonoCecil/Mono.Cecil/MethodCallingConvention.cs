using System;
namespace Editor_Mono.Cecil
{
	public enum MethodCallingConvention : byte
	{
		Default,
		C,
		StdCall,
		ThisCall,
		FastCall,
		VarArg,
		Generic = 16
	}
}
