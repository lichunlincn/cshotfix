using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
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
