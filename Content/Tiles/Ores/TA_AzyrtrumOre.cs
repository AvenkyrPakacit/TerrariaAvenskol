using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Microsoft.Xna.Framework;

namespace TerrariaAvenskol.Content.Tiles.Ores
{
    internal class TA_AzyrtrumOre : ModTile
    {
        public override void SetStaticDefaults()
        {
            TileID.Sets.Ore[Type] = true;

            Main.tileSolid[Type] = true;
            Main.tileMergeDirt[Type] = true;
            Main.tileBlockLight[Type] = true;
            Main.tileShine[Type] = 900;
            Main.tileShine2[Type] = true;
            Main.tileSpelunker[Type] = true;
            Main.tileOreFinderPriority[Type] = 350;

            AddMapEntry(new Color(189, 80, 208), CreateMapEntryName());

            DustType = DustID.Gold;

            HitSound = SoundID.Tink;

            MineResist = 1.5f;
            MinPick = 47;
        }
    }
}
