using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ElectronMod.Projectiles
{

    public class ElectronBeam : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "ElectronBeam";
            projectile.width = 32;
            projectile.scale = 0.6f;
            projectile.height = 32;
            projectile.friendly = true;
            projectile.melee = true;
            projectile.tileCollide = true;
            projectile.penetrate = 2;
            projectile.timeLeft = 200;
            projectile.light = 1.25f;
            projectile.extraUpdates = 1;
            projectile.ignoreWater = true;

        }
        public override void AI()
        {
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;
        }
      }
}
            
            
            
    

   