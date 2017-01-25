using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    public class PyxelData
    {
        [JsonProperty("version")]
        public string Version { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("tileset")]
        public Tileset Tileset { get; set; }
        [JsonProperty("settings")]
        public Settings Settings { get; set; }
        [JsonProperty("palette")]
        public Palette Palette { get; set; }
        [JsonProperty("canvas")]
        public Canvas Canvas { get; set; }
        [JsonProperty("animations")]
        public Dictionary<int, Animation> Animations { get; set; }
    }
}
