using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Pyxel Tileset
    /// </summary>
    public class Tileset
    {
        /// <summary>
        /// Tile width in pixels
        /// </summary>
        [JsonProperty("tileWidth")]
        public int TileWidth { get; set; }
        /// <summary>
        /// Tile height in pixels
        /// </summary>
        [JsonProperty("tileHeight")]
        public int TileHeight { get; set; }

        /// <summary>
        /// Column-count in Tileset view
        /// </summary>
        [JsonProperty("tilesWide")]
        public int TilesWide { get; set; }
        /// <summary>
        /// Fixed column-count Tileset view
        /// </summary>
        [JsonProperty("fixedWidth")]
        public bool FixedWidth { get; set; }

        /// <summary>
        /// Number of tiles in Tileset
        /// </summary>
        [JsonProperty("numTiles")]
        public int NumTiles { get; set; }
    }
}
