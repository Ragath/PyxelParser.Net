using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    public class Palette
    {
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("numColors")]
        public int NumColors { get; set; }
        [JsonProperty("colors")]
        public Dictionary<int, string> Colors { get; set; }
    }
}
