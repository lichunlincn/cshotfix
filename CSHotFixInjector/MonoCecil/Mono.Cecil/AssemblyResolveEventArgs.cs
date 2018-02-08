using System;
namespace Mono.Cecil
{
	public sealed class AssemblyResolveEventArgs : EventArgs
	{
		private readonly AssemblyNameReference reference;
		public AssemblyNameReference AssemblyReference
		{
			get
			{
				return this.reference;
			}
		}
		public AssemblyResolveEventArgs(AssemblyNameReference reference)
		{
			this.reference = reference;
		}
	}
}
