using Microsoft.Xna.Framework.Audio;
using Terraria;
using Terraria.ModLoader;

namespace MusicMaker.Sounds
{
	public class C : ModSound
	{
		public override SoundEffectInstance PlaySound(ref SoundEffectInstance soundInstance, float volume, float pan, SoundType type)
		{
			soundInstance = sound.CreateInstance();
			soundInstance.Pitch = MusicMaker.isHigh?1:(MusicMaker.isLow?-1:0);
			return soundInstance;
		}
	}
}