using System;
namespace Editor_Mono.Cecil
{
	public interface IModifierType
	{
		TypeReference ModifierType
		{
			get;
		}
		TypeReference ElementType
		{
			get;
		}
	}
}
