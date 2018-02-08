using System;
namespace Mono.Cecil
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
