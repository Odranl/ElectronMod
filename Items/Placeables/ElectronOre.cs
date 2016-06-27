using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElectronMod.Items.Placeables
{
    class ElectronOre : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Electron Ore";
            item.maxStack = 999;
            item.width = 12;
            item.height = 12;
            AddTooltip("Imbued with energy");
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.createTile = mod.TileType("ElectronOre");
        }
    }
}
