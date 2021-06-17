using System;
namespace Editor_Mono.Cecil
{
	public abstract class EventReference : MemberReference
	{
		private TypeReference event_type;
		public TypeReference EventType
		{
			get
			{
				return this.event_type;
			}
			set
			{
				this.event_type = value;
			}
		}
		public override string FullName
		{
			get
			{
				return this.event_type.FullName + " " + base.MemberFullName();
			}
		}
		protected EventReference(string name, TypeReference eventType) : base(name)
		{
			if (eventType == null)
			{
				throw new ArgumentNullException("eventType");
			}
			this.event_type = eventType;
		}
		public abstract EventDefinition Resolve();
	}
}
