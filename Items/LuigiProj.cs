using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;

namespace AMod.Items
{
	public class LuigiProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Luiginary Holy Bullet");
		}

		public override void SetDefaults()
		{
            Projectile.DamageType = DamageClass.Magic;
			Projectile.width = 50;
			Projectile.height = 50;
            Projectile.aiStyle = 0;
            Projectile.friendly = true;
            Projectile.hostile = false;
            Projectile.penetrate = 1;
            Projectile.timeLeft = 600;
            Projectile.light = 2f;
            Projectile.ignoreWater = false;
            Projectile.tileCollide = true;
		}

        public override void AI()
        {
            int dust = Dust.NewDust(Projectile.Center, 1, 1, 15, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].velocity *= 0.2f;
            Main.dust[dust].scale = (float)Main.rand.Next(80,115) * 0.013f;
            Main.dust[dust].noGravity = true;
        }


	}
}