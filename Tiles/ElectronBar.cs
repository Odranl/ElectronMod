using System;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace ElectronMod.Tiles
{
    public class ElectronBar : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("ElectronBar");
            AddMapEntry(new Color(0, 0, 200));
            Main.tileSpelunker[Type] = true;
        }
    }
}
