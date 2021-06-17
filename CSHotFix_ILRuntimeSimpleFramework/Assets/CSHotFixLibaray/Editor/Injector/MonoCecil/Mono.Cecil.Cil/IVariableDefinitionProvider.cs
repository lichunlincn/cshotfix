using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil.Cil
{
	public interface IVariableDefinitionProvider
	{
		bool HasVariables
		{
			get;
		}
		Collection<VariableDefinition> Variables
		{
			get;
		}
	}
}
