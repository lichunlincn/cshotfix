using Editor_Mono.Cecil.PE;
using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil.Metadata
{
	internal sealed class BlobHeapBuffer : HeapBuffer
	{
		private readonly Dictionary<ByteBuffer, uint> blobs = new Dictionary<ByteBuffer, uint>(new ByteBufferEqualityComparer());
		public override bool IsEmpty
		{
			get
			{
				return this.length <= 1;
			}
		}
		public BlobHeapBuffer() : base(1)
		{
			base.WriteByte(0);
		}
		public uint GetBlobIndex(ByteBuffer blob)
		{
			uint position;
			if (this.blobs.TryGetValue(blob, out position))
			{
				return position;
			}
			position = (uint)this.position;
			this.WriteBlob(blob);
			this.blobs.Add(blob, position);
			return position;
		}
		private void WriteBlob(ByteBuffer blob)
		{
			base.WriteCompressedUInt32((uint)blob.length);
			base.WriteBytes(blob);
		}
	}
}
