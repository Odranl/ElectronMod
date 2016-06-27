using System;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElectronMod.Items.Placeables
{
    class ElectronBar : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Electron Bar";
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            AddTooltip("Imbued with energy");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("ElectronBar");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("ElectronOre"), 4);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
