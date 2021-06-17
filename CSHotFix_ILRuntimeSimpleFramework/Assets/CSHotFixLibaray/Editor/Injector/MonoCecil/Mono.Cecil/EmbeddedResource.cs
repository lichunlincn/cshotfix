using System;
using System.IO;
namespace Editor_Mono.Cecil
{
	public sealed class EmbeddedResource : Resource
	{
		private readonly MetadataReader reader;
		private uint? offset;
		private byte[] data;
		private Stream stream;
		public override ResourceType ResourceType
		{
			get
			{
				return ResourceType.Embedded;
			}
		}
		public EmbeddedResource(string name, ManifestResourceAttributes attributes, byte[] data) : base(name, attributes)
		{
			this.data = data;
		}
		public EmbeddedResource(string name, ManifestResourceAttributes attributes, Stream stream) : base(name, attributes)
		{
			this.stream = stream;
		}
		internal EmbeddedResource(string name, ManifestResourceAttributes attributes, uint offset, MetadataReader reader) : base(name, attributes)
		{
			this.offset = new uint?(offset);
			this.reader = reader;
		}
		public Stream GetResourceStream()
		{
			if (this.stream != null)
			{
				return this.stream;
			}
			if (this.data != null)
			{
				return new MemoryStream(this.data);
			}
			if (this.offset.HasValue)
			{
				return this.reader.GetManagedResourceStream(this.offset.Value);
			}
			throw new InvalidOperationException();
		}
		public byte[] GetResourceData()
		{
			if (this.stream != null)
			{
				return EmbeddedResource.ReadStream(this.stream);
			}
			if (this.data != null)
			{
				return this.data;
			}
			if (this.offset.HasValue)
			{
				return this.reader.GetManagedResourceStream(this.offset.Value).ToArray();
			}
			throw new InvalidOperationException();
		}
		private static byte[] ReadStream(Stream stream)
		{
			int num3;
			if (stream.CanSeek)
			{
				int num = (int)stream.Length;
				byte[] array = new byte[num];
				int num2 = 0;
				while ((num3 = stream.Read(array, num2, num - num2)) > 0)
				{
					num2 += num3;
				}
				return array;
			}
			byte[] array2 = new byte[8192];
			MemoryStream memoryStream = new MemoryStream();
			while ((num3 = stream.Read(array2, 0, array2.Length)) > 0)
			{
				memoryStream.Write(array2, 0, num3);
			}
			return memoryStream.ToArray();
		}
	}
}
