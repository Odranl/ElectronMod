using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElectronMod
{
	public class ElectronLegs : ModItem
	{
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Legs);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Electron Legs";
			item.width = 28;
			item.height = 18;
			item.toolTip = "Your power armour";
			item.value = 10000;
			item.rare = 2;
			item.defense = 15;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.ItemType("ElectronBar"), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

