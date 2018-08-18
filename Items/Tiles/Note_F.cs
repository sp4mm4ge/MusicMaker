using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MusicMaker.Items.Tiles
{
	public class Note_F : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.Origin = new Point16(0, 1);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide,1,0);
        	//  TileObjectData.newTile.UsesCustomCanPlace = true;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("F Note");
			AddMapEntry(new Color(50, 50, 200),name);
			//SetModTree(new ExampleTree());
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 32, mod.ItemType("Note_F"));
		}

		public override void RightClick(int i, int j) 	{
			Tile tile = Main.tile[i,j];
			int x = i-tile.frameX/18;
			int y = j-tile.frameY/18;
			Main.tile[x,y].type = (ushort)mod.TileType("Note_F_Up");
			Main.tile[x+1,y].type = (ushort)mod.TileType("Note_F_Up");
			Main.tile[x,y+1].type = (ushort)mod.TileType("Note_F_Up");
			Main.tile[x+1,y+1].type = (ushort)mod.TileType("Note_F_Up");
			MusicMaker.isHigh = true;
			MusicMaker.isLow = false;
			Main.PlaySound(mod.GetLegacySoundSlot(SoundType.Custom, "Sounds/F")); 
		}
	}
}