using Terraria;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ID;
using Terraria.ModLoader;

namespace TerrariaAvenskol.Content.Tiles.Workshops
{
    internal class TA_IkyriumAnvil : ModTile
    {
        public override void SetStaticDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileSolidTop[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            Main.tileTable[Type] = false;

            TileID.Sets.DisableSmartCursor[Type] = true;
            TileID.Sets.IgnoredByNpcStepUp[Type] = true;

            AdjTiles = new int[] { TileID.Anvils };

            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
            TileObjectData.newTile.CoordinateHeights = new[] { 18 };
            TileObjectData.addTile(Type);

            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);

            AddMapEntry(new Microsoft.Xna.Framework.Color(200, 200, 200), CreateMapEntryName());
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int itemType = ModContent.ItemType<Items.Placeables.Workshops.TA_IkyriumAnvil>();

            Item.NewItem(
                new EntitySource_TileBreak(i, j),
                i * 16,
                j * 16,
                32,
                16,
                itemType
            );
        }
    }
}
