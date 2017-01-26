using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Reference to Tileset tile
    /// </summary>
    public class Tileref
    {
        /// <summary>
        /// Tile-index, 0-based, left-right, top-bottom
        /// </summary>
        [JsonProperty("index")]
        public int Index { get; set; }

        /// <summary>
        /// Rotation, 90-degree increments, (0-2)
        /// </summary>
        [JsonProperty("rot")]
        public byte Rot { get; set; }

        /// <summary>
        /// Flip tile horizontally
        /// </summary>
        [JsonProperty("flipX")]
        public bool FlipX { get; set; }
    }
}
