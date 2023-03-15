using System;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

using System;
namespace CoolSword.Content.Items
{
	public class AriPick : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ari's Pickaxe");
            Tooltip.SetDefault("A pretty good pickaxe");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 26;
            Item.height = 26;

            Item.useStyle = ItemUseStyleID.Swing;

            Item.useTime = 1;
            Item.useAnimation = 1;

            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 500;
            Item.knockBack = 10f;

            Item.crit = 5;

            Item.pick = 9999;
            Item.axe = 9999;

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

