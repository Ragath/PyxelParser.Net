using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{

    public class Canvas
    {
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("tileWidth")]
        public int TileWidth { get; set; }
        [JsonProperty("tileHeight")]
        public int TileHeight { get; set; }

        [JsonProperty("numLayers")]
        public int NumLayers { get; set; }
        [JsonProperty("layers")]
        public Dictionary<int, Layer> Layers { get; set; }
    }

}
