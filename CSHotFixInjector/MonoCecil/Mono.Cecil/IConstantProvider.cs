using System;
namespace Mono.Cecil
{
	public interface IConstantProvider : IMetadataTokenProvider
	{
		bool HasConstant
		{
			get;
			set;
		}
		object Constant
		{
			get;
			set;
		}
	}
}
