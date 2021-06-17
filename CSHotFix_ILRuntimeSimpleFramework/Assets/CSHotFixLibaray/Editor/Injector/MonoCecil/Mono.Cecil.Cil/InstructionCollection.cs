using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil.Cil
{
	internal class InstructionCollection : Collection<Instruction>
	{
		internal InstructionCollection()
		{
		}
		internal InstructionCollection(int capacity) : base(capacity)
		{
		}
		protected override void OnAdd(Instruction item, int index)
		{
			if (index == 0)
			{
				return;
			}
			Instruction instruction = this.items[index - 1];
			instruction.next = item;
			item.previous = instruction;
		}
		protected override void OnInsert(Instruction item, int index)
		{
			if (this.size == 0)
			{
				return;
			}
			Instruction instruction = this.items[index];
			if (instruction == null)
			{
				Instruction instruction2 = this.items[index - 1];
				instruction2.next = item;
				item.previous = instruction2;
				return;
			}
			Instruction previous = instruction.previous;
			if (previous != null)
			{
				previous.next = item;
				item.previous = previous;
			}
			instruction.previous = item;
			item.next = instruction;
		}
		protected override void OnSet(Instruction item, int index)
		{
			Instruction instruction = this.items[index];
			item.previous = instruction.previous;
			item.next = instruction.next;
			instruction.previous = null;
			instruction.next = null;
		}
		protected override void OnRemove(Instruction item, int index)
		{
			Instruction previous = item.previous;
			if (previous != null)
			{
				previous.next = item.next;
			}
			Instruction next = item.next;
			if (next != null)
			{
				next.previous = item.previous;
			}
			item.previous = null;
			item.next = null;
		}
	}
}
