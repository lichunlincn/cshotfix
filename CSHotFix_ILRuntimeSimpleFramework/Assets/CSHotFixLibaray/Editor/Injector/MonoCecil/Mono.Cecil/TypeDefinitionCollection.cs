using Editor_Mono.Cecil.Metadata;
using Editor_Mono.Collections.Generic;
using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil
{
	internal sealed class TypeDefinitionCollection : Collection<TypeDefinition>
	{
		private readonly ModuleDefinition container;
		private readonly Dictionary<Row<string, string>, TypeDefinition> name_cache;
		internal TypeDefinitionCollection(ModuleDefinition container)
		{
			this.container = container;
			this.name_cache = new Dictionary<Row<string, string>, TypeDefinition>(new RowEqualityComparer());
		}
		internal TypeDefinitionCollection(ModuleDefinition container, int capacity) : base(capacity)
		{
			this.container = container;
			this.name_cache = new Dictionary<Row<string, string>, TypeDefinition>(capacity, new RowEqualityComparer());
		}
		protected override void OnAdd(TypeDefinition item, int index)
		{
			this.Attach(item);
		}
		protected override void OnSet(TypeDefinition item, int index)
		{
			this.Attach(item);
		}
		protected override void OnInsert(TypeDefinition item, int index)
		{
			this.Attach(item);
		}
		protected override void OnRemove(TypeDefinition item, int index)
		{
			this.Detach(item);
		}
		protected override void OnClear()
		{
			foreach (TypeDefinition current in this)
			{
				this.Detach(current);
			}
		}
		private void Attach(TypeDefinition type)
		{
			if (type.Module != null && type.Module != this.container)
			{
				throw new ArgumentException("Type already attached");
			}
			type.module = this.container;
			type.scope = this.container;
			this.name_cache[new Row<string, string>(type.Namespace, type.Name)] = type;
		}
		private void Detach(TypeDefinition type)
		{
			type.module = null;
			type.scope = null;
			this.name_cache.Remove(new Row<string, string>(type.Namespace, type.Name));
		}
		public TypeDefinition GetType(string fullname)
		{
			string @namespace;
			string name;
			TypeParser.SplitFullName(fullname, out @namespace, out name);
			return this.GetType(@namespace, name);
		}
		public TypeDefinition GetType(string @namespace, string name)
		{
			TypeDefinition result;
			if (this.name_cache.TryGetValue(new Row<string, string>(@namespace, name), out result))
			{
				return result;
			}
			return null;
		}
	}
}
