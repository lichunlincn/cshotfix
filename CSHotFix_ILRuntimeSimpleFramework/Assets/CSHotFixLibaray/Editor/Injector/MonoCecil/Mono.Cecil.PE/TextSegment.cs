using System;
namespace Editor_Mono.Cecil.PE
{
	internal enum TextSegment
	{
		ImportAddressTable,
		CLIHeader,
		Code,
		Resources,
		Data,
		StrongNameSignature,
		MetadataHeader,
		TableHeap,
		StringHeap,
		UserStringHeap,
		GuidHeap,
		BlobHeap,
		DebugDirectory,
		ImportDirectory,
		ImportHintNameTable,
		StartupStub
	}
}
