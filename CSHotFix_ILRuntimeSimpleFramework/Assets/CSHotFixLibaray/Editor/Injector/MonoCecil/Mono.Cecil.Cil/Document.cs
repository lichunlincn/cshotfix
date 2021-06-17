using System;
namespace Editor_Mono.Cecil.Cil
{
	public sealed class Document
	{
		private string url;
		private byte type;
		private byte hash_algorithm;
		private byte language;
		private byte language_vendor;
		private byte[] hash;
		public string Url
		{
			get
			{
				return this.url;
			}
			set
			{
				this.url = value;
			}
		}
		public DocumentType Type
		{
			get
			{
				return (DocumentType)this.type;
			}
			set
			{
				this.type = (byte)value;
			}
		}
		public DocumentHashAlgorithm HashAlgorithm
		{
			get
			{
				return (DocumentHashAlgorithm)this.hash_algorithm;
			}
			set
			{
				this.hash_algorithm = (byte)value;
			}
		}
		public DocumentLanguage Language
		{
			get
			{
				return (DocumentLanguage)this.language;
			}
			set
			{
				this.language = (byte)value;
			}
		}
		public DocumentLanguageVendor LanguageVendor
		{
			get
			{
				return (DocumentLanguageVendor)this.language_vendor;
			}
			set
			{
				this.language_vendor = (byte)value;
			}
		}
		public byte[] Hash
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
		public Document(string url)
		{
			this.url = url;
			this.hash = Empty<byte>.Array;
		}
	}
}
