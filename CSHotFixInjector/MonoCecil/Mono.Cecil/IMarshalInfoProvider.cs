using System;
namespace Mono.Cecil
{
	public interface IMarshalInfoProvider : IMetadataTokenProvider
	{
		bool HasMarshalInfo
		{
			get;
		}
		MarshalInfo MarshalInfo
		{
			get;
			set;
		}
	}
}
