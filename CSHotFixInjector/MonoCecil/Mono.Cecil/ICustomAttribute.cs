using Mono.Collections.Generic;
using System;
namespace Mono.Cecil
{
	public interface ICustomAttribute
	{
		TypeReference AttributeType
		{
			get;
		}
		bool HasFields
		{
			get;
		}
		bool HasProperties
		{
			get;
		}
		Collection<CustomAttributeNamedArgument> Fields
		{
			get;
		}
		Collection<CustomAttributeNamedArgument> Properties
		{
			get;
		}
	}
}
