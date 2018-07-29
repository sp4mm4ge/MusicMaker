using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Items.Placeable
{
	public class Note_K : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Kick");
			Tooltip.SetDefault("Plays a bass drum kick");
		}

		public override void SetDefaults()
		{
			item.width = 3;
			item.height = 3;
			item.maxStack = 99;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.useStyle = 1;
			item.consumable = true;
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/K");
			item.createTile = mod.TileType("Note_K");
		}

	}
}

