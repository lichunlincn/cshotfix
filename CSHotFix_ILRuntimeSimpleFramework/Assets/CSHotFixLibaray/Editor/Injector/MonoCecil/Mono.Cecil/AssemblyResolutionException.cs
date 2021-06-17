using System;
using System.IO;
using System.Runtime.Serialization;
namespace Editor_Mono.Cecil
{
	[Serializable]
	public class AssemblyResolutionException : FileNotFoundException
	{
		private readonly AssemblyNameReference reference;
		public AssemblyNameReference AssemblyReference
		{
			get
			{
				return this.reference;
			}
		}
		public AssemblyResolutionException(AssemblyNameReference reference) : base(string.Format("Failed to resolve assembly: '{0}'", reference))
		{
			this.reference = reference;
		}
		protected AssemblyResolutionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
