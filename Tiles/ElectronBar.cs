using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Microsoft.Xna.Framework;

namespace ElectronMod.Tiles
{
    public class ElectronBar : ModTile
    {
        public override void SetDefaults()
        {
			Main.tileSolidTop[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("ElectronBar");
            AddMapEntry(new Color(0, 0, 200));
            Main.tileSpelunker[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.CoordinateHeights = new int[]{ 18 };
			TileObjectData.addTile(Type);
		}
    }
}
