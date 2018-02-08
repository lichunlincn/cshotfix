using Mono.Collections.Generic;
using System;
namespace Mono.Cecil
{
	public interface ISecurityDeclarationProvider : IMetadataTokenProvider
	{
		bool HasSecurityDeclarations
		{
			get;
		}
		Collection<SecurityDeclaration> SecurityDeclarations
		{
			get;
		}
	}
}
