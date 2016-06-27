using Terraria.ModLoader;

namespace ElectronMod
{
	class ElectronMod : Mod
	{
		public ElectronMod()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
