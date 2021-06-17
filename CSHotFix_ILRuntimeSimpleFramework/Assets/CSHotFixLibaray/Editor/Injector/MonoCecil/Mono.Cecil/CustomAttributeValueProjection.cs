using System;
namespace Editor_Mono.Cecil
{
	internal class CustomAttributeValueProjection
	{
		public readonly AttributeTargets Targets;
		public readonly CustomAttributeValueTreatment Treatment;
		public CustomAttributeValueProjection(AttributeTargets targets, CustomAttributeValueTreatment treatment)
		{
			this.Targets = targets;
			this.Treatment = treatment;
		}
	}
}
