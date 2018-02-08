using Mono.Collections.Generic;
using System;
namespace Mono.Cecil.Cil
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
