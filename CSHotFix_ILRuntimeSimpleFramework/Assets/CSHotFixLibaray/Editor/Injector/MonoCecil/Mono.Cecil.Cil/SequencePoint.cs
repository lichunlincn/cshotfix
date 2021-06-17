using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class SequencePoint
	{
		private Document document;
		private int start_line;
		private int start_column;
		private int end_line;
		private int end_column;
		public int StartLine
		{
			get
			{
				return this.start_line;
			}
			set
			{
				this.start_line = value;
			}
		}
		public int StartColumn
		{
			get
			{
				return this.start_column;
			}
			set
			{
				this.start_column = value;
			}
		}
		public int EndLine
		{
			get
			{
				return this.end_line;
			}
			set
			{
				this.end_line = value;
			}
		}
		public int EndColumn
		{
			get
			{
				return this.end_column;
			}
			set
			{
				this.end_column = value;
			}
		}
		public Document Document
		{
			get
			{
				return this.document;
			}
			set
			{
				this.document = value;
			}
		}
		public SequencePoint(Document document)
		{
			this.document = document;
		}
	}
}
