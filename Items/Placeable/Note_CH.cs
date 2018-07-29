using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Items.Placeable
{
	public class Note_CH : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Closed Hi-hat");
			Tooltip.SetDefault("Plays a closed hi-hat hit");
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
			item.UseSound = mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/CH");
			item.createTile = mod.TileType("Note_CH");
		}

	}
}

