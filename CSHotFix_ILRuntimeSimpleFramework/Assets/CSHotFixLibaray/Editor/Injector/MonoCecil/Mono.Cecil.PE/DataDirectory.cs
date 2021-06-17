using System;
namespace Editor_Mono.Cecil.PE
{
	internal struct DataDirectory
	{
		public readonly uint VirtualAddress;
		public readonly uint Size;
		public bool IsZero
		{
			get
			{
				return this.VirtualAddress == 0u && this.Size == 0u;
			}
		}
		public DataDirectory(uint rva, uint size)
		{
			this.VirtualAddress = rva;
			this.Size = size;
		}
	}
}
