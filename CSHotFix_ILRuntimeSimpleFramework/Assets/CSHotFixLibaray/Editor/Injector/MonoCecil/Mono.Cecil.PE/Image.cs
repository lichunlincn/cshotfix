using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.Metadata;
using System;
namespace Editor_Mono.Cecil.PE
{
	internal sealed class Image
	{
		public ModuleKind Kind;
		public string RuntimeVersion;
		public TargetArchitecture Architecture;
		public ModuleCharacteristics Characteristics;
		public string FileName;
		public Section[] Sections;
		public Section MetadataSection;
		public uint EntryPointToken;
		public ModuleAttributes Attributes;
		public DataDirectory Debug;
		public DataDirectory Resources;
		public DataDirectory StrongName;
		public StringHeap StringHeap;
		public BlobHeap BlobHeap;
		public UserStringHeap UserStringHeap;
		public GuidHeap GuidHeap;
		public TableHeap TableHeap;
		private readonly int[] coded_index_sizes = new int[13];
		private readonly Func<Table, int> counter;
		public Image()
		{
			this.counter = new Func<Table, int>(this.GetTableLength);
		}
		public bool HasTable(Table table)
		{
			return this.GetTableLength(table) > 0;
		}
		public int GetTableLength(Table table)
		{
			return (int)this.TableHeap[table].Length;
		}
		public int GetTableIndexSize(Table table)
		{
			if (this.GetTableLength(table) >= 65536)
			{
				return 4;
			}
			return 2;
		}
		public int GetCodedIndexSize(CodedIndex coded_index)
		{
			int num = this.coded_index_sizes[(int)coded_index];
			if (num != 0)
			{
				return num;
			}
			return this.coded_index_sizes[(int)coded_index] = coded_index.GetSize(this.counter);
		}
		public uint ResolveVirtualAddress(uint rva)
		{
			Section sectionAtVirtualAddress = this.GetSectionAtVirtualAddress(rva);
			if (sectionAtVirtualAddress == null)
			{
				throw new ArgumentOutOfRangeException();
			}
			return this.ResolveVirtualAddressInSection(rva, sectionAtVirtualAddress);
		}
		public uint ResolveVirtualAddressInSection(uint rva, Section section)
		{
			return rva + section.PointerToRawData - section.VirtualAddress;
		}
		public Section GetSection(string name)
		{
			Section[] sections = this.Sections;
			for (int i = 0; i < sections.Length; i++)
			{
				Section section = sections[i];
				if (section.Name == name)
				{
					return section;
				}
			}
			return null;
		}
		public Section GetSectionAtVirtualAddress(uint rva)
		{
			Section[] sections = this.Sections;
			for (int i = 0; i < sections.Length; i++)
			{
				Section section = sections[i];
				if (rva >= section.VirtualAddress && rva < section.VirtualAddress + section.SizeOfRawData)
				{
					return section;
				}
			}
			return null;
		}
		public ImageDebugDirectory GetDebugHeader(out byte[] header)
		{
			Section sectionAtVirtualAddress = this.GetSectionAtVirtualAddress(this.Debug.VirtualAddress);
			ByteBuffer byteBuffer = new ByteBuffer(sectionAtVirtualAddress.Data);
			byteBuffer.position = (int)(this.Debug.VirtualAddress - sectionAtVirtualAddress.VirtualAddress);
			ImageDebugDirectory result = new ImageDebugDirectory
			{
				Characteristics = byteBuffer.ReadInt32(),
				TimeDateStamp = byteBuffer.ReadInt32(),
				MajorVersion = byteBuffer.ReadInt16(),
				MinorVersion = byteBuffer.ReadInt16(),
				Type = byteBuffer.ReadInt32(),
				SizeOfData = byteBuffer.ReadInt32(),
				AddressOfRawData = byteBuffer.ReadInt32(),
				PointerToRawData = byteBuffer.ReadInt32()
			};
			if (result.SizeOfData == 0 || result.PointerToRawData == 0)
			{
				header = Empty<byte>.Array;
				return result;
			}
			byteBuffer.position = (int)((long)result.PointerToRawData - (long)((ulong)sectionAtVirtualAddress.PointerToRawData));
			header = new byte[result.SizeOfData];
			Buffer.BlockCopy(byteBuffer.buffer, byteBuffer.position, header, 0, header.Length);
			return result;
		}
	}
}
