using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.ModLoader;

namespace MusicMaker.Items
{
	public class DrumBox : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Drum Box");
			Tooltip.SetDefault("Right click for a bundle of percussion notes.");
		}

		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 10;
		}

        public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
            
            int idx = Main.rand.Next(31)+50;
            for(int x=0;x<idx;x++){
                int choice = Main.rand.Next(5);
                switch(choice){
                    case 0:
                        player.QuickSpawnItem(mod.ItemType("Note_K"));
                        break;
                    case 1:
                        player.QuickSpawnItem(mod.ItemType("Note_S"));
                        break;
                    case 2:
                        player.QuickSpawnItem(mod.ItemType("Note_LT"));
                        break;
                    case 3:
                        player.QuickSpawnItem(mod.ItemType("Note_MT"));
                        break;
                    case 4:
                        player.QuickSpawnItem(mod.ItemType("Note_HT"));
                        break;
                }
            }

            idx = Main.rand.Next(31)+40;
            for(int x=0;x<idx;x++){
                int choice = Main.rand.Next(2);
                switch(choice){
                    case 0:
                        player.QuickSpawnItem(mod.ItemType("Note_CH"));
                        break;
                    case 1:
                        player.QuickSpawnItem(mod.ItemType("Note_OH"));
                        break;
                }
            }
		}
	}
}

