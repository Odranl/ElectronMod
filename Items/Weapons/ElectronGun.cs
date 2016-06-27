using System;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
namespace ElectronMod.Items.Weapons
{
    class ElectronGun : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Electron Gun";
            item.damage = 25;
            item.ranged = true;
            item.width = 44;
            item.height = 32;
            item.toolTip = "Powerful Gun."; // Random Tooltip :P
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true; // The item's animation must not do damage
            item.knockBack = 4;
            item.value = 50000;
            item.rare = 2;
            item.useSound = 11;
            item.autoReuse = true;
            item.shoot = ProjectileID.Bullet; // In future might be a custom Projectile 
            item.shootSpeed = 16f;
            item.useAmmo = ProjectileID.Bullet;
        }

        public override void AddRecipes()
        {
            ModRecipe modRecipe = new ModRecipe(mod);
            modRecipe.AddIngredient(ItemID.PhoenixBlaster, 1); // Of course change with whatever you want
            modRecipe.AddIngredient(mod.ItemType("ElectronBar"), 10);
            modRecipe.AddTile(TileID.Anvils);
            modRecipe.SetResult(this);
            modRecipe.AddRecipe();
        }
    }
}
