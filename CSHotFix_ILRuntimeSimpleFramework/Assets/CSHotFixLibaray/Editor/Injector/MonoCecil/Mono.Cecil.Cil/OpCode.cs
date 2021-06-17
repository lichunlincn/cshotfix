using System;
namespace Editor_Mono.Cecil.Cil
{
	public struct OpCode : IEquatable<OpCode>
	{
		private readonly byte op1;
		private readonly byte op2;
		private readonly byte code;
		private readonly byte flow_control;
		private readonly byte opcode_type;
		private readonly byte operand_type;
		private readonly byte stack_behavior_pop;
		private readonly byte stack_behavior_push;
		public string Name
		{
			get
			{
				return OpCodeNames.names[(int)this.Code];
			}
		}
		public int Size
		{
			get
			{
				if (this.op1 != 255)
				{
					return 2;
				}
				return 1;
			}
		}
		public byte Op1
		{
			get
			{
				return this.op1;
			}
		}
		public byte Op2
		{
			get
			{
				return this.op2;
			}
		}
		public short Value
		{
			get
			{
				if (this.op1 != 255)
				{
					return (short)((int)this.op1 << 8 | (int)this.op2);
				}
				return (short)this.op2;
			}
		}
		public Code Code
		{
			get
			{
				return (Code)this.code;
			}
		}
		public FlowControl FlowControl
		{
			get
			{
				return (FlowControl)this.flow_control;
			}
		}
		public OpCodeType OpCodeType
		{
			get
			{
				return (OpCodeType)this.opcode_type;
			}
		}
		public OperandType OperandType
		{
			get
			{
				return (OperandType)this.operand_type;
			}
		}
		public StackBehaviour StackBehaviourPop
		{
			get
			{
				return (StackBehaviour)this.stack_behavior_pop;
			}
		}
		public StackBehaviour StackBehaviourPush
		{
			get
			{
				return (StackBehaviour)this.stack_behavior_push;
			}
		}
		internal OpCode(int x, int y)
		{
			this.op1 = (byte)(x & 255);
			this.op2 = (byte)(x >> 8 & 255);
			this.code = (byte)(x >> 16 & 255);
			this.flow_control = (byte)(x >> 24 & 255);
			this.opcode_type = (byte)(y & 255);
			this.operand_type = (byte)(y >> 8 & 255);
			this.stack_behavior_pop = (byte)(y >> 16 & 255);
			this.stack_behavior_push = (byte)(y >> 24 & 255);
			if (this.op1 == 255)
			{
				OpCodes.OneByteOpCode[(int)this.op2] = this;
				return;
			}
			OpCodes.TwoBytesOpCode[(int)this.op2] = this;
		}
		public override int GetHashCode()
		{
			return (int)this.Value;
		}
		public override bool Equals(object obj)
		{
			if (!(obj is OpCode))
			{
				return false;
			}
			OpCode opCode = (OpCode)obj;
			return this.op1 == opCode.op1 && this.op2 == opCode.op2;
		}
		public bool Equals(OpCode opcode)
		{
			return this.op1 == opcode.op1 && this.op2 == opcode.op2;
		}
		public static bool operator ==(OpCode one, OpCode other)
		{
			return one.op1 == other.op1 && one.op2 == other.op2;
		}
		public static bool operator !=(OpCode one, OpCode other)
		{
			return one.op1 != other.op1 || one.op2 != other.op2;
		}
		public override string ToString()
		{
			return this.Name;
		}
	}
}
