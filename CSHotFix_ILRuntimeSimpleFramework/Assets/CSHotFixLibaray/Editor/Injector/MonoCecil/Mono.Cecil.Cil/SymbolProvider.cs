using System;
using System.IO;
using System.Reflection;
namespace Editor_Mono.Cecil.Cil
{
	internal static class SymbolProvider
	{
		private static readonly string symbol_kind = (Type.GetType("Editor_Mono.Runtime") != null) ? "Mdb" : "Pdb";
		private static ISymbolReaderProvider reader_provider;
		private static ISymbolWriterProvider writer_provider;
		private static AssemblyName GetPlatformSymbolAssemblyName()
		{
			AssemblyName name = typeof(SymbolProvider).Assembly.GetName();
			AssemblyName assemblyName = new AssemblyName
			{
				Name = "Editor_Mono.Cecil." + SymbolProvider.symbol_kind,
				Version = name.Version
			};
			assemblyName.SetPublicKeyToken(name.GetPublicKeyToken());
			return assemblyName;
		}
		private static Type GetPlatformType(string fullname)
		{
			Type type = Type.GetType(fullname);
			if (type != null)
			{
				return type;
			}
			AssemblyName platformSymbolAssemblyName = SymbolProvider.GetPlatformSymbolAssemblyName();
			type = Type.GetType(fullname + ", " + platformSymbolAssemblyName.FullName);
			if (type != null)
			{
				return type;
			}
			try
			{
				Assembly assembly = Assembly.Load(platformSymbolAssemblyName);
				if (assembly != null)
				{
					return assembly.GetType(fullname);
				}
			}
			catch (FileNotFoundException)
			{
			}
			catch (FileLoadException)
			{
			}
			return null;
		}
		public static ISymbolReaderProvider GetPlatformReaderProvider()
		{
			if (SymbolProvider.reader_provider != null)
			{
				return SymbolProvider.reader_provider;
			}
			Type platformType = SymbolProvider.GetPlatformType(SymbolProvider.GetProviderTypeName("ReaderProvider"));
			if (platformType == null)
			{
				return null;
			}
			return SymbolProvider.reader_provider = (ISymbolReaderProvider)Activator.CreateInstance(platformType);
		}
		private static string GetProviderTypeName(string name)
		{
			return string.Concat(new string[]
			{
				"Editor_Mono.Cecil.",
				SymbolProvider.symbol_kind,
				".",
				SymbolProvider.symbol_kind,
				name
			});
		}
		public static ISymbolWriterProvider GetPlatformWriterProvider()
		{
			if (SymbolProvider.writer_provider != null)
			{
				return SymbolProvider.writer_provider;
			}
			Type platformType = SymbolProvider.GetPlatformType(SymbolProvider.GetProviderTypeName("WriterProvider"));
			if (platformType == null)
			{
				return null;
			}
			return SymbolProvider.writer_provider = (ISymbolWriterProvider)Activator.CreateInstance(platformType);
		}
	}
}
