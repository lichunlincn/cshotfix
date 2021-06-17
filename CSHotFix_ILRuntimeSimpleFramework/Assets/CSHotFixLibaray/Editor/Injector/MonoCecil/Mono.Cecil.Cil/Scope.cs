using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class Scope : IVariableDefinitionProvider
	{
		private Instruction start;
		private Instruction end;
		private Collection<Scope> scopes;
		private Collection<VariableDefinition> variables;
		public Instruction Start
		{
			get
			{
				return this.start;
			}
			set
			{
				this.start = value;
			}
		}
		public Instruction End
		{
			get
			{
				return this.end;
			}
			set
			{
				this.end = value;
			}
		}
		public bool HasScopes
		{
			get
			{
				return !this.scopes.IsNullOrEmpty<Scope>();
			}
		}
		public Collection<Scope> Scopes
		{
			get
			{
				if (this.scopes == null)
				{
					this.scopes = new Collection<Scope>();
				}
				return this.scopes;
			}
		}
		public bool HasVariables
		{
			get
			{
				return !this.variables.IsNullOrEmpty<VariableDefinition>();
			}
		}
		public Collection<VariableDefinition> Variables
		{
			get
			{
				if (this.variables == null)
				{
					this.variables = new Collection<VariableDefinition>();
				}
				return this.variables;
			}
		}
	}
}
