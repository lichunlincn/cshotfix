using System;
namespace Editor_Mono.Cecil
{
	public sealed class PInvokeInfo
	{
		private ushort attributes;
		private string entry_point;
		private ModuleReference module;
		public PInvokeAttributes Attributes
		{
			get
			{
				return (PInvokeAttributes)this.attributes;
			}
			set
			{
				this.attributes = (ushort)value;
			}
		}
		public string EntryPoint
		{
			get
			{
				return this.entry_point;
			}
			set
			{
				this.entry_point = value;
			}
		}
		public ModuleReference Module
		{
			get
			{
				return this.module;
			}
			set
			{
				this.module = value;
			}
		}
		public bool IsNoMangle
		{
			get
			{
				return this.attributes.GetAttributes(1);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(1, value);
			}
		}
		public bool IsCharSetNotSpec
		{
			get
			{
				return this.attributes.GetMaskedAttributes(6, 0u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(6, 0u, value);
			}
		}
		public bool IsCharSetAnsi
		{
			get
			{
				return this.attributes.GetMaskedAttributes(6, 2u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(6, 2u, value);
			}
		}
		public bool IsCharSetUnicode
		{
			get
			{
				return this.attributes.GetMaskedAttributes(6, 4u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(6, 4u, value);
			}
		}
		public bool IsCharSetAuto
		{
			get
			{
				return this.attributes.GetMaskedAttributes(6, 6u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(6, 6u, value);
			}
		}
		public bool SupportsLastError
		{
			get
			{
				return this.attributes.GetAttributes(64);
			}
			set
			{
				this.attributes = this.attributes.SetAttributes(64, value);
			}
		}
		public bool IsCallConvWinapi
		{
			get
			{
				return this.attributes.GetMaskedAttributes(1792, 256u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(1792, 256u, value);
			}
		}
		public bool IsCallConvCdecl
		{
			get
			{
				return this.attributes.GetMaskedAttributes(1792, 512u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(1792, 512u, value);
			}
		}
		public bool IsCallConvStdCall
		{
			get
			{
				return this.attributes.GetMaskedAttributes(1792, 768u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(1792, 768u, value);
			}
		}
		public bool IsCallConvThiscall
		{
			get
			{
				return this.attributes.GetMaskedAttributes(1792, 1024u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(1792, 1024u, value);
			}
		}
		public bool IsCallConvFastcall
		{
			get
			{
				return this.attributes.GetMaskedAttributes(1792, 1280u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(1792, 1280u, value);
			}
		}
		public bool IsBestFitEnabled
		{
			get
			{
				return this.attributes.GetMaskedAttributes(48, 16u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(48, 16u, value);
			}
		}
		public bool IsBestFitDisabled
		{
			get
			{
				return this.attributes.GetMaskedAttributes(48, 32u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(48, 32u, value);
			}
		}
		public bool IsThrowOnUnmappableCharEnabled
		{
			get
			{
				return this.attributes.GetMaskedAttributes(12288, 4096u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(12288, 4096u, value);
			}
		}
		public bool IsThrowOnUnmappableCharDisabled
		{
			get
			{
				return this.attributes.GetMaskedAttributes(12288, 8192u);
			}
			set
			{
				this.attributes = this.attributes.SetMaskedAttributes(12288, 8192u, value);
			}
		}
		public PInvokeInfo(PInvokeAttributes attributes, string entryPoint, ModuleReference module)
		{
			this.attributes = (ushort)attributes;
			this.entry_point = entryPoint;
			this.module = module;
		}
	}
}
