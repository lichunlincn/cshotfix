using Mono.Cecil.PE;
using System;
namespace Mono.Cecil.Metadata
{
	internal sealed class ResourceBuffer : ByteBuffer
	{
		public ResourceBuffer() : base(0)
		{
		}
		public uint AddResource(byte[] resource)
		{
			uint position = (uint)this.position;
			base.WriteInt32(resource.Length);
			base.WriteBytes(resource);
			return position;
		}
	}
}
