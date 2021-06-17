using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class VariableDefinition : VariableReference
	{
		public bool IsPinned
		{
			get
			{
				return this.variable_type.IsPinned;
			}
		}
		public VariableDefinition(TypeReference variableType) : base(variableType)
		{
		}
		public VariableDefinition(string name, TypeReference variableType) : base(name, variableType)
		{
		}
		public override VariableDefinition Resolve()
		{
			return this;
		}
	}
}
