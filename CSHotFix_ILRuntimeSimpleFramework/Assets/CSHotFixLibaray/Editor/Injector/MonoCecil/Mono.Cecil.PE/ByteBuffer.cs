using System;
namespace Editor_Mono.Cecil.PE
{
	internal class ByteBuffer
	{
		internal byte[] buffer;
		internal int length;
		internal int position;
		public ByteBuffer()
		{
			this.buffer = Empty<byte>.Array;
		}
		public ByteBuffer(int length)
		{
			this.buffer = new byte[length];
		}
		public ByteBuffer(byte[] buffer)
		{
			this.buffer = (buffer ?? Empty<byte>.Array);
			this.length = this.buffer.Length;
		}
		public void Reset(byte[] buffer)
		{
			this.buffer = (buffer ?? Empty<byte>.Array);
			this.length = this.buffer.Length;
		}
		public void Advance(int length)
		{
			this.position += length;
		}
		public byte ReadByte()
		{
			return this.buffer[this.position++];
		}
		public sbyte ReadSByte()
		{
			return (sbyte)this.ReadByte();
		}
		public byte[] ReadBytes(int length)
		{
			byte[] array = new byte[length];
			Buffer.BlockCopy(this.buffer, this.position, array, 0, length);
			this.position += length;
			return array;
		}
		public ushort ReadUInt16()
		{
			ushort result = (ushort)((int)this.buffer[this.position] | (int)this.buffer[this.position + 1] << 8);
			this.position += 2;
			return result;
		}
		public short ReadInt16()
		{
			return (short)this.ReadUInt16();
		}
		public uint ReadUInt32()
		{
			uint result = (uint)((int)this.buffer[this.position] | (int)this.buffer[this.position + 1] << 8 | (int)this.buffer[this.position + 2] << 16 | (int)this.buffer[this.position + 3] << 24);
			this.position += 4;
			return result;
		}
		public int ReadInt32()
		{
			return (int)this.ReadUInt32();
		}
		public ulong ReadUInt64()
		{
			uint num = this.ReadUInt32();
			uint num2 = this.ReadUInt32();
			return (ulong)num2 << 32 | (ulong)num;
		}
		public long ReadInt64()
		{
			return (long)this.ReadUInt64();
		}
		public uint ReadCompressedUInt32()
		{
			byte b = this.ReadByte();
			if ((b & 128) == 0)
			{
				return (uint)b;
			}
			if ((b & 64) == 0)
			{
				return ((uint)b & 4294967167u) << 8 | (uint)this.ReadByte();
			}
			return (uint)(((int)b & -193) << 24 | (int)this.ReadByte() << 16 | (int)this.ReadByte() << 8 | (int)this.ReadByte());
		}
		public int ReadCompressedInt32()
		{
			int num = (int)(this.ReadCompressedUInt32() >> 1);
			if ((num & 1) == 0)
			{
				return num;
			}
			if (num < 64)
			{
				return num - 64;
			}
			if (num < 8192)
			{
				return num - 8192;
			}
			if (num < 268435456)
			{
				return num - 268435456;
			}
			return num - 536870912;
		}
		public float ReadSingle()
		{
			if (!BitConverter.IsLittleEndian)
			{
				byte[] array = this.ReadBytes(4);
				Array.Reverse(array);
				return BitConverter.ToSingle(array, 0);
			}
			float result = BitConverter.ToSingle(this.buffer, this.position);
			this.position += 4;
			return result;
		}
		public double ReadDouble()
		{
			if (!BitConverter.IsLittleEndian)
			{
				byte[] array = this.ReadBytes(8);
				Array.Reverse(array);
				return BitConverter.ToDouble(array, 0);
			}
			double result = BitConverter.ToDouble(this.buffer, this.position);
			this.position += 8;
			return result;
		}
		public void WriteByte(byte value)
		{
			if (this.position == this.buffer.Length)
			{
				this.Grow(1);
			}
			this.buffer[this.position++] = value;
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteSByte(sbyte value)
		{
			this.WriteByte((byte)value);
		}
		public void WriteUInt16(ushort value)
		{
			if (this.position + 2 > this.buffer.Length)
			{
				this.Grow(2);
			}
			this.buffer[this.position++] = (byte)value;
			this.buffer[this.position++] = (byte)(value >> 8);
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteInt16(short value)
		{
			this.WriteUInt16((ushort)value);
		}
		public void WriteUInt32(uint value)
		{
			if (this.position + 4 > this.buffer.Length)
			{
				this.Grow(4);
			}
			this.buffer[this.position++] = (byte)value;
			this.buffer[this.position++] = (byte)(value >> 8);
			this.buffer[this.position++] = (byte)(value >> 16);
			this.buffer[this.position++] = (byte)(value >> 24);
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteInt32(int value)
		{
			this.WriteUInt32((uint)value);
		}
		public void WriteUInt64(ulong value)
		{
			if (this.position + 8 > this.buffer.Length)
			{
				this.Grow(8);
			}
			this.buffer[this.position++] = (byte)value;
			this.buffer[this.position++] = (byte)(value >> 8);
			this.buffer[this.position++] = (byte)(value >> 16);
			this.buffer[this.position++] = (byte)(value >> 24);
			this.buffer[this.position++] = (byte)(value >> 32);
			this.buffer[this.position++] = (byte)(value >> 40);
			this.buffer[this.position++] = (byte)(value >> 48);
			this.buffer[this.position++] = (byte)(value >> 56);
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteInt64(long value)
		{
			this.WriteUInt64((ulong)value);
		}
		public void WriteCompressedUInt32(uint value)
		{
			if (value < 128u)
			{
				this.WriteByte((byte)value);
				return;
			}
			if (value < 16384u)
			{
				this.WriteByte((byte)(128u | value >> 8));
				this.WriteByte((byte)(value & 255u));
				return;
			}
			this.WriteByte((byte)(value >> 24 | 192u));
			this.WriteByte((byte)(value >> 16 & 255u));
			this.WriteByte((byte)(value >> 8 & 255u));
			this.WriteByte((byte)(value & 255u));
		}
		public void WriteCompressedInt32(int value)
		{
			if (value >= 0)
			{
				this.WriteCompressedUInt32((uint)((uint)value << 1));
				return;
			}
			if (value > -64)
			{
				value = 64 + value;
			}
			else
			{
				if (value >= -8192)
				{
					value = 8192 + value;
				}
				else
				{
					if (value >= -536870912)
					{
						value = 536870912 + value;
					}
				}
			}
			this.WriteCompressedUInt32((uint)(value << 1 | 1));
		}
		public void WriteBytes(byte[] bytes)
		{
			int num = bytes.Length;
			if (this.position + num > this.buffer.Length)
			{
				this.Grow(num);
			}
			Buffer.BlockCopy(bytes, 0, this.buffer, this.position, num);
			this.position += num;
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteBytes(int length)
		{
			if (this.position + length > this.buffer.Length)
			{
				this.Grow(length);
			}
			this.position += length;
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteBytes(ByteBuffer buffer)
		{
			if (this.position + buffer.length > this.buffer.Length)
			{
				this.Grow(buffer.length);
			}
			Buffer.BlockCopy(buffer.buffer, 0, this.buffer, this.position, buffer.length);
			this.position += buffer.length;
			if (this.position > this.length)
			{
				this.length = this.position;
			}
		}
		public void WriteSingle(float value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (!BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			this.WriteBytes(bytes);
		}
		public void WriteDouble(double value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (!BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			this.WriteBytes(bytes);
		}
		private void Grow(int desired)
		{
			byte[] array = this.buffer;
			int num = array.Length;
			byte[] dst = new byte[System.Math.Max(num + desired, num * 2)];
			Buffer.BlockCopy(array, 0, dst, 0, num);
			this.buffer = dst;
		}
	}
}
