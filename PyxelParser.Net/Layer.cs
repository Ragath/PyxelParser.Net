using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Canvas Layer
    /// </summary>
    public class Layer
    {
        /// <summary>
        /// Layer Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Transparency
        /// </summary>
        [JsonProperty("alpha")]
        public byte Alpha { get; set; }

        /// <summary>
        /// Hidden
        /// </summary>
        [JsonProperty("hidden")]
        public bool Hidden { get; set; }

        /// <summary>
        /// BlendMode name
        /// </summary>
        [JsonProperty("blendMode")]
        public string BlendMode { get; set; }

        /// <summary>
        /// Tile references
        /// </summary>
        [JsonProperty("tileRefs")]
        public Dictionary<int, Tileref> TileRefs { get; set; }
    }
}
