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
            DisplayName.SetDefault("Test Sword");
            Tooltip.SetDefault("Test Sword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.useTime = 60;
            Item.useAnimation = 500;

            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 50;
            Item.knockBack = 4f;

            Item.crit = 5;

            Item.value = Item.buyPrice(gold: 5);
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

