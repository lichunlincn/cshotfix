using System;
namespace Editor_Mono.Cecil.Cil
{
	public struct InstructionSymbol
	{
		public readonly int Offset;
		public readonly SequencePoint SequencePoint;
		public InstructionSymbol(int offset, SequencePoint sequencePoint)
		{
			this.Offset = offset;
			this.SequencePoint = sequencePoint;
		}
	}
}
