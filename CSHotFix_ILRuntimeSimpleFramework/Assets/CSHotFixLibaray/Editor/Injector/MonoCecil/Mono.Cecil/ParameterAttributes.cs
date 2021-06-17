using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum ParameterAttributes : ushort
	{
		None = 0,
		In = 1,
		Out = 2,
		Lcid = 4,
		Retval = 8,
		Optional = 16,
		HasDefault = 4096,
		HasFieldMarshal = 8192,
		Unused = 53216
	}
}
