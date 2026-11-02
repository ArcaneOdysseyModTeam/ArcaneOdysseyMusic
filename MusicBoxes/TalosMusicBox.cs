using ArcaneOdysseyMusic.MusicBoxes.Tiles;
using Terraria.ModLoader;

namespace ArcaneOdysseyMusic.MusicBoxes
{
	public class TalosMusicBox : MusicBox
	{
		public override int MusicBoxTile => ModContent.TileType<TalosMusicBoxTile>();
		public override MusicTrack Music => MusicTrack.Talos;
	}
}
