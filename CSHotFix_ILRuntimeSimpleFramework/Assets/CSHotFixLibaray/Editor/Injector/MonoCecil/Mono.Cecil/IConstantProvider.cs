using System;
namespace Editor_Mono.Cecil
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
