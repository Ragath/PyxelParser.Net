using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Pyxel metadata
    /// </summary>
    public class PyxelData
    {
        /// <summary>
        /// Pyxel version
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// *.pyxel filename without extension
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Tileset
        /// </summary>
        [JsonProperty("tileset")]
        public Tileset Tileset { get; set; }

        /// <summary>
        /// Settings
        /// </summary>
        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        /// <summary>
        /// Palette
        /// </summary>
        [JsonProperty("palette")]
        public Palette Palette { get; set; }

        /// <summary>
        /// Canvas
        /// </summary>
        [JsonProperty("canvas")]
        public Canvas Canvas { get; set; }

        /// <summary>
        /// Animations
        /// </summary>
        [JsonProperty("animations")]
        public Dictionary<int, Animation> Animations { get; set; }
    }
}
