using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil.Cil
{
	internal class VariableDefinitionCollection : Collection<VariableDefinition>
	{
		internal VariableDefinitionCollection()
		{
		}
		internal VariableDefinitionCollection(int capacity) : base(capacity)
		{
		}
		protected override void OnAdd(VariableDefinition item, int index)
		{
			item.index = index;
		}
		protected override void OnInsert(VariableDefinition item, int index)
		{
			item.index = index;
			for (int i = index; i < this.size; i++)
			{
				this.items[i].index = i + 1;
			}
		}
		protected override void OnSet(VariableDefinition item, int index)
		{
			item.index = index;
		}
		protected override void OnRemove(VariableDefinition item, int index)
		{
			item.index = -1;
			for (int i = index + 1; i < this.size; i++)
			{
				this.items[i].index = i - 1;
			}
		}
	}
}
