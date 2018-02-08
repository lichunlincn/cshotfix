using System;
namespace Mono.Cecil
{
	public interface IMetadataScope : IMetadataTokenProvider
	{
		MetadataScopeType MetadataScopeType
		{
			get;
		}
		string Name
		{
			get;
			set;
		}
	}
}
