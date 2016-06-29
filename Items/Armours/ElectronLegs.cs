using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElectronMod
{
	public class ElectronTorso : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Body);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Electron Breastplate";
			item.width = 28;
			item.height = 18;
			item.toolTip = "Your energy armour";
			item.value = 10000;
			item.rare = 2;
			item.defense = 20;

		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ElectronBar"), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

