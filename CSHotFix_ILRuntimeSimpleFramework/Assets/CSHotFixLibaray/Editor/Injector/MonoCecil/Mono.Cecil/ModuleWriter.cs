using Editor_Mono.Cecil.Cil;
using Editor_Mono.Cecil.PE;
using System;
using System.IO;
namespace Editor_Mono.Cecil
{
	internal static class ModuleWriter
	{
		public static void WriteModuleTo(ModuleDefinition module, Stream stream, WriterParameters parameters)
		{
			if ((module.Attributes & ModuleAttributes.ILOnly) == (ModuleAttributes)0)
			{
				throw new NotSupportedException("Writing mixed-mode assemblies is not supported");
			}
			if (module.HasImage && module.ReadingMode == ReadingMode.Deferred)
			{
				ImmediateModuleReader immediateModuleReader = new ImmediateModuleReader(module.Image);
				immediateModuleReader.ReadModule(module, false);
			}
			module.MetadataSystem.Clear();
			AssemblyNameDefinition assemblyNameDefinition = (module.assembly != null) ? module.assembly.Name : null;
			string fullyQualifiedName = stream.GetFullyQualifiedName();
			ISymbolWriterProvider symbolWriterProvider = parameters.SymbolWriterProvider;
			if (symbolWriterProvider == null && parameters.WriteSymbols)
			{
				symbolWriterProvider = SymbolProvider.GetPlatformWriterProvider();
			}
			ISymbolWriter symbolWriter = ModuleWriter.GetSymbolWriter(module, fullyQualifiedName, symbolWriterProvider);
			if (parameters.StrongNameKeyPair != null && assemblyNameDefinition != null)
			{
				assemblyNameDefinition.PublicKey = parameters.StrongNameKeyPair.PublicKey;
				module.Attributes |= ModuleAttributes.StrongNameSigned;
			}
			MetadataBuilder metadata = new MetadataBuilder(module, fullyQualifiedName, symbolWriterProvider, symbolWriter);
			ModuleWriter.BuildMetadata(module, metadata);
			if (module.symbol_reader != null)
			{
				module.symbol_reader.Dispose();
			}
			ImageWriter imageWriter = ImageWriter.CreateWriter(module, metadata, stream);
			imageWriter.WriteImage();
			if (parameters.StrongNameKeyPair != null)
			{
				CryptoService.StrongName(stream, imageWriter, parameters.StrongNameKeyPair);
			}
			if (symbolWriter != null)
			{
				symbolWriter.Dispose();
			}
		}
		private static void BuildMetadata(ModuleDefinition module, MetadataBuilder metadata)
		{
			if (!module.HasImage)
			{
				metadata.BuildMetadata();
				return;
			}
			module.Read<MetadataBuilder, MetadataBuilder>(metadata, delegate(MetadataBuilder builder, MetadataReader _)
			{
				builder.BuildMetadata();
				return builder;
			});
		}
		private static ISymbolWriter GetSymbolWriter(ModuleDefinition module, string fq_name, ISymbolWriterProvider symbol_writer_provider)
		{
			if (symbol_writer_provider == null)
			{
				return null;
			}
			return symbol_writer_provider.GetSymbolWriter(module, fq_name);
		}
	}
}
