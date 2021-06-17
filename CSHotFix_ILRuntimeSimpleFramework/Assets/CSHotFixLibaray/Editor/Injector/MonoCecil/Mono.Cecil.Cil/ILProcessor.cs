using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class ILProcessor
	{
		private readonly MethodBody body;
		private readonly Collection<Instruction> instructions;
		public MethodBody Body
		{
			get
			{
				return this.body;
			}
		}
		internal ILProcessor(MethodBody body)
		{
			this.body = body;
			this.instructions = body.Instructions;
		}
		public Instruction Create(OpCode opcode)
		{
			return Instruction.Create(opcode);
		}
		public Instruction Create(OpCode opcode, TypeReference type)
		{
			return Instruction.Create(opcode, type);
		}
		public Instruction Create(OpCode opcode, CallSite site)
		{
			return Instruction.Create(opcode, site);
		}
		public Instruction Create(OpCode opcode, MethodReference method)
		{
			return Instruction.Create(opcode, method);
		}
		public Instruction Create(OpCode opcode, FieldReference field)
		{
			return Instruction.Create(opcode, field);
		}
		public Instruction Create(OpCode opcode, string value)
		{
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, sbyte value)
		{
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, byte value)
		{
			if (opcode.OperandType == OperandType.ShortInlineVar)
			{
				return Instruction.Create(opcode, this.body.Variables[(int)value]);
			}
			if (opcode.OperandType == OperandType.ShortInlineArg)
			{
				return Instruction.Create(opcode, this.body.GetParameter((int)value));
			}
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, int value)
		{
			if (opcode.OperandType == OperandType.InlineVar)
			{
				return Instruction.Create(opcode, this.body.Variables[value]);
			}
			if (opcode.OperandType == OperandType.InlineArg)
			{
				return Instruction.Create(opcode, this.body.GetParameter(value));
			}
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, long value)
		{
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, float value)
		{
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, double value)
		{
			return Instruction.Create(opcode, value);
		}
		public Instruction Create(OpCode opcode, Instruction target)
		{
			return Instruction.Create(opcode, target);
		}
		public Instruction Create(OpCode opcode, Instruction[] targets)
		{
			return Instruction.Create(opcode, targets);
		}
		public Instruction Create(OpCode opcode, VariableDefinition variable)
		{
			return Instruction.Create(opcode, variable);
		}
		public Instruction Create(OpCode opcode, ParameterDefinition parameter)
		{
			return Instruction.Create(opcode, parameter);
		}
		public void Emit(OpCode opcode)
		{
			this.Append(this.Create(opcode));
		}
		public void Emit(OpCode opcode, TypeReference type)
		{
			this.Append(this.Create(opcode, type));
		}
		public void Emit(OpCode opcode, MethodReference method)
		{
			this.Append(this.Create(opcode, method));
		}
		public void Emit(OpCode opcode, CallSite site)
		{
			this.Append(this.Create(opcode, site));
		}
		public void Emit(OpCode opcode, FieldReference field)
		{
			this.Append(this.Create(opcode, field));
		}
		public void Emit(OpCode opcode, string value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, byte value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, sbyte value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, int value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, long value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, float value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, double value)
		{
			this.Append(this.Create(opcode, value));
		}
		public void Emit(OpCode opcode, Instruction target)
		{
			this.Append(this.Create(opcode, target));
		}
		public void Emit(OpCode opcode, Instruction[] targets)
		{
			this.Append(this.Create(opcode, targets));
		}
		public void Emit(OpCode opcode, VariableDefinition variable)
		{
			this.Append(this.Create(opcode, variable));
		}
		public void Emit(OpCode opcode, ParameterDefinition parameter)
		{
			this.Append(this.Create(opcode, parameter));
		}
		public void InsertBefore(Instruction target, Instruction instruction)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (instruction == null)
			{
				throw new ArgumentNullException("instruction");
			}
			int num = this.instructions.IndexOf(target);
			if (num == -1)
			{
				throw new ArgumentOutOfRangeException("target");
			}
			this.instructions.Insert(num, instruction);
		}
		public void InsertAfter(Instruction target, Instruction instruction)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (instruction == null)
			{
				throw new ArgumentNullException("instruction");
			}
			int num = this.instructions.IndexOf(target);
			if (num == -1)
			{
				throw new ArgumentOutOfRangeException("target");
			}
			this.instructions.Insert(num + 1, instruction);
		}
		public void Append(Instruction instruction)
		{
			if (instruction == null)
			{
				throw new ArgumentNullException("instruction");
			}
			this.instructions.Add(instruction);
		}
		public void Replace(Instruction target, Instruction instruction)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (instruction == null)
			{
				throw new ArgumentNullException("instruction");
			}
			this.InsertAfter(target, instruction);
			this.Remove(target);
		}
		public void Remove(Instruction instruction)
		{
			if (instruction == null)
			{
				throw new ArgumentNullException("instruction");
			}
			if (!this.instructions.Remove(instruction))
			{
				throw new ArgumentOutOfRangeException("instruction");
			}
		}
	}
}
