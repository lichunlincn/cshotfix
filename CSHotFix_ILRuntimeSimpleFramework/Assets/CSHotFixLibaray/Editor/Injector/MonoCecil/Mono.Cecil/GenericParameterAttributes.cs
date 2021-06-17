using System;
namespace Editor_Mono.Cecil
{
	[Flags]
	public enum GenericParameterAttributes : ushort
	{
		VarianceMask = 3,
		NonVariant = 0,
		Covariant = 1,
		Contravariant = 2,
		SpecialConstraintMask = 28,
		ReferenceTypeConstraint = 4,
		NotNullableValueTypeConstraint = 8,
		DefaultConstructorConstraint = 16
	}
}
