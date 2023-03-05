using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AMod.Items
{
	public class GoBYEBYE : ModItem
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("SwordOfBasics"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Send your enemies sky high!");
		}

		public override void SetDefaults()
		{
			Item.damage = 100;
			Item.DamageType = DamageClass.Melee;
			Item.width = 70;
			Item.height = 70;
			Item.useTime = 5;
			Item.useAnimation = 5;
			Item.useStyle = 1;
			Item.mana = 0;
			Item.knockBack = 100000;
			Item.value = 10000;
			Item.rare = 2;
			Item.UseSound = SoundID.Item71;
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