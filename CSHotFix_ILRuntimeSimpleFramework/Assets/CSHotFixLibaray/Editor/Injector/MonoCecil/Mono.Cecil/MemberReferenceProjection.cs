using System;
namespace Editor_Mono.Cecil
{
	internal class MemberReferenceProjection
	{
		public readonly string Name;
		public readonly MemberReferenceTreatment Treatment;
		public MemberReferenceProjection(MemberReference member, MemberReferenceTreatment treatment)
		{
			this.Name = member.Name;
			this.Treatment = treatment;
		}
	}
}
