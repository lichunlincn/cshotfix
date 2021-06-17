using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class GenericParameterCollection : Collection<GenericParameter>
	{
		private readonly IGenericParameterProvider owner;
		internal GenericParameterCollection(IGenericParameterProvider owner)
		{
			this.owner = owner;
		}
		internal GenericParameterCollection(IGenericParameterProvider owner, int capacity) : base(capacity)
		{
			this.owner = owner;
		}
		protected override void OnAdd(GenericParameter item, int index)
		{
			this.UpdateGenericParameter(item, index);
		}
		protected override void OnInsert(GenericParameter item, int index)
		{
			this.UpdateGenericParameter(item, index);
			for (int i = index; i < this.size; i++)
			{
				this.items[i].position = i + 1;
			}
		}
		protected override void OnSet(GenericParameter item, int index)
		{
			this.UpdateGenericParameter(item, index);
		}
		private void UpdateGenericParameter(GenericParameter item, int index)
		{
			item.owner = this.owner;
			item.position = index;
			item.type = this.owner.GenericParameterType;
		}
		protected override void OnRemove(GenericParameter item, int index)
		{
			item.owner = null;
			item.position = -1;
			item.type = GenericParameterType.Type;
			for (int i = index + 1; i < this.size; i++)
			{
				this.items[i].position = i - 1;
			}
		}
	}
}
