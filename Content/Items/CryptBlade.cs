using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;

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

        public override Vector2? HoldoutOffset()
        {
			return new Vector2(0f, 0f);
		}

        public override void SetDefaults()
        {
            Item.width = 128;
            Item.height = 128;

            Item.useStyle = ItemUseStyleID.Swing;
            
            Item.useTime = 20;
            Item.useAnimation = 150;

            Item.autoReuse = false;

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

