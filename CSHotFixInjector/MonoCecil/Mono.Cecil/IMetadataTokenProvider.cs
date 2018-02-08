using System;
namespace Mono.Cecil
{
	public interface IMetadataTokenProvider
	{
		MetadataToken MetadataToken
		{
			get;
			set;
		}
	}
}
