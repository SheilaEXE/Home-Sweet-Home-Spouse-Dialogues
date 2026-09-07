using StardewValley;

namespace TileMarker.Api
{
    /// <summary>Minimal Tile Marker API surface used by this mod.</summary>
    public interface ITileMarkerApi
    {
        void RegisterCategory(string ownerModId, string category, string displayName);

        bool IsTileMarked(string ownerModId, string category, GameLocation location, int x, int y);
    }
}
