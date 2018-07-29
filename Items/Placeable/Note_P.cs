using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Items.Placeable
{
	public class Note_P : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pause Note");
			Tooltip.SetDefault("Pauses music for 1/16 of a beat.");
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
			item.createTile = mod.TileType("Note_P");
		}

	}
}

