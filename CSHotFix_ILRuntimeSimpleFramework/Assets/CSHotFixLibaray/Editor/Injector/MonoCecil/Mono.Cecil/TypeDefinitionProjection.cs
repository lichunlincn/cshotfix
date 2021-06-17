using System;
namespace Editor_Mono.Cecil
{
	internal class TypeDefinitionProjection
	{
		public readonly TypeAttributes Attributes;
		public readonly string Name;
		public readonly TypeDefinitionTreatment Treatment;
		public TypeDefinitionProjection(TypeDefinition type, TypeDefinitionTreatment treatment)
		{
			this.Attributes = type.Attributes;
			this.Name = type.Name;
			this.Treatment = treatment;
		}
	}
}
