using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    public class Layer
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("alpha")]
        public int Alpha { get; set; }
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }
        [JsonProperty("blendMode")]
        public string BlendMode { get; set; }
        [JsonProperty("tileRefs")]
        public Dictionary<int, Tileref> TileRefs { get; set; }
    }
}
