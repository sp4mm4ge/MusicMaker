using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;
using System.Diagnostics;

namespace MusicMaker.Items.Tiles
{
	public class Music_Play_120 : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
			TileObjectData.newTile.Origin = new Point16(0,0);
			TileObjectData.newTile.AnchorBottom = new AnchorData(AnchorType.SolidTile | AnchorType.SolidWithTop | AnchorType.SolidSide,0,0);
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Silver Music Player");
            drop = mod.ItemType("Music_Play_120");
			AddMapEntry(new Color(50, 50, 200),name);
		}

		public override void HitWire(int i, int j)
		{
			if(!Main.dedServ){
				if(MusicMaker.musicPlaying || MusicMaker.notesActive >= 10)
					return;
				MusicMaker.tempo = 120;
				MusicMaker.curTileX[MusicMaker.notesActive] = i-1;
				MusicMaker.curTileY[MusicMaker.notesActive] = j-1;
				MusicMaker.isBass[MusicMaker.notesActive] = false;
				MusicMaker.notesActive++;
				MusicMaker.timer = new Stopwatch();
				MusicMaker.timer.Start();
			}
			else{
				ModPacket packet = mod.GetPacket();
				packet.Write((byte)0);
				packet.Write((int)120);
				packet.Write((byte)0);
				packet.Write((int)i);
				packet.Write((int)j);
				packet.Send();
			}
		}
	}
}