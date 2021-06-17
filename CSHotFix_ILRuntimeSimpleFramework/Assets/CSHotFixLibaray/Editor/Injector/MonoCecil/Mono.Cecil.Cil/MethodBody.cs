using Editor_Mono.Collections.Generic;
using System;
using System.Threading;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class MethodBody : IVariableDefinitionProvider
	{
		internal readonly MethodDefinition method;
		internal ParameterDefinition this_parameter;
		internal int max_stack_size;
		internal int code_size;
		internal bool init_locals;
		internal MetadataToken local_var_token;
		internal Collection<Instruction> instructions;
		internal Collection<ExceptionHandler> exceptions;
		internal Collection<VariableDefinition> variables;
		private Scope scope;
		public MethodDefinition Method
		{
			get
			{
				return this.method;
			}
		}
		public int MaxStackSize
		{
			get
			{
				return this.max_stack_size;
			}
			set
			{
				this.max_stack_size = value;
			}
		}
		public int CodeSize
		{
			get
			{
				return this.code_size;
			}
		}
		public bool InitLocals
		{
			get
			{
				return this.init_locals;
			}
			set
			{
				this.init_locals = value;
			}
		}
		public MetadataToken LocalVarToken
		{
			get
			{
				return this.local_var_token;
			}
			set
			{
				this.local_var_token = value;
			}
		}
		public Collection<Instruction> Instructions
		{
			get
			{
				Collection<Instruction> arg_18_0;
				if ((arg_18_0 = this.instructions) == null)
				{
					arg_18_0 = (this.instructions = new InstructionCollection());
				}
				return arg_18_0;
			}
		}
		public bool HasExceptionHandlers
		{
			get
			{
				return !this.exceptions.IsNullOrEmpty<ExceptionHandler>();
			}
		}
		public Collection<ExceptionHandler> ExceptionHandlers
		{
			get
			{
				Collection<ExceptionHandler> arg_18_0;
				if ((arg_18_0 = this.exceptions) == null)
				{
					arg_18_0 = (this.exceptions = new Collection<ExceptionHandler>());
				}
				return arg_18_0;
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
				Collection<VariableDefinition> arg_18_0;
				if ((arg_18_0 = this.variables) == null)
				{
					arg_18_0 = (this.variables = new VariableDefinitionCollection());
				}
				return arg_18_0;
			}
		}
		public Scope Scope
		{
			get
			{
				return this.scope;
			}
			set
			{
				this.scope = value;
			}
		}
		public ParameterDefinition ThisParameter
		{
			get
			{
				if (this.method == null || this.method.DeclaringType == null)
				{
					throw new NotSupportedException();
				}
				if (!this.method.HasThis)
				{
					return null;
				}
				if (this.this_parameter == null)
				{
					Interlocked.CompareExchange<ParameterDefinition>(ref this.this_parameter, MethodBody.CreateThisParameter(this.method), null);
				}
				return this.this_parameter;
			}
		}
		private static ParameterDefinition CreateThisParameter(MethodDefinition method)
		{
            var parameter_type = method.DeclaringType as TypeReference;

            if (parameter_type.HasGenericParameters)
            {
                var instance = new GenericInstanceType(parameter_type);
                for (int i = 0; i < parameter_type.GenericParameters.Count; i++)
                    instance.GenericArguments.Add(parameter_type.GenericParameters[i]);

                parameter_type = instance;

            }

            if (parameter_type.IsValueType || parameter_type.IsPrimitive)
                parameter_type = new ByReferenceType(parameter_type);

            return new ParameterDefinition(parameter_type, method);
        }
		public MethodBody(MethodDefinition method)
		{
			this.method = method;
		}
		public ILProcessor GetILProcessor()
		{
			return new ILProcessor(this);
		}
	}
}
