using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElectronMod
{
	public class ElectronHelmet : ModItem
	{
		// WIP
		/*
		public override bool Autoload(ref string name, ref string texture, IList<EquipType> equips)
		{
			equips.Add(EquipType.Head);
			return true;
		}

		public override void SetDefaults()
		{
			item.name = "Electron Helmet";
			item.width = 28;
			item.height = 18;
			item.toolTip = "Powered helmet";
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

		public override bool IsArmorSet (Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType ("ElectronTorso") && legs.type == mod.ItemType ("ElectronLegs");
		}

		public override void UpdateArmorSet (Player player)
		{
			player.setBonus ="Powered up";
			// Bonuses...
		}*/
	}
}

