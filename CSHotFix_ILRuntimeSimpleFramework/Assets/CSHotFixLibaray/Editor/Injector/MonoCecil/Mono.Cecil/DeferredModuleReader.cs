using Editor_Mono.Cecil.PE;
using System;
namespace Editor_Mono.Cecil
{
	internal sealed class DeferredModuleReader : ModuleReader
	{
		public DeferredModuleReader(Image image) : base(image, ReadingMode.Deferred)
		{
		}
		protected override void ReadModule()
		{
			this.module.Read<ModuleDefinition, ModuleDefinition>(this.module, delegate(ModuleDefinition module, MetadataReader reader)
			{
				base.ReadModuleManifest(reader);
				return module;
			});
		}
	}
}
