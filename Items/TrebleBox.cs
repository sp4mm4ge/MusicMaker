using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Utilities;
using Terraria.ModLoader;

namespace MusicMaker.Items
{
	public class TrebleBox : ModItem
	{

		//Text: Arial 24pt
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Music Note Box");
			Tooltip.SetDefault("Right click for a bundle of music notes.");
		}

		public override void SetDefaults()
		{
			item.width = 10;
			item.height = 10;
		//	item.maxStack = 1;
		//	item.consumable = true;
		}

        public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
            
            int idx = Main.rand.Next(31)+50;
            for(int x=0;x<idx;x++){
                int choice = Main.rand.Next(12);
                switch(choice){
                    case 0:
                        player.QuickSpawnItem(mod.ItemType("Note_A"));
                        break;
                    case 1:
                        player.QuickSpawnItem(mod.ItemType("Note_AS"));
                        break;
                    case 2:
                        player.QuickSpawnItem(mod.ItemType("Note_B"));
                        break;
                    case 3:
                        player.QuickSpawnItem(mod.ItemType("Note_C"));
                        break;
                    case 4:
                        player.QuickSpawnItem(mod.ItemType("Note_CS"));
                        break;
                    case 5:
                        player.QuickSpawnItem(mod.ItemType("Note_D"));
                        break;
                    case 6:
                        player.QuickSpawnItem(mod.ItemType("Note_DS"));
                        break;
                    case 7:
                        player.QuickSpawnItem(mod.ItemType("Note_E"));
                        break;
                    case 8:
                        player.QuickSpawnItem(mod.ItemType("Note_F"));
                        break;
                    case 9:
                        player.QuickSpawnItem(mod.ItemType("Note_FS"));
                        break;
                    case 10:
                        player.QuickSpawnItem(mod.ItemType("Note_G"));
                        break;
                    case 11:
                        player.QuickSpawnItem(mod.ItemType("Note_GS"));
                        break;

                }
            }
            idx = Main.rand.Next(50)+50;
            for(int x=0;x<idx;x++)
                player.QuickSpawnItem(mod.ItemType("Note_P"));
		}
	}
}

