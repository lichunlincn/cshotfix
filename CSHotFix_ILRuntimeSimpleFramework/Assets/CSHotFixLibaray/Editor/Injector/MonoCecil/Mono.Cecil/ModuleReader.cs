using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil
{
	internal abstract class ModuleReader
	{
		protected readonly Image image;
		protected readonly ModuleDefinition module;
		protected ModuleReader(Image image, ReadingMode mode)
		{
			this.image = image;
			this.module = new ModuleDefinition(image);
			this.module.ReadingMode = mode;
		}
		protected abstract void ReadModule();
		protected void ReadModuleManifest(MetadataReader reader)
		{
			reader.Populate(this.module);
			this.ReadAssembly(reader);
		}
		private void ReadAssembly(MetadataReader reader)
		{
			AssemblyNameDefinition assemblyNameDefinition = reader.ReadAssemblyNameDefinition();
			if (assemblyNameDefinition == null)
			{
				this.module.kind = ModuleKind.NetModule;
				return;
			}
			AssemblyDefinition assemblyDefinition = new AssemblyDefinition();
			assemblyDefinition.Name = assemblyNameDefinition;
			this.module.assembly = assemblyDefinition;
			assemblyDefinition.main_module = this.module;
		}
		public static ModuleDefinition CreateModuleFrom(Image image, ReaderParameters parameters)
		{
			ModuleReader moduleReader = ModuleReader.CreateModuleReader(image, parameters.ReadingMode);
			ModuleDefinition moduleDefinition = moduleReader.module;
			if (parameters.assembly_resolver != null)
			{
				moduleDefinition.assembly_resolver = parameters.assembly_resolver;
			}
			if (parameters.metadata_resolver != null)
			{
				moduleDefinition.metadata_resolver = parameters.metadata_resolver;
			}
			if (parameters.metadata_importer_provider != null)
			{
				moduleDefinition.metadata_importer = parameters.metadata_importer_provider.GetMetadataImporter(moduleDefinition);
			}
			if (parameters.reflection_importer_provider != null)
			{
				moduleDefinition.reflection_importer = parameters.reflection_importer_provider.GetReflectionImporter(moduleDefinition);
			}
			ModuleReader.GetMetadataKind(moduleDefinition, parameters);
			moduleReader.ReadModule();
			ModuleReader.ReadSymbols(moduleDefinition, parameters);
			return moduleDefinition;
		}
		private static void ReadSymbols(ModuleDefinition module, ReaderParameters parameters)
		{
			ISymbolReaderProvider symbolReaderProvider = parameters.SymbolReaderProvider;
			if (symbolReaderProvider == null && parameters.ReadSymbols)
			{
				symbolReaderProvider = SymbolProvider.GetPlatformReaderProvider();
			}
			if (symbolReaderProvider != null)
			{
				module.SymbolReaderProvider = symbolReaderProvider;
				ISymbolReader reader = (parameters.SymbolStream != null) ? symbolReaderProvider.GetSymbolReader(module, parameters.SymbolStream) : symbolReaderProvider.GetSymbolReader(module, module.FullyQualifiedName);
				module.ReadSymbols(reader);
			}
		}
		private static void GetMetadataKind(ModuleDefinition module, ReaderParameters parameters)
		{
			if (!parameters.ApplyWindowsRuntimeProjections)
			{
				module.MetadataKind = MetadataKind.Ecma335;
				return;
			}
			string runtimeVersion = module.RuntimeVersion;
			if (!runtimeVersion.Contains("WindowsRuntime"))
			{
				module.MetadataKind = MetadataKind.Ecma335;
				return;
			}
			if (runtimeVersion.Contains("CLR"))
			{
				module.MetadataKind = MetadataKind.ManagedWindowsMetadata;
				return;
			}
			module.MetadataKind = MetadataKind.WindowsMetadata;
		}
		private static ModuleReader CreateModuleReader(Image image, ReadingMode mode)
		{
			switch (mode)
			{
			case ReadingMode.Immediate:
				return new ImmediateModuleReader(image);
			case ReadingMode.Deferred:
				return new DeferredModuleReader(image);
			default:
				throw new ArgumentException();
			}
		}
	}
}
