using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Pyxel Animation
    /// </summary>
    public class Animation
    {
        /// <summary>
        /// Animation name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// Position on canvas(map index)
        /// </summary>
        [JsonProperty("baseTile")]
        public int BaseTile { get; set; }
        
        /// <summary>
        /// Frame-count
        /// </summary>
        [JsonProperty("length")]
        public int Length { get; set; }
        
        /// <summary>
        /// Frame duration(ms)
        /// </summary>
        [JsonProperty("frameDuration")]
        public int FrameDuration { get; set; }
        
        /// <summary>
        /// Frame duration percentages
        /// </summary>
        [JsonProperty("frameDurationMultipliers")]
        public int[] FrameDurationMultipliers { get; set; }
    }
}
