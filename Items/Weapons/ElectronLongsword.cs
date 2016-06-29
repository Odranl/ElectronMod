using Terraria.ID;
using Terraria.ModLoader;

namespace ElectronMod.Items.Weapons
{
	public class ElectronLongsword : ModItem
	{
		public override void SetDefaults()
		{
            projOnSwing = true;
            item.name = "Electron Blade";
			item.damage = 23;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.toolTip = "This blade is infused with too much energy...";
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2;
			item.value = 10000;
			item.rare = 2;
			item.useSound = 15;
			item.autoReuse = true;
			item.useTurn = true;
			item.shoot = mod.ProjectileType("ElectronBeam");
			item.shootSpeed = 7;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DirtBlock, 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}