using System;
namespace Editor_Mono.Cecil
{
	public sealed class ModuleParameters
	{
		private ModuleKind kind;
		private TargetRuntime runtime;
		private TargetArchitecture architecture;
		private IAssemblyResolver assembly_resolver;
		private IMetadataResolver metadata_resolver;
		private IMetadataImporterProvider metadata_importer_provider;
		private IReflectionImporterProvider reflection_importer_provider;
		public ModuleKind Kind
		{
			get
			{
				return this.kind;
			}
			set
			{
				this.kind = value;
			}
		}
		public TargetRuntime Runtime
		{
			get
			{
				return this.runtime;
			}
			set
			{
				this.runtime = value;
			}
		}
		public TargetArchitecture Architecture
		{
			get
			{
				return this.architecture;
			}
			set
			{
				this.architecture = value;
			}
		}
		public IAssemblyResolver AssemblyResolver
		{
			get
			{
				return this.assembly_resolver;
			}
			set
			{
				this.assembly_resolver = value;
			}
		}
		public IMetadataResolver MetadataResolver
		{
			get
			{
				return this.metadata_resolver;
			}
			set
			{
				this.metadata_resolver = value;
			}
		}
		public IMetadataImporterProvider MetadataImporterProvider
		{
			get
			{
				return this.metadata_importer_provider;
			}
			set
			{
				this.metadata_importer_provider = value;
			}
		}
		public IReflectionImporterProvider ReflectionImporterProvider
		{
			get
			{
				return this.reflection_importer_provider;
			}
			set
			{
				this.reflection_importer_provider = value;
			}
		}
		public ModuleParameters()
		{
			this.kind = ModuleKind.Dll;
			this.Runtime = ModuleParameters.GetCurrentRuntime();
			this.architecture = TargetArchitecture.I386;
		}
		private static TargetRuntime GetCurrentRuntime()
		{
			return typeof(object).Assembly.ImageRuntimeVersion.ParseRuntime();
		}
	}
}
