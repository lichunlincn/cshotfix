using System;
using System.Runtime.Serialization;
namespace Editor_Mono.Cecil
{
	[Serializable]
	public class ResolutionException : Exception
	{
		private readonly MemberReference member;
		public MemberReference Member
		{
			get
			{
				return this.member;
			}
		}
		public IMetadataScope Scope
		{
			get
			{
				TypeReference typeReference = this.member as TypeReference;
				if (typeReference != null)
				{
					return typeReference.Scope;
				}
				TypeReference declaringType = this.member.DeclaringType;
				if (declaringType != null)
				{
					return declaringType.Scope;
				}
				throw new NotSupportedException();
			}
		}
		public ResolutionException(MemberReference member) : base("Failed to resolve " + member.FullName)
		{
			if (member == null)
			{
				throw new ArgumentNullException("member");
			}
			this.member = member;
		}
		protected ResolutionException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}
