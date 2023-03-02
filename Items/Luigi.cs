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
			Tooltip.SetDefault("This is a basic modded sword, congrats.");
		}

		public override void SetDefaults()
		{
			Item.damage = 300;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 100;
			Item.useAnimation = 100;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
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