using System;
using System.IO;
namespace Editor_Mono.Cecil.PE
{
	internal class BinaryStreamReader : BinaryReader
	{
		public BinaryStreamReader(Stream stream) : base(stream)
		{
		}
		protected void Advance(int bytes)
		{
			this.BaseStream.Seek((long)bytes, SeekOrigin.Current);
		}
		protected DataDirectory ReadDataDirectory()
		{
			return new DataDirectory(this.ReadUInt32(), this.ReadUInt32());
		}
	}
}
