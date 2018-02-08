using System;
namespace Mono.Cecil
{
	[Flags]
	public enum EventAttributes : ushort
	{
		None = 0,
		SpecialName = 512,
		RTSpecialName = 1024
	}
}
