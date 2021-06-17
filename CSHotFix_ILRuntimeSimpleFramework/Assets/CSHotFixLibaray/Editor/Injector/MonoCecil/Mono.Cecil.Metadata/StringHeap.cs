using Editor_Mono.Cecil.PE;
using System;
using System.Collections.Generic;
using System.Text;
namespace Editor_Mono.Cecil.Metadata
{
	internal class StringHeap : Heap
	{
		private readonly Dictionary<uint, string> strings = new Dictionary<uint, string>();
		public StringHeap(Section section, uint start, uint size) : base(section, start, size)
		{
		}
		public string Read(uint index)
		{
			if (index == 0u)
			{
				return string.Empty;
			}
			string text;
			if (this.strings.TryGetValue(index, out text))
			{
				return text;
			}
			if (index > this.Size - 1u)
			{
				return string.Empty;
			}
			text = this.ReadStringAt(index);
			if (text.Length != 0)
			{
				this.strings.Add(index, text);
			}
			return text;
		}
		protected virtual string ReadStringAt(uint index)
		{
			int num = 0;
			byte[] data = this.Section.Data;
			int num2 = (int)(index + this.Offset);
			int num3 = num2;
			while (data[num3] != 0)
			{
				num++;
				num3++;
			}
			return Encoding.UTF8.GetString(data, num2, num);
		}
	}
}
