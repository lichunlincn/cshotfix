using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	internal class InterfaceImplementationCollection : Collection<InterfaceImplementation>
	{
		private readonly TypeDefinition type;
		internal InterfaceImplementationCollection(TypeDefinition type)
		{
			this.type = type;
		}
		internal InterfaceImplementationCollection(TypeDefinition type, int length) : base(length)
		{
			this.type = type;
		}
		protected override void OnAdd(InterfaceImplementation item, int index)
		{
			item.type = this.type;
		}
		protected override void OnInsert(InterfaceImplementation item, int index)
		{
			item.type = this.type;
		}
		protected override void OnSet(InterfaceImplementation item, int index)
		{
			item.type = this.type;
		}
		protected override void OnRemove(InterfaceImplementation item, int index)
		{
			item.type = null;
		}
	}
}
