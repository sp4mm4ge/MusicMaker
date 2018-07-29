using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Items.Placeable
{
	public class Music_Play_80 : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bronze Music Player");
			Tooltip.SetDefault("Power this to play music notes or drums at 80 BPM.");
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
			item.createTile = mod.TileType("Music_Play_80");
		}

	}
}

