using System;
namespace Mono.Cecil
{
	[Flags]
	public enum ModuleAttributes
	{
		ILOnly = 1,
		Required32Bit = 2,
		StrongNameSigned = 8,
		Preferred32Bit = 131072
	}
}
