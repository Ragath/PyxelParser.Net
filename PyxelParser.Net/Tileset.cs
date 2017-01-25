using Newtonsoft.Json;

namespace PyxelParser
{
    public class Tileset
    {
        [JsonProperty("tileWidth")]
        public int TileWidth { get; set; }
        [JsonProperty("tileHeight")]
        public int TileHeight { get; set; }
        [JsonProperty("tilesWide")]
        public int TilesWide { get; set; }
        [JsonProperty("fixedWidth")]
        public bool FixedWidth { get; set; }
        [JsonProperty("numTiles")]
        public int NumTiles { get; set; }
    }
}
