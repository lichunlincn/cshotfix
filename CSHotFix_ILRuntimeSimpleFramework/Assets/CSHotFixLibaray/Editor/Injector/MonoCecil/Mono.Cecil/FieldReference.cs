using System;
namespace Editor_Mono.Cecil
{
	public class FieldReference : MemberReference
	{
		private TypeReference field_type;
		public TypeReference FieldType
		{
			get
			{
				return this.field_type;
			}
			set
			{
				this.field_type = value;
			}
		}
		public override string FullName
		{
			get
			{
				return this.field_type.FullName + " " + base.MemberFullName();
			}
		}
		public override bool ContainsGenericParameter
		{
			get
			{
				return this.field_type.ContainsGenericParameter || base.ContainsGenericParameter;
			}
		}
		internal FieldReference()
		{
			this.token = new MetadataToken(TokenType.MemberRef);
		}
		public FieldReference(string name, TypeReference fieldType) : base(name)
		{
			if (fieldType == null)
			{
				throw new ArgumentNullException("fieldType");
			}
			this.field_type = fieldType;
			this.token = new MetadataToken(TokenType.MemberRef);
		}
		public FieldReference(string name, TypeReference fieldType, TypeReference declaringType) : this(name, fieldType)
		{
			if (declaringType == null)
			{
				throw new ArgumentNullException("declaringType");
			}
			this.DeclaringType = declaringType;
		}
		public virtual FieldDefinition Resolve()
		{
			ModuleDefinition module = this.Module;
			if (module == null)
			{
				throw new NotSupportedException();
			}
			return module.Resolve(this);
		}
	}
}
