using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace CoolSword.Content.Items
{
	public class AriSword : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ari's Sword");
            Tooltip.SetDefault("A pretty cool Sword");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;


        }
        
        public override void SetDefaults()
        {
            Item.width = 62;
            Item.height = 62;

            Item.useStyle = ItemUseStyleID.Swing;
            
            Item.useTime = 10;
            Item.useAnimation = 10;

            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 500;
            Item.knockBack = 10f;

            Item.crit = 5;

            Item.value = Item.buyPrice(gold: 50);
            Item.rare = ItemRarityID.Purple;

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

