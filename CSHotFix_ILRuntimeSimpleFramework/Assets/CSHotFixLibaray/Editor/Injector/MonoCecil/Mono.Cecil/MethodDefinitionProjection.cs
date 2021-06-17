using System;
namespace Editor_Mono.Cecil
{
	internal class MethodDefinitionProjection
	{
		public readonly MethodAttributes Attributes;
		public readonly MethodImplAttributes ImplAttributes;
		public readonly string Name;
		public readonly MethodDefinitionTreatment Treatment;
		public MethodDefinitionProjection(MethodDefinition method, MethodDefinitionTreatment treatment)
		{
			this.Attributes = method.Attributes;
			this.ImplAttributes = method.ImplAttributes;
			this.Name = method.Name;
			this.Treatment = treatment;
		}
	}
}
