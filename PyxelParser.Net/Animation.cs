using Newtonsoft.Json;

namespace PyxelParser
{
    public class Animation
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        
        [JsonProperty("baseTile")]
        public int BaseTile { get; set; }
        
        [JsonProperty("length")]
        public int Length { get; set; }
        
        [JsonProperty("frameDuration")]
        public int FrameDuration { get; set; }
        
        [JsonProperty("frameDurationMultipliers")]
        public int[] FrameDurationMultipliers { get; set; }
    }
}
