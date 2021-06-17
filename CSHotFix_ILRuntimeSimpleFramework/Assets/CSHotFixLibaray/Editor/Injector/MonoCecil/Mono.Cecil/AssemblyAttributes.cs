using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum AssemblyAttributes : uint
	{
		PublicKey = 1u,
		SideBySideCompatible = 0u,
		Retargetable = 256u,
		WindowsRuntime = 512u,
		DisableJITCompileOptimizer = 16384u,
		EnableJITCompileTracking = 32768u
	}
}
