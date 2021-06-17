using Editor_Mono.Collections.Generic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
namespace Editor_Mono.Cecil
{
	public abstract class BaseAssemblyResolver : IAssemblyResolver
	{
		private static readonly bool on_mono = Type.GetType("Editor_Mono.Runtime") != null;
		private readonly Collection<string> directories;
		private Collection<string> gac_paths;
		public event AssemblyResolveEventHandler ResolveFailure;
		public void AddSearchDirectory(string directory)
		{
			this.directories.Add(directory);
		}
		public void RemoveSearchDirectory(string directory)
		{
			this.directories.Remove(directory);
		}
		public string[] GetSearchDirectories()
		{
			string[] array = new string[this.directories.size];
			Array.Copy(this.directories.items, array, array.Length);
			return array;
		}
		public virtual AssemblyDefinition Resolve(string fullName)
		{
			return this.Resolve(fullName, new ReaderParameters());
		}
		public virtual AssemblyDefinition Resolve(string fullName, ReaderParameters parameters)
		{
			if (fullName == null)
			{
				throw new ArgumentNullException("fullName");
			}
			return this.Resolve(AssemblyNameReference.Parse(fullName), parameters);
		}
		protected BaseAssemblyResolver()
		{
			this.directories = new Collection<string>(2)
			{
				".",
				"bin"
			};
		}
		private AssemblyDefinition GetAssembly(string file, ReaderParameters parameters)
		{
			if (parameters.AssemblyResolver == null)
			{
				parameters.AssemblyResolver = this;
			}
			return ModuleDefinition.ReadModule(file, parameters).Assembly;
		}
		public virtual AssemblyDefinition Resolve(AssemblyNameReference name)
		{
			return this.Resolve(name, new ReaderParameters());
		}
		public virtual AssemblyDefinition Resolve(AssemblyNameReference name, ReaderParameters parameters)
		{
			if (name == null)
			{
				throw new ArgumentNullException("name");
			}
			if (parameters == null)
			{
				parameters = new ReaderParameters();
			}
			AssemblyDefinition assemblyDefinition = this.SearchDirectory(name, this.directories, parameters);
			if (assemblyDefinition != null)
			{
				return assemblyDefinition;
			}
			if (name.IsRetargetable)
			{
				name = new AssemblyNameReference(name.Name, Mixin.ZeroVersion)
				{
					PublicKeyToken = Empty<byte>.Array
				};
			}
			string directoryName = Path.GetDirectoryName(typeof(object).Module.FullyQualifiedName);
			if (BaseAssemblyResolver.IsZero(name.Version))
			{
				assemblyDefinition = this.SearchDirectory(name, new string[]
				{
					directoryName
				}, parameters);
				if (assemblyDefinition != null)
				{
					return assemblyDefinition;
				}
			}
			if (name.Name == "mscorlib")
			{
				assemblyDefinition = this.GetCorlib(name, parameters);
				if (assemblyDefinition != null)
				{
					return assemblyDefinition;
				}
			}
			assemblyDefinition = this.GetAssemblyInGac(name, parameters);
			if (assemblyDefinition != null)
			{
				return assemblyDefinition;
			}
			assemblyDefinition = this.SearchDirectory(name, new string[]
			{
				directoryName
			}, parameters);
			if (assemblyDefinition != null)
			{
				return assemblyDefinition;
			}
			if (this.ResolveFailure != null)
			{
				assemblyDefinition = this.ResolveFailure(this, name);
				if (assemblyDefinition != null)
				{
					return assemblyDefinition;
				}
			}
			throw new AssemblyResolutionException(name);
		}
		private AssemblyDefinition SearchDirectory(AssemblyNameReference name, IEnumerable<string> directories, ReaderParameters parameters)
		{
			string[] array = name.IsWindowsRuntime ? new string[]
			{
				".winmd",
				".dll"
			} : new string[]
			{
				".exe",
				".dll"
			};
			foreach (string current in directories)
			{
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					string str = array2[i];
					string text = Path.Combine(current, name.Name + str);
					if (File.Exists(text))
					{
						return this.GetAssembly(text, parameters);
					}
				}
			}
			return null;
		}
		private static bool IsZero(Version version)
		{
			return version.Major == 0 && version.Minor == 0 && version.Build == 0 && version.Revision == 0;
		}
		private AssemblyDefinition GetCorlib(AssemblyNameReference reference, ReaderParameters parameters)
		{
			Version version = reference.Version;
			AssemblyName name = typeof(object).Assembly.GetName();
			if (name.Version == version || BaseAssemblyResolver.IsZero(version))
			{
				return this.GetAssembly(typeof(object).Module.FullyQualifiedName, parameters);
			}
			string path = Directory.GetParent(Directory.GetParent(typeof(object).Module.FullyQualifiedName).FullName).FullName;
			if (!BaseAssemblyResolver.on_mono)
			{
				switch (version.Major)
				{
				case 1:
					if (version.MajorRevision == 3300)
					{
						path = Path.Combine(path, "v1.0.3705");
						goto IL_170;
					}
					path = Path.Combine(path, "v1.0.5000.0");
					goto IL_170;
				case 2:
					path = Path.Combine(path, "v2.0.50727");
					goto IL_170;
				case 4:
					path = Path.Combine(path, "v4.0.30319");
					goto IL_170;
				}
				throw new NotSupportedException("Version not supported: " + version);
			}
			if (version.Major == 1)
			{
				path = Path.Combine(path, "1.0");
			}
			else
			{
				if (version.Major == 2)
				{
					if (version.MajorRevision == 5)
					{
						path = Path.Combine(path, "2.1");
					}
					else
					{
						path = Path.Combine(path, "2.0");
					}
				}
				else
				{
					if (version.Major != 4)
					{
						throw new NotSupportedException("Version not supported: " + version);
					}
					path = Path.Combine(path, "4.0");
				}
			}
			IL_170:
			string text = Path.Combine(path, "mscorlib.dll");
			if (File.Exists(text))
			{
				return this.GetAssembly(text, parameters);
			}
			return null;
		}
		private static Collection<string> GetGacPaths()
		{
			if (BaseAssemblyResolver.on_mono)
			{
				return BaseAssemblyResolver.GetDefaultMonoGacPaths();
			}
			Collection<string> collection = new Collection<string>(2);
			string environmentVariable = Environment.GetEnvironmentVariable("WINDIR");
			if (environmentVariable == null)
			{
				return collection;
			}
			collection.Add(Path.Combine(environmentVariable, "assembly"));
			collection.Add(Path.Combine(environmentVariable, Path.Combine("Microsoft.NET", "assembly")));
			return collection;
		}
		private static Collection<string> GetDefaultMonoGacPaths()
		{
			Collection<string> collection = new Collection<string>(1);
			string currentMonoGac = BaseAssemblyResolver.GetCurrentMonoGac();
			if (currentMonoGac != null)
			{
				collection.Add(currentMonoGac);
			}
			string environmentVariable = Environment.GetEnvironmentVariable("MONO_GAC_PREFIX");
			if (string.IsNullOrEmpty(environmentVariable))
			{
				return collection;
			}
			string[] array = environmentVariable.Split(new char[]
			{
				Path.PathSeparator
			});
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = array2[i];
				if (!string.IsNullOrEmpty(text))
				{
					string text2 = Path.Combine(Path.Combine(Path.Combine(text, "lib"), "mono"), "gac");
					if (Directory.Exists(text2) && !collection.Contains(currentMonoGac))
					{
						collection.Add(text2);
					}
				}
			}
			return collection;
		}
		private static string GetCurrentMonoGac()
		{
			return Path.Combine(Directory.GetParent(Path.GetDirectoryName(typeof(object).Module.FullyQualifiedName)).FullName, "gac");
		}
		private AssemblyDefinition GetAssemblyInGac(AssemblyNameReference reference, ReaderParameters parameters)
		{
			if (reference.PublicKeyToken == null || reference.PublicKeyToken.Length == 0)
			{
				return null;
			}
			if (this.gac_paths == null)
			{
				this.gac_paths = BaseAssemblyResolver.GetGacPaths();
			}
			if (BaseAssemblyResolver.on_mono)
			{
				return this.GetAssemblyInMonoGac(reference, parameters);
			}
			return this.GetAssemblyInNetGac(reference, parameters);
		}
		private AssemblyDefinition GetAssemblyInMonoGac(AssemblyNameReference reference, ReaderParameters parameters)
		{
			for (int i = 0; i < this.gac_paths.Count; i++)
			{
				string gac = this.gac_paths[i];
				string assemblyFile = BaseAssemblyResolver.GetAssemblyFile(reference, string.Empty, gac);
				if (File.Exists(assemblyFile))
				{
					return this.GetAssembly(assemblyFile, parameters);
				}
			}
			return null;
		}
		private AssemblyDefinition GetAssemblyInNetGac(AssemblyNameReference reference, ReaderParameters parameters)
		{
			string[] array = new string[]
			{
				"GAC_MSIL",
				"GAC_32",
				"GAC_64",
				"GAC"
			};
			string[] array2 = new string[]
			{
				string.Empty,
				"v4.0_"
			};
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < array.Length; j++)
				{
					string text = Path.Combine(this.gac_paths[i], array[j]);
					string assemblyFile = BaseAssemblyResolver.GetAssemblyFile(reference, array2[i], text);
					if (Directory.Exists(text) && File.Exists(assemblyFile))
					{
						return this.GetAssembly(assemblyFile, parameters);
					}
				}
			}
			return null;
		}
		private static string GetAssemblyFile(AssemblyNameReference reference, string prefix, string gac)
		{
			StringBuilder stringBuilder = new StringBuilder().Append(prefix).Append(reference.Version).Append("__");
			for (int i = 0; i < reference.PublicKeyToken.Length; i++)
			{
				stringBuilder.Append(reference.PublicKeyToken[i].ToString("x2"));
			}
			return Path.Combine(Path.Combine(Path.Combine(gac, reference.Name), stringBuilder.ToString()), reference.Name + ".dll");
		}
	}
}
