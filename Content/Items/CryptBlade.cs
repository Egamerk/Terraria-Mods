using System;

using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CoolSword.Content.Items
{
	public class CryptBlade : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Crypt Blade");
            Tooltip.SetDefault("A crypt blade");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }

        public override void SetDefaults()
        {
            Item.width = 128;
            Item.height = 128;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.useTime = 20;
            Item.useAnimation = 200;

            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 50;
            Item.knockBack = 10f;

            Item.crit = 5;

            Item.value = Item.buyPrice(gold: 50);
            Item.rare = ItemRarityID.Pink;

            Item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.DirtBlock, 5)
                .AddTile(TileID.WorkBenches)
                .Register();
        }
    }
}

