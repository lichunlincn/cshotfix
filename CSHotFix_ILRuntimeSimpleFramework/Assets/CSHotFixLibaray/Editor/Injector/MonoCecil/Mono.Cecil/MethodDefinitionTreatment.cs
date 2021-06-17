using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	internal enum MethodDefinitionTreatment
	{
		None = 0,
		Dispose = 1,
		Abstract = 2,
		Private = 4,
		Public = 8,
		Runtime = 16,
		InternalCall = 32
	}
}
