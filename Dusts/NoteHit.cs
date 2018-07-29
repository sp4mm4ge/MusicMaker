using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Dusts
{
	public class NoteHit : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
            dust.noGravity = true;
			dust.frame = new Rectangle(0, 0, 10, 10);
			dust.velocity.X = Main.rand.Next(4)*(Main.rand.Next(2)==0?1:-1);
			dust.velocity.Y = Main.rand.Next(4)*(Main.rand.Next(2)==0?1:-1);
            Lighting.AddLight(dust.position, 0.5f, 0.5f, 0.5f);
		}
	}
}