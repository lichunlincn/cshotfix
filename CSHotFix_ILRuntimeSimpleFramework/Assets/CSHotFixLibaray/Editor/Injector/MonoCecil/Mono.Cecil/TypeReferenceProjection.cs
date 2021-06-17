using System;
namespace Editor_Mono.Cecil
{
	internal class TypeReferenceProjection
	{
		public readonly string Name;
		public readonly string Namespace;
		public readonly IMetadataScope Scope;
		public readonly TypeReferenceTreatment Treatment;
		public TypeReferenceProjection(TypeReference type, TypeReferenceTreatment treatment)
		{
			this.Name = type.Name;
			this.Namespace = type.Namespace;
			this.Scope = type.Scope;
			this.Treatment = treatment;
		}
	}
}
