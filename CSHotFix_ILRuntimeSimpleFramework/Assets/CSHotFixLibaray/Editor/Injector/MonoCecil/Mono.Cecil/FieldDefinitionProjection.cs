using System;
namespace Editor_Mono.Cecil
{
	internal class FieldDefinitionProjection
	{
		public readonly FieldAttributes Attributes;
		public readonly FieldDefinitionTreatment Treatment;
		public FieldDefinitionProjection(FieldDefinition field, FieldDefinitionTreatment treatment)
		{
			this.Attributes = field.Attributes;
			this.Treatment = treatment;
		}
	}
}
