using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
namespace Editor_Mono.Cecil
{
	public class AssemblyNameReference : IMetadataScope, IMetadataTokenProvider
	{
		private string name;
		private string culture;
		private Version version;
		private uint attributes;
		private byte[] public_key;
		private byte[] public_key_token;
		private AssemblyHashAlgorithm hash_algorithm;
		private byte[] hash;
		internal MetadataToken token;
		private string full_name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
				this.full_name = null;
			}
		}
		public string Culture
		{
			get
			{
				return this.culture;
			}
			set
			{
				this.culture = value;
				this.full_name = null;
			}
		}
		public Version Version
		{
			get
			{
				return this.version;
			}
			set
			{
				this.version = Mixin.CheckVersion(value);
				this.full_name = null;
			}
		}
		public AssemblyAttributes Attributes
		{
			get
			{
				return (AssemblyAttributes)this.attributes;
			}
			set
			{
				this.attributes = (uint)value;
			}
		}
		public bool HasPublicKey
		{
			get
			{
				return this.attributes.GetAttributes(1u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(1u, value);
			}
		}
		public bool IsSideBySideCompatible
		{
			get
			{
				return this.attributes.GetAttributes(0u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(0u, value);
			}
		}
		public bool IsRetargetable
		{
			get
			{
				return this.attributes.GetAttributes(256u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(256u, value);
			}
		}
		public bool IsWindowsRuntime
		{
			get
			{
				return this.attributes.GetAttributes(512u);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(512u, value);
			}
		}
		public byte[] PublicKey
		{
			get
			{
				return this.public_key ?? Empty<byte>.Array;
			}
			set
			{
				this.public_key = value;
				this.HasPublicKey = !this.public_key.IsNullOrEmpty<byte>();
				this.public_key_token = Empty<byte>.Array;
				this.full_name = null;
			}
		}
		public byte[] PublicKeyToken
		{
			get
			{
				if (this.public_key_token.IsNullOrEmpty<byte>() && !this.public_key.IsNullOrEmpty<byte>())
				{
					byte[] array = this.HashPublicKey();
					byte[] array2 = new byte[8];
					Array.Copy(array, array.Length - 8, array2, 0, 8);
					Array.Reverse(array2, 0, 8);
					this.public_key_token = array2;
				}
				return this.public_key_token ?? Empty<byte>.Array;
			}
			set
			{
				this.public_key_token = value;
				this.full_name = null;
			}
		}
		public virtual MetadataScopeType MetadataScopeType
		{
			get
			{
				return MetadataScopeType.AssemblyNameReference;
			}
		}
		public string FullName
		{
			get
			{
				if (this.full_name != null)
				{
					return this.full_name;
				}
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(this.name);
				stringBuilder.Append(", ");
				stringBuilder.Append("Version=");
				stringBuilder.Append(this.version.ToString(4));
				stringBuilder.Append(", ");
				stringBuilder.Append("Culture=");
				stringBuilder.Append(string.IsNullOrEmpty(this.culture) ? "neutral" : this.culture);
				stringBuilder.Append(", ");
				stringBuilder.Append("PublicKeyToken=");
				byte[] publicKeyToken = this.PublicKeyToken;
				if (!publicKeyToken.IsNullOrEmpty<byte>() && publicKeyToken.Length > 0)
				{
					for (int i = 0; i < publicKeyToken.Length; i++)
					{
						stringBuilder.Append(publicKeyToken[i].ToString("x2"));
					}
				}
				else
				{
					stringBuilder.Append("null");
				}
				if (this.IsRetargetable)
				{
					stringBuilder.Append(", ");
					stringBuilder.Append("Retargetable=Yes");
				}
				return this.full_name = stringBuilder.ToString();
			}
		}
		public AssemblyHashAlgorithm HashAlgorithm
		{
			get
			{
				return this.hash_algorithm;
			}
			set
			{
				this.hash_algorithm = value;
			}
		}
		public virtual byte[] Hash
		{
			get
			{
				return this.hash;
			}
			set
			{
				this.hash = value;
			}
		}
		public MetadataToken MetadataToken
		{
			get
			{
				return this.token;
			}
			set
			{
				this.token = value;
			}
		}
		private byte[] HashPublicKey()
		{
			AssemblyHashAlgorithm assemblyHashAlgorithm = this.hash_algorithm;
			HashAlgorithm hashAlgorithm;
			if (assemblyHashAlgorithm == AssemblyHashAlgorithm.Reserved)
			{
				hashAlgorithm = MD5.Create();
			}
			else
			{
				hashAlgorithm = SHA1.Create();
			}
			byte[] result;
			using (hashAlgorithm)
			{
				result = hashAlgorithm.ComputeHash(this.public_key);
			}
			return result;
		}
		public static AssemblyNameReference Parse(string fullName)
		{
			if (fullName == null)
			{
				throw new ArgumentNullException("fullName");
			}
			if (fullName.Length == 0)
			{
				throw new ArgumentException("Name can not be empty");
			}
			AssemblyNameReference assemblyNameReference = new AssemblyNameReference();
			string[] array = fullName.Split(new char[]
			{
				','
			});
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Trim();
				if (i == 0)
				{
					assemblyNameReference.Name = text;
				}
				else
				{
					string[] array2 = text.Split(new char[]
					{
						'='
					});
					if (array2.Length != 2)
					{
						throw new ArgumentException("Malformed name");
					}
					string a;
					if ((a = array2[0].ToLowerInvariant()) != null)
					{
						if (!(a == "version"))
						{
							if (!(a == "culture"))
							{
								if (a == "publickeytoken")
								{
									string text2 = array2[1];
									if (!(text2 == "null"))
									{
										assemblyNameReference.PublicKeyToken = new byte[text2.Length / 2];
										for (int j = 0; j < assemblyNameReference.PublicKeyToken.Length; j++)
										{
											assemblyNameReference.PublicKeyToken[j] = byte.Parse(text2.Substring(j * 2, 2), NumberStyles.HexNumber);
										}
									}
								}
							}
							else
							{
								assemblyNameReference.Culture = ((array2[1] == "neutral") ? "" : array2[1]);
							}
						}
						else
						{
							assemblyNameReference.Version = new Version(array2[1]);
						}
					}
				}
			}
			return assemblyNameReference;
		}
		internal AssemblyNameReference()
		{
			this.version = Mixin.ZeroVersion;
			this.token = new MetadataToken(TokenType.AssemblyRef);
		}
		public AssemblyNameReference(string name, Version version)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			this.name = name;
			this.version = Mixin.CheckVersion(version);
			this.hash_algorithm = AssemblyHashAlgorithm.None;
			this.token = new MetadataToken(TokenType.AssemblyRef);
		}
		public override string ToString()
		{
			return this.FullName;
		}
	}
}
