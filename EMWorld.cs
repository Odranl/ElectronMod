using System.IO;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.World.Generation;
using Microsoft.Xna.Framework;
using Terraria.GameContent.Generation;
using System;

namespace ElectronMod
{
    public class EMWorld : ModWorld
    {
        private const int saveVersion = 0;

        public override void ModifyWorldGenTasks(List<GenPass> tasks, ref float totalWeight)
        {
            int ShiniesIndex = tasks.FindIndex(genpass => genpass.Name.Equals("Shinies"));
            if (ShiniesIndex == -1)
            {
                // Shinies pass removed by some other mod.
                return;
            }
            tasks.Insert(ShiniesIndex + 1, new PassLegacy("Electron Ores", delegate (GenerationProgress progress)
            {
                progress.Message = "Placing Electron Ores";

                for (int i = 0; i < (int)((double)(Main.maxTilesX * Main.maxTilesY) * 0.00014); i++)
                {
                    WorldGen.TileRunner(WorldGen.genRand.Next(0, Main.maxTilesX), WorldGen.genRand.Next((int)WorldGen.rockLayer, Main.maxTilesY), (double)WorldGen.genRand.Next(4, 8), WorldGen.genRand.Next(4, 8), mod.TileType("ElectronOre"), false, 0f, 0f, false, true);
                }
            })); 
        }

    }
}