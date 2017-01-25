using Newtonsoft.Json;

namespace PyxelParser
{
    public class Tileref
    {
        [JsonProperty("index")]
        public int Index { get; set; }
        [JsonProperty("rot")]
        public int Rot { get; set; }
        [JsonProperty("flipX")]
        public bool FlipX { get; set; }
    }
}
