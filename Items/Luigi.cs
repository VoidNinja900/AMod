using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AMod.Items
{
	public class Luigi : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SwordOfBasics"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Woah");
			Item.staff[Item.type] = true;
		}

		public override void SetDefaults()
		{
			Item.damage = 300;
			Item.mana = 0;
			Item.DamageType = DamageClass.Magic;
			Item.noMelee = true;
			Item.width = 100;
			Item.height = 50;
			Item.useTime = 10;
			Item.useAnimation = 10;
			Item.useStyle = 5;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item8;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<LuigiProj>();
			Item.shootSpeed = 6f;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}