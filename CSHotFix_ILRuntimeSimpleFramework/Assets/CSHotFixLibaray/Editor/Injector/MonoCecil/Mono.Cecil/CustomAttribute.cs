using Editor_Mono.Collections.Generic;
using System;
namespace Editor_Mono.Cecil
{
	public sealed class CustomAttribute : ICustomAttribute
	{
		internal CustomAttributeValueProjection projection;
		internal readonly uint signature;
		internal bool resolved;
		private MethodReference constructor;
		private byte[] blob;
		internal Collection<CustomAttributeArgument> arguments;
		internal Collection<CustomAttributeNamedArgument> fields;
		internal Collection<CustomAttributeNamedArgument> properties;
		public MethodReference Constructor
		{
			get
			{
				return this.constructor;
			}
			set
			{
				this.constructor = value;
			}
		}
		public TypeReference AttributeType
		{
			get
			{
				return this.constructor.DeclaringType;
			}
		}
		public bool IsResolved
		{
			get
			{
				return this.resolved;
			}
		}
		public bool HasConstructorArguments
		{
			get
			{
				this.Resolve();
				return !this.arguments.IsNullOrEmpty<CustomAttributeArgument>();
			}
		}
		public Collection<CustomAttributeArgument> ConstructorArguments
		{
			get
			{
				this.Resolve();
				Collection<CustomAttributeArgument> arg_1E_0;
				if ((arg_1E_0 = this.arguments) == null)
				{
					arg_1E_0 = (this.arguments = new Collection<CustomAttributeArgument>());
				}
				return arg_1E_0;
			}
		}
		public bool HasFields
		{
			get
			{
				this.Resolve();
				return !this.fields.IsNullOrEmpty<CustomAttributeNamedArgument>();
			}
		}
		public Collection<CustomAttributeNamedArgument> Fields
		{
			get
			{
				this.Resolve();
				Collection<CustomAttributeNamedArgument> arg_1E_0;
				if ((arg_1E_0 = this.fields) == null)
				{
					arg_1E_0 = (this.fields = new Collection<CustomAttributeNamedArgument>());
				}
				return arg_1E_0;
			}
		}
		public bool HasProperties
		{
			get
			{
				this.Resolve();
				return !this.properties.IsNullOrEmpty<CustomAttributeNamedArgument>();
			}
		}
		public Collection<CustomAttributeNamedArgument> Properties
		{
			get
			{
				this.Resolve();
				Collection<CustomAttributeNamedArgument> arg_1E_0;
				if ((arg_1E_0 = this.properties) == null)
				{
					arg_1E_0 = (this.properties = new Collection<CustomAttributeNamedArgument>());
				}
				return arg_1E_0;
			}
		}
		internal bool HasImage
		{
			get
			{
				return this.constructor != null && this.constructor.HasImage;
			}
		}
		internal ModuleDefinition Module
		{
			get
			{
				return this.constructor.Module;
			}
		}
		internal CustomAttribute(uint signature, MethodReference constructor)
		{
			this.signature = signature;
			this.constructor = constructor;
			this.resolved = false;
		}
		public CustomAttribute(MethodReference constructor)
		{
			this.constructor = constructor;
			this.resolved = true;
		}
		public CustomAttribute(MethodReference constructor, byte[] blob)
		{
			this.constructor = constructor;
			this.resolved = false;
			this.blob = blob;
		}
		public byte[] GetBlob()
		{
			if (this.blob != null)
			{
				return this.blob;
			}
			if (!this.HasImage)
			{
				throw new NotSupportedException();
			}
			return this.Module.Read<CustomAttribute, byte[]>(ref this.blob, this, (CustomAttribute attribute, MetadataReader reader) => reader.ReadCustomAttributeBlob(attribute.signature));
		}
		private void Resolve()
		{
			if (this.resolved || !this.HasImage)
			{
				return;
			}
			this.Module.Read<CustomAttribute, CustomAttribute>(this, delegate(CustomAttribute attribute, MetadataReader reader)
			{
				try
				{
					reader.ReadCustomAttributeSignature(attribute);
					this.resolved = true;
				}
				catch (ResolutionException)
				{
					if (this.arguments != null)
					{
						this.arguments.Clear();
					}
					if (this.fields != null)
					{
						this.fields.Clear();
					}
					if (this.properties != null)
					{
						this.properties.Clear();
					}
					this.resolved = false;
				}
				return this;
			});
		}
	}
}
