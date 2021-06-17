using System;
namespace Editor_Mono.Cecil.Cil
{
	public struct ImageDebugDirectory
	{
		public int Characteristics;
		public int TimeDateStamp;
		public short MajorVersion;
		public short MinorVersion;
		public int Type;
		public int SizeOfData;
		public int AddressOfRawData;
		public int PointerToRawData;
	}
}
