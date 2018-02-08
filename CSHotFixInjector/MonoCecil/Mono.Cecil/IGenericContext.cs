using System;
namespace Mono.Cecil
{
	internal interface IGenericContext
	{
		bool IsDefinition
		{
			get;
		}
		IGenericParameterProvider Type
		{
			get;
		}
		IGenericParameterProvider Method
		{
			get;
		}
	}
}
