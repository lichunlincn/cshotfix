using System;
namespace Mono.Cecil.Cil
{
	public enum ExceptionHandlerType
	{
		Catch,
		Filter,
		Finally,
		Fault = 4
	}
}
