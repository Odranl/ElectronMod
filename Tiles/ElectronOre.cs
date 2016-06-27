using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace ElectronMod.Tiles
{
    public class ElectronOre : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            drop = mod.ItemType("ElectronOre");
            AddMapEntry(new Color(200, 200, 200));
            Main.tileSpelunker[Type] = true;
        }
    }
}