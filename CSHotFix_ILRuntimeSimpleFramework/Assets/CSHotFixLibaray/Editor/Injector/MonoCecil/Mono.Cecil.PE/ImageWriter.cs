using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.Metadata;
using System;
using System.IO;
namespace Editor_Mono.Cecil.PE
{
	internal sealed class ImageWriter : BinaryStreamWriter
	{
		private const uint pe_header_size = 152u;
		private const uint section_header_size = 40u;
		private const uint file_alignment = 512u;
		private const uint section_alignment = 8192u;
		private const ulong image_base = 4194304uL;
		internal const uint text_rva = 8192u;
		private readonly ModuleDefinition module;
		private readonly MetadataBuilder metadata;
		private readonly TextMap text_map;
		private ImageDebugDirectory debug_directory;
		private byte[] debug_data;
		private ByteBuffer win32_resources;
		private readonly bool pe64;
		private readonly bool has_reloc;
		private readonly uint time_stamp;
		internal Section text;
		internal Section rsrc;
		internal Section reloc;
		private ushort sections;
		private ImageWriter(ModuleDefinition module, MetadataBuilder metadata, Stream stream) : base(stream)
		{
			this.module = module;
			this.metadata = metadata;
			this.pe64 = (module.Architecture == TargetArchitecture.AMD64 || module.Architecture == TargetArchitecture.IA64);
			this.has_reloc = (module.Architecture == TargetArchitecture.I386);
			this.GetDebugHeader();
			this.GetWin32Resources();
			this.text_map = this.BuildTextMap();
            this.sections = (ushort)(has_reloc ? 2 : 1); // text + reloc?
            this.time_stamp = (uint)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}
		private void GetDebugHeader()
		{
			ISymbolWriter symbol_writer = this.metadata.symbol_writer;
			if (symbol_writer == null)
			{
				return;
			}
			if (!symbol_writer.GetDebugHeader(out this.debug_directory, out this.debug_data))
			{
				this.debug_data = Empty<byte>.Array;
			}
		}
		private void GetWin32Resources()
		{
			Section imageResourceSection = this.GetImageResourceSection();
			if (imageResourceSection == null)
			{
				return;
			}
			byte[] array = new byte[imageResourceSection.Data.Length];
			Buffer.BlockCopy(imageResourceSection.Data, 0, array, 0, imageResourceSection.Data.Length);
			this.win32_resources = new ByteBuffer(array);
		}
		private Section GetImageResourceSection()
		{
			if (!this.module.HasImage)
			{
				return null;
			}
			return this.module.Image.GetSection(".rsrc");
		}
		public static ImageWriter CreateWriter(ModuleDefinition module, MetadataBuilder metadata, Stream stream)
		{
			ImageWriter imageWriter = new ImageWriter(module, metadata, stream);
			imageWriter.BuildSections();
			return imageWriter;
		}
		private void BuildSections()
		{
			bool flag = this.win32_resources != null;
			if (flag)
			{
				this.sections += 1;
			}
			this.text = this.CreateSection(".text", this.text_map.GetLength(), null);
			Section previous = this.text;
			if (flag)
			{
				this.rsrc = this.CreateSection(".rsrc", (uint)this.win32_resources.length, previous);
				this.PatchWin32Resources(this.win32_resources);
				previous = this.rsrc;
			}
			if (this.has_reloc)
			{
				this.reloc = this.CreateSection(".reloc", 12u, previous);
			}
		}
		private Section CreateSection(string name, uint size, Section previous)
		{
			return new Section
			{
				Name = name,
				VirtualAddress = (previous != null) ? (previous.VirtualAddress + ImageWriter.Align(previous.VirtualSize, 8192u)) : 8192u,
				VirtualSize = size,
				PointerToRawData = (previous != null) ? (previous.PointerToRawData + previous.SizeOfRawData) : ImageWriter.Align(this.GetHeaderSize(), 512u),
				SizeOfRawData = ImageWriter.Align(size, 512u)
			};
		}
		private static uint Align(uint value, uint align)
		{
			align -= 1u;
			return value + align & ~align;
		}
		private void WriteDOSHeader()
		{
			this.Write(new byte[]
			{
				77,
				90,
				144,
				0,
				3,
				0,
				0,
				0,
				4,
				0,
				0,
				0,
				255,
				255,
				0,
				0,
				184,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				64,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				128,
				0,
				0,
				0,
				14,
				31,
				186,
				14,
				0,
				180,
				9,
				205,
				33,
				184,
				1,
				76,
				205,
				33,
				84,
				104,
				105,
				115,
				32,
				112,
				114,
				111,
				103,
				114,
				97,
				109,
				32,
				99,
				97,
				110,
				110,
				111,
				116,
				32,
				98,
				101,
				32,
				114,
				117,
				110,
				32,
				105,
				110,
				32,
				68,
				79,
				83,
				32,
				109,
				111,
				100,
				101,
				46,
				13,
				13,
				10,
				36,
				0,
				0,
				0,
				0,
				0,
				0,
				0
			});
		}
		private ushort SizeOfOptionalHeader()
		{
            return (ushort)(!pe64 ? 0xe0 : 0xf0);
        }
		private void WritePEFileHeader()
		{
			base.WriteUInt32(17744u);
			base.WriteUInt16(this.GetMachine());
			base.WriteUInt16(this.sections);
			base.WriteUInt32(this.time_stamp);
			base.WriteUInt32(0u);
			base.WriteUInt32(0u);
			base.WriteUInt16(this.SizeOfOptionalHeader());
			ushort num = (ushort)(2 | ((!this.pe64) ? 256 : 32));
			if (this.module.Kind == ModuleKind.Dll || this.module.Kind == ModuleKind.NetModule)
			{
				num |= 8192;
			}
			base.WriteUInt16(num);
		}
		private ushort GetMachine()
		{
			switch (this.module.Architecture)
			{
			case TargetArchitecture.I386:
				return 332;
			case TargetArchitecture.AMD64:
				return 34404;
			case TargetArchitecture.IA64:
				return 512;
			case TargetArchitecture.ARMv7:
				return 452;
			default:
				throw new NotSupportedException();
			}
		}
		private Section LastSection()
		{
			if (this.reloc != null)
			{
				return this.reloc;
			}
			if (this.rsrc != null)
			{
				return this.rsrc;
			}
			return this.text;
		}
		private void WriteOptionalHeaders()
		{
            WriteUInt16((ushort)(!pe64 ? 0x10b : 0x20b)); // Magic
            base.WriteByte(8);
			base.WriteByte(0);
			base.WriteUInt32(this.text.SizeOfRawData);
			base.WriteUInt32(((this.reloc != null) ? this.reloc.SizeOfRawData : 0u) + ((this.rsrc != null) ? this.rsrc.SizeOfRawData : 0u));
			base.WriteUInt32(0u);
			Range range = this.text_map.GetRange(TextSegment.StartupStub);
			base.WriteUInt32((range.Length > 0u) ? range.Start : 0u);
			base.WriteUInt32(8192u);
			if (!this.pe64)
			{
				base.WriteUInt32(0u);
				base.WriteUInt32(4194304u);
			}
			else
			{
				base.WriteUInt64(4194304uL);
			}
			base.WriteUInt32(8192u);
			base.WriteUInt32(512u);
			base.WriteUInt16(4);
			base.WriteUInt16(0);
			base.WriteUInt16(0);
			base.WriteUInt16(0);
			base.WriteUInt16(4);
			base.WriteUInt16(0);
			base.WriteUInt32(0u);
			Section section = this.LastSection();
			base.WriteUInt32(section.VirtualAddress + ImageWriter.Align(section.VirtualSize, 8192u));
			base.WriteUInt32(this.text.PointerToRawData);
			base.WriteUInt32(0u);
			base.WriteUInt16(this.GetSubSystem());
			base.WriteUInt16((ushort)this.module.Characteristics);
			if (!this.pe64)
			{
				base.WriteUInt32(1048576u);
				base.WriteUInt32(4096u);
				base.WriteUInt32(1048576u);
				base.WriteUInt32(4096u);
			}
			else
			{
				base.WriteUInt64(1048576uL);
				base.WriteUInt64(4096uL);
				base.WriteUInt64(1048576uL);
				base.WriteUInt64(4096uL);
			}
			base.WriteUInt32(0u);
			base.WriteUInt32(16u);
			this.WriteZeroDataDirectory();
			base.WriteDataDirectory(this.text_map.GetDataDirectory(TextSegment.ImportDirectory));
			if (this.rsrc != null)
			{
				base.WriteUInt32(this.rsrc.VirtualAddress);
				base.WriteUInt32(this.rsrc.VirtualSize);
			}
			else
			{
				this.WriteZeroDataDirectory();
			}
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			base.WriteUInt32((this.reloc != null) ? this.reloc.VirtualAddress : 0u);
			base.WriteUInt32((this.reloc != null) ? this.reloc.VirtualSize : 0u);
			if (this.text_map.GetLength(TextSegment.DebugDirectory) > 0)
			{
				base.WriteUInt32(this.text_map.GetRVA(TextSegment.DebugDirectory));
				base.WriteUInt32(28u);
			}
			else
			{
				this.WriteZeroDataDirectory();
			}
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			base.WriteDataDirectory(this.text_map.GetDataDirectory(TextSegment.ImportAddressTable));
			this.WriteZeroDataDirectory();
			base.WriteDataDirectory(this.text_map.GetDataDirectory(TextSegment.CLIHeader));
			this.WriteZeroDataDirectory();
		}
		private void WriteZeroDataDirectory()
		{
			base.WriteUInt32(0u);
			base.WriteUInt32(0u);
		}
		private ushort GetSubSystem()
		{
			switch (this.module.Kind)
			{
			case ModuleKind.Dll:
			case ModuleKind.Console:
			case ModuleKind.NetModule:
				return 3;
			case ModuleKind.Windows:
				return 2;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}
		private void WriteSectionHeaders()
		{
			this.WriteSection(this.text, 1610612768u);
			if (this.rsrc != null)
			{
				this.WriteSection(this.rsrc, 1073741888u);
			}
			if (this.reloc != null)
			{
				this.WriteSection(this.reloc, 1107296320u);
			}
		}
		private void WriteSection(Section section, uint characteristics)
		{
			byte[] array = new byte[8];
			string name = section.Name;
			for (int i = 0; i < name.Length; i++)
			{
				array[i] = (byte)name[i];
			}
			base.WriteBytes(array);
			base.WriteUInt32(section.VirtualSize);
			base.WriteUInt32(section.VirtualAddress);
			base.WriteUInt32(section.SizeOfRawData);
			base.WriteUInt32(section.PointerToRawData);
			base.WriteUInt32(0u);
			base.WriteUInt32(0u);
			base.WriteUInt16(0);
			base.WriteUInt16(0);
			base.WriteUInt32(characteristics);
		}
		private void MoveTo(uint pointer)
		{
			this.BaseStream.Seek((long)((ulong)pointer), SeekOrigin.Begin);
		}
		private void MoveToRVA(Section section, uint rva)
		{
			this.BaseStream.Seek((long)((ulong)(section.PointerToRawData + rva - section.VirtualAddress)), SeekOrigin.Begin);
		}
		private void MoveToRVA(TextSegment segment)
		{
			this.MoveToRVA(this.text, this.text_map.GetRVA(segment));
		}
		private void WriteRVA(uint rva)
		{
			if (!this.pe64)
			{
				base.WriteUInt32(rva);
				return;
			}
			base.WriteUInt64((ulong)rva);
		}
		private void PrepareSection(Section section)
		{
			this.MoveTo(section.PointerToRawData);
			if (section.SizeOfRawData <= 4096u)
			{
				this.Write(new byte[section.SizeOfRawData]);
				this.MoveTo(section.PointerToRawData);
				return;
			}
			int num = 0;
			byte[] buffer = new byte[4096];
			while ((long)num != (long)((ulong)section.SizeOfRawData))
			{
				int num2 = System.Math.Min((int)(section.SizeOfRawData - (uint)num), 4096);
				this.Write(buffer, 0, num2);
				num += num2;
			}
			this.MoveTo(section.PointerToRawData);
		}
		private void WriteText()
		{
			this.PrepareSection(this.text);
			if (this.has_reloc)
			{
				this.WriteRVA(this.text_map.GetRVA(TextSegment.ImportHintNameTable));
				this.WriteRVA(0u);
			}
			base.WriteUInt32(72u);
			base.WriteUInt16(2);
            WriteUInt16((ushort)((module.Runtime <= TargetRuntime.Net_1_1) ? 0 : 5));
            base.WriteUInt32(this.text_map.GetRVA(TextSegment.MetadataHeader));
			base.WriteUInt32(this.GetMetadataLength());
			base.WriteUInt32((uint)this.module.Attributes);
			base.WriteUInt32(this.metadata.entry_point.ToUInt32());
			base.WriteDataDirectory(this.text_map.GetDataDirectory(TextSegment.Resources));
			base.WriteDataDirectory(this.text_map.GetDataDirectory(TextSegment.StrongNameSignature));
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.WriteZeroDataDirectory();
			this.MoveToRVA(TextSegment.Code);
			base.WriteBuffer(this.metadata.code);
			this.MoveToRVA(TextSegment.Resources);
			base.WriteBuffer(this.metadata.resources);
			if (this.metadata.data.length > 0)
			{
				this.MoveToRVA(TextSegment.Data);
				base.WriteBuffer(this.metadata.data);
			}
			this.MoveToRVA(TextSegment.MetadataHeader);
			this.WriteMetadataHeader();
			this.WriteMetadata();
			if (this.text_map.GetLength(TextSegment.DebugDirectory) > 0)
			{
				this.MoveToRVA(TextSegment.DebugDirectory);
				this.WriteDebugDirectory();
			}
			if (!this.has_reloc)
			{
				return;
			}
			this.MoveToRVA(TextSegment.ImportDirectory);
			this.WriteImportDirectory();
			this.MoveToRVA(TextSegment.StartupStub);
			this.WriteStartupStub();
		}
		private uint GetMetadataLength()
		{
			return this.text_map.GetRVA(TextSegment.DebugDirectory) - this.text_map.GetRVA(TextSegment.MetadataHeader);
		}
		private void WriteMetadataHeader()
		{
			base.WriteUInt32(1112167234u);
			base.WriteUInt16(1);
			base.WriteUInt16(1);
			base.WriteUInt32(0u);
			byte[] zeroTerminatedString = ImageWriter.GetZeroTerminatedString(this.module.runtime_version);
			base.WriteUInt32((uint)zeroTerminatedString.Length);
			base.WriteBytes(zeroTerminatedString);
			base.WriteUInt16(0);
			base.WriteUInt16(this.GetStreamCount());
			uint num = this.text_map.GetRVA(TextSegment.TableHeap) - this.text_map.GetRVA(TextSegment.MetadataHeader);
			this.WriteStreamHeader(ref num, TextSegment.TableHeap, "#~");
			this.WriteStreamHeader(ref num, TextSegment.StringHeap, "#Strings");
			this.WriteStreamHeader(ref num, TextSegment.UserStringHeap, "#US");
			this.WriteStreamHeader(ref num, TextSegment.GuidHeap, "#GUID");
			this.WriteStreamHeader(ref num, TextSegment.BlobHeap, "#Blob");
		}
		private ushort GetStreamCount()
		{
			return (ushort)(2 + (this.metadata.user_string_heap.IsEmpty ? 0 : 1) + 1 + (this.metadata.blob_heap.IsEmpty ? 0 : 1));
		}
		private void WriteStreamHeader(ref uint offset, TextSegment heap, string name)
		{
			uint length = (uint)this.text_map.GetLength(heap);
			if (length == 0u)
			{
				return;
			}
			base.WriteUInt32(offset);
			base.WriteUInt32(length);
			base.WriteBytes(ImageWriter.GetZeroTerminatedString(name));
			offset += length;
		}
		private static int GetZeroTerminatedStringLength(string @string)
		{
			return @string.Length + 1 + 3 & -4;
		}
		private static byte[] GetZeroTerminatedString(string @string)
		{
			return ImageWriter.GetString(@string, ImageWriter.GetZeroTerminatedStringLength(@string));
		}
		private static byte[] GetSimpleString(string @string)
		{
			return ImageWriter.GetString(@string, @string.Length);
		}
		private static byte[] GetString(string @string, int length)
		{
			byte[] array = new byte[length];
			for (int i = 0; i < @string.Length; i++)
			{
				array[i] = (byte)@string[i];
			}
			return array;
		}
		private void WriteMetadata()
		{
			this.WriteHeap(TextSegment.TableHeap, this.metadata.table_heap);
			this.WriteHeap(TextSegment.StringHeap, this.metadata.string_heap);
			this.WriteHeap(TextSegment.UserStringHeap, this.metadata.user_string_heap);
			this.WriteGuidHeap();
			this.WriteHeap(TextSegment.BlobHeap, this.metadata.blob_heap);
		}
		private void WriteHeap(TextSegment heap, HeapBuffer buffer)
		{
			if (buffer.IsEmpty)
			{
				return;
			}
			this.MoveToRVA(heap);
			base.WriteBuffer(buffer);
		}
		private void WriteGuidHeap()
		{
			this.MoveToRVA(TextSegment.GuidHeap);
			base.WriteBytes(this.module.Mvid.ToByteArray());
		}
		private void WriteDebugDirectory()
		{
			base.WriteInt32(this.debug_directory.Characteristics);
			base.WriteUInt32(this.time_stamp);
			base.WriteInt16(this.debug_directory.MajorVersion);
			base.WriteInt16(this.debug_directory.MinorVersion);
			base.WriteInt32(this.debug_directory.Type);
			base.WriteInt32(this.debug_directory.SizeOfData);
			base.WriteInt32(this.debug_directory.AddressOfRawData);
			base.WriteInt32((int)this.BaseStream.Position + 4);
			base.WriteBytes(this.debug_data);
		}
		private void WriteImportDirectory()
		{
			base.WriteUInt32(this.text_map.GetRVA(TextSegment.ImportDirectory) + 40u);
			base.WriteUInt32(0u);
			base.WriteUInt32(0u);
			base.WriteUInt32(this.text_map.GetRVA(TextSegment.ImportHintNameTable) + 14u);
			base.WriteUInt32(this.text_map.GetRVA(TextSegment.ImportAddressTable));
			base.Advance(20);
			base.WriteUInt32(this.text_map.GetRVA(TextSegment.ImportHintNameTable));
			this.MoveToRVA(TextSegment.ImportHintNameTable);
			base.WriteUInt16(0);
			base.WriteBytes(this.GetRuntimeMain());
			base.WriteByte(0);
			base.WriteBytes(ImageWriter.GetSimpleString("mscoree.dll"));
			base.WriteUInt16(0);
		}
		private byte[] GetRuntimeMain()
		{
			if (this.module.Kind != ModuleKind.Dll && this.module.Kind != ModuleKind.NetModule)
			{
				return ImageWriter.GetSimpleString("_CorExeMain");
			}
			return ImageWriter.GetSimpleString("_CorDllMain");
		}
		private void WriteStartupStub()
		{
			TargetArchitecture architecture = this.module.Architecture;
			if (architecture == TargetArchitecture.I386)
			{
				base.WriteUInt16(9727);
				base.WriteUInt32(4194304u + this.text_map.GetRVA(TextSegment.ImportAddressTable));
				return;
			}
			throw new NotSupportedException();
		}
		private void WriteRsrc()
		{
			this.PrepareSection(this.rsrc);
			base.WriteBuffer(this.win32_resources);
		}
		private void WriteReloc()
		{
			this.PrepareSection(this.reloc);
			uint num = this.text_map.GetRVA(TextSegment.StartupStub);
			num += ((this.module.Architecture == TargetArchitecture.IA64) ? 32u : 2u);
			uint num2 = num & 4294963200u;
			base.WriteUInt32(num2);
			base.WriteUInt32(12u);
			TargetArchitecture architecture = this.module.Architecture;
			if (architecture == TargetArchitecture.I386)
			{
				base.WriteUInt32(12288u + num - num2);
				return;
			}
			throw new NotSupportedException();
		}
		public void WriteImage()
		{
			this.WriteDOSHeader();
			this.WritePEFileHeader();
			this.WriteOptionalHeaders();
			this.WriteSectionHeaders();
			this.WriteText();
			if (this.rsrc != null)
			{
				this.WriteRsrc();
			}
			if (this.reloc != null)
			{
				this.WriteReloc();
			}
		}
		private TextMap BuildTextMap()
		{
			TextMap textMap = this.metadata.text_map;
			textMap.AddMap(TextSegment.Code, this.metadata.code.length, (!this.pe64) ? 4 : 16);
			textMap.AddMap(TextSegment.Resources, this.metadata.resources.length, 8);
			textMap.AddMap(TextSegment.Data, this.metadata.data.length, 4);
			if (this.metadata.data.length > 0)
			{
				this.metadata.table_heap.FixupData(textMap.GetRVA(TextSegment.Data));
			}
			textMap.AddMap(TextSegment.StrongNameSignature, this.GetStrongNameLength(), 4);
			textMap.AddMap(TextSegment.MetadataHeader, this.GetMetadataHeaderLength(this.module.RuntimeVersion));
			textMap.AddMap(TextSegment.TableHeap, this.metadata.table_heap.length, 4);
			textMap.AddMap(TextSegment.StringHeap, this.metadata.string_heap.length, 4);
			textMap.AddMap(TextSegment.UserStringHeap, this.metadata.user_string_heap.IsEmpty ? 0 : this.metadata.user_string_heap.length, 4);
			textMap.AddMap(TextSegment.GuidHeap, 16);
			textMap.AddMap(TextSegment.BlobHeap, this.metadata.blob_heap.IsEmpty ? 0 : this.metadata.blob_heap.length, 4);
			int length = 0;
			if (!this.debug_data.IsNullOrEmpty<byte>())
			{
				this.debug_directory.AddressOfRawData = (int)(textMap.GetNextRVA(TextSegment.BlobHeap) + 28u);
				length = this.debug_data.Length + 28;
			}
			textMap.AddMap(TextSegment.DebugDirectory, length, 4);
			if (!this.has_reloc)
			{
				uint nextRVA = textMap.GetNextRVA(TextSegment.DebugDirectory);
				textMap.AddMap(TextSegment.ImportDirectory, new Range(nextRVA, 0u));
				textMap.AddMap(TextSegment.ImportHintNameTable, new Range(nextRVA, 0u));
				textMap.AddMap(TextSegment.StartupStub, new Range(nextRVA, 0u));
				return textMap;
			}
			uint nextRVA2 = textMap.GetNextRVA(TextSegment.DebugDirectory);
			uint num = nextRVA2 + 48u;
			num = (num + 15u & 4294967280u);
			uint num2 = num - nextRVA2 + 27u;
			uint num3 = nextRVA2 + num2;
			num3 = ((this.module.Architecture == TargetArchitecture.IA64) ? (num3 + 15u & 4294967280u) : (2u + (num3 + 3u & 4294967292u)));
			textMap.AddMap(TextSegment.ImportDirectory, new Range(nextRVA2, num2));
			textMap.AddMap(TextSegment.ImportHintNameTable, new Range(num, 0u));
			textMap.AddMap(TextSegment.StartupStub, new Range(num3, this.GetStartupStubLength()));
			return textMap;
		}
		private uint GetStartupStubLength()
		{
			TargetArchitecture architecture = this.module.Architecture;
			if (architecture == TargetArchitecture.I386)
			{
				return 6u;
			}
			throw new NotSupportedException();
		}
		private int GetMetadataHeaderLength(string runtimeVersion)
		{
			return 20 + ImageWriter.GetZeroTerminatedStringLength(runtimeVersion) + 12 + 20 + (this.metadata.user_string_heap.IsEmpty ? 0 : 12) + 16 + (this.metadata.blob_heap.IsEmpty ? 0 : 16);
		}
		private int GetStrongNameLength()
		{
			if (this.module.Assembly == null)
			{
				return 0;
			}
			byte[] publicKey = this.module.Assembly.Name.PublicKey;
			if (publicKey.IsNullOrEmpty<byte>())
			{
				return 0;
			}
			int num = publicKey.Length;
			if (num > 32)
			{
				return num - 32;
			}
			return 128;
		}
		public DataDirectory GetStrongNameSignatureDirectory()
		{
			return this.text_map.GetDataDirectory(TextSegment.StrongNameSignature);
		}
		public uint GetHeaderSize()
		{
			return (uint)(152 + this.SizeOfOptionalHeader() + this.sections * 40);
		}
		private void PatchWin32Resources(ByteBuffer resources)
		{
			this.PatchResourceDirectoryTable(resources);
		}
		private void PatchResourceDirectoryTable(ByteBuffer resources)
		{
			resources.Advance(12);
			int num = (int)(resources.ReadUInt16() + resources.ReadUInt16());
			for (int i = 0; i < num; i++)
			{
				this.PatchResourceDirectoryEntry(resources);
			}
		}
		private void PatchResourceDirectoryEntry(ByteBuffer resources)
		{
			resources.Advance(4);
			uint num = resources.ReadUInt32();
			int position = resources.position;
			resources.position = (int)(num & 2147483647u);
			if ((num & 2147483648u) != 0u)
			{
				this.PatchResourceDirectoryTable(resources);
			}
			else
			{
				this.PatchResourceDataEntry(resources);
			}
			resources.position = position;
		}
		private void PatchResourceDataEntry(ByteBuffer resources)
		{
			Section imageResourceSection = this.GetImageResourceSection();
			uint num = resources.ReadUInt32();
			resources.position -= 4;
			resources.WriteUInt32(num - imageResourceSection.VirtualAddress + this.rsrc.VirtualAddress);
		}
	}
}
