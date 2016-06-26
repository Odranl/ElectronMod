using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectronMod.Items.Weapons
{
    public class ElectronPax : ModItem
    {
       public override void SetDefaults()
       {
          item.name = "Electron Pax";
          item.damage = 35;
          item.melee = true;
          item.width = 32;
          item.height = 32;
          item.toolTip = "This pax is infused with so much energy that it can multi-task...";
          item.useTime = 17;
          item.useAnimation = 20;
          item.pick = 100;
          item.axe = 85;
          item.useStyle = 1;
          item.knockBack = 3;
          item.value = 25000;
          item.rare = 3;
          item.useSound = 1;
          item.autoReuse = true;
          item.useTurn = true;
      }
      public override void AddRecipes()
      {
           ModRecipe recipe = new ModRecipe(mod);
           recipe.AddIngredient(ItemID.Wood, 75);
           recipe.AddTile(TileID.Anvils);
           recipe.SetResult(this);
           recipe.AddRecipe();
         }
     }
}
          
       
