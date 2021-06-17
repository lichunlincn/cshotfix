using Editor_Mono.Collections.Generic;
using System;
using System.Text;
namespace Editor_Mono.Cecil
{
	public sealed class CallSite : IMethodSignature, IMetadataTokenProvider
	{
		private readonly MethodReference signature;
		public bool HasThis
		{
			get
			{
				return this.signature.HasThis;
			}
			set
			{
				this.signature.HasThis = value;
			}
		}
		public bool ExplicitThis
		{
			get
			{
				return this.signature.ExplicitThis;
			}
			set
			{
				this.signature.ExplicitThis = value;
			}
		}
		public MethodCallingConvention CallingConvention
		{
			get
			{
				return this.signature.CallingConvention;
			}
			set
			{
				this.signature.CallingConvention = value;
			}
		}
		public bool HasParameters
		{
			get
			{
				return this.signature.HasParameters;
			}
		}
		public Collection<ParameterDefinition> Parameters
		{
			get
			{
				return this.signature.Parameters;
			}
		}
		public TypeReference ReturnType
		{
			get
			{
				return this.signature.MethodReturnType.ReturnType;
			}
			set
			{
				this.signature.MethodReturnType.ReturnType = value;
			}
		}
		public MethodReturnType MethodReturnType
		{
			get
			{
				return this.signature.MethodReturnType;
			}
		}
		public string Name
		{
			get
			{
				return string.Empty;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public string Namespace
		{
			get
			{
				return string.Empty;
			}
			set
			{
				throw new InvalidOperationException();
			}
		}
		public ModuleDefinition Module
		{
			get
			{
				return this.ReturnType.Module;
			}
		}
		public IMetadataScope Scope
		{
			get
			{
				return this.signature.ReturnType.Scope;
			}
		}
		public MetadataToken MetadataToken
		{
			get
			{
				return this.signature.token;
			}
			set
			{
				this.signature.token = value;
			}
		}
		public string FullName
		{
			get
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.ReturnType.FullName);
				this.MethodSignatureFullName(stringBuilder);
				return stringBuilder.ToString();
			}
		}
		internal CallSite()
		{
			this.signature = new MethodReference();
			this.signature.token = new MetadataToken(TokenType.Signature, 0);
		}
		public CallSite(TypeReference returnType) : this()
		{
			if (returnType == null)
			{
				throw new ArgumentNullException("returnType");
			}
			this.signature.ReturnType = returnType;
		}
		public override string ToString()
		{
			return this.FullName;
		}
	}
}
