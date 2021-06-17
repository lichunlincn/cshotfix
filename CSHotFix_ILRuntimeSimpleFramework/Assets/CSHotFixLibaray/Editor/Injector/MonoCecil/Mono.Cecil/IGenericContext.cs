using System;
namespace Editor_Mono.Cecil
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
