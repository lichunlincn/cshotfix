using System;
namespace Editor_Mono.Cecil
{
	public interface IAssemblyResolver
	{
		AssemblyDefinition Resolve(AssemblyNameReference name);
		AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters);
		AssemblyDefinition Resolve(string fullName);
		AssemblyDefinition Resolve(string fullName, ReaderParameters parameters);
	}
}
