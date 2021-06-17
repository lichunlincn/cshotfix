using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class ExceptionHandler
	{
		private Instruction try_start;
		private Instruction try_end;
		private Instruction filter_start;
		private Instruction handler_start;
		private Instruction handler_end;
		private TypeReference catch_type;
		private ExceptionHandlerType handler_type;
		public Instruction TryStart
		{
			get
			{
				return this.try_start;
			}
			set
			{
				this.try_start = value;
			}
		}
		public Instruction TryEnd
		{
			get
			{
				return this.try_end;
			}
			set
			{
				this.try_end = value;
			}
		}
		public Instruction FilterStart
		{
			get
			{
				return this.filter_start;
			}
			set
			{
				this.filter_start = value;
			}
		}
		public Instruction HandlerStart
		{
			get
			{
				return this.handler_start;
			}
			set
			{
				this.handler_start = value;
			}
		}
		public Instruction HandlerEnd
		{
			get
			{
				return this.handler_end;
			}
			set
			{
				this.handler_end = value;
			}
		}
		public TypeReference CatchType
		{
			get
			{
				return this.catch_type;
			}
			set
			{
				this.catch_type = value;
			}
		}
		public ExceptionHandlerType HandlerType
		{
			get
			{
				return this.handler_type;
			}
			set
			{
				this.handler_type = value;
			}
		}
		public ExceptionHandler(ExceptionHandlerType handlerType)
		{
			this.handler_type = handlerType;
		}
	}
}
