using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil.Metadata
{
	internal abstract class HeapBuffer : ByteBuffer
	{
		public bool IsLarge
		{
			get
			{
				return this.length > 65535;
			}
		}
		public abstract bool IsEmpty
		{
			get;
		}
		protected HeapBuffer(int length) : base(length)
		{
		}
	}
}
