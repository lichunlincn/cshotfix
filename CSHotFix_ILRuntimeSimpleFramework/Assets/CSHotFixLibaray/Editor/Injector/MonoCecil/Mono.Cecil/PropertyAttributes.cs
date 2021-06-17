using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum PropertyAttributes : ushort
	{
		None = 0,
		SpecialName = 512,
		RTSpecialName = 1024,
		HasDefault = 4096,
		Unused = 59903
	}
}
