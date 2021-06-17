using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum TypeAttributes : uint
	{
		VisibilityMask = 7u,
		NotPublic = 0u,
		Public = 1u,
		NestedPublic = 2u,
		NestedPrivate = 3u,
		NestedFamily = 4u,
		NestedAssembly = 5u,
		NestedFamANDAssem = 6u,
		NestedFamORAssem = 7u,
		LayoutMask = 24u,
		AutoLayout = 0u,
		SequentialLayout = 8u,
		ExplicitLayout = 16u,
		ClassSemanticMask = 32u,
		Class = 0u,
		Interface = 32u,
		Abstract = 128u,
		Sealed = 256u,
		SpecialName = 1024u,
		Import = 4096u,
		Serializable = 8192u,
		WindowsRuntime = 16384u,
		StringFormatMask = 196608u,
		AnsiClass = 0u,
		UnicodeClass = 65536u,
		AutoClass = 131072u,
		BeforeFieldInit = 1048576u,
		RTSpecialName = 2048u,
		HasSecurity = 262144u,
		Forwarder = 2097152u
	}
}
