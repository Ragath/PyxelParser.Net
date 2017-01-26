using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Pyxel Canvas
    /// </summary>
    public class Canvas
    {
        /// <summary>
        /// Canvas width in pixels
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// Canvas height in pixels
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

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
        /// Layer-count
        /// </summary>
        [JsonProperty("numLayers")]
        public int NumLayers { get; set; }
        /// <summary>
        /// Layers
        /// </summary>
        [JsonProperty("layers")]
        public Dictionary<int, Layer> Layers { get; set; }
    }

}
