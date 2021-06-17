using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil.PE
{
	internal sealed class ByteBufferEqualityComparer : IEqualityComparer<ByteBuffer>
	{
		public bool Equals(ByteBuffer x, ByteBuffer y)
		{
			if (x.length != y.length)
			{
				return false;
			}
			byte[] buffer = x.buffer;
			byte[] buffer2 = y.buffer;
			for (int i = 0; i < x.length; i++)
			{
				if (buffer[i] != buffer2[i])
				{
					return false;
				}
			}
			return true;
		}
		public int GetHashCode(ByteBuffer buffer)
		{
			int num = 0;
			byte[] buffer2 = buffer.buffer;
			for (int i = 0; i < buffer.length; i++)
			{
				num = (num * 37 ^ (int)buffer2[i]);
			}
			return num;
		}
	}
}
