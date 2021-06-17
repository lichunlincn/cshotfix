using System;
using System.Collections.Generic;
namespace Editor_Mono.Cecil
{
	public class DefaultAssemblyResolver : BaseAssemblyResolver
	{
		private readonly IDictionary<string, AssemblyDefinition> cache;
		public DefaultAssemblyResolver()
		{
			this.cache = new Dictionary<string, AssemblyDefinition>(StringComparer.Ordinal);
		}
		public override AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			AssemblyDefinition assemblyDefinition;
			if (this.cache.TryGetValue(name.FullName, out assemblyDefinition))
			{
				return assemblyDefinition;
			}
			assemblyDefinition = base.Resolve(name);
			this.cache[name.FullName] = assemblyDefinition;
			return assemblyDefinition;
		}
		protected void RegisterAssembly(AssemblyDefinition assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			string fullName = assembly.Name.FullName;
			if (this.cache.ContainsKey(fullName))
			{
				return;
			}
			this.cache[fullName] = assembly;
		}
	}
}
