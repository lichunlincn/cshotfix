using System;
namespace Editor_Mono.Cecil
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
