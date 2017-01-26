using System.Collections.Generic;
using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Pyxel Palette
    /// </summary>
    public class Palette
    {
        /// <summary>
        /// Columns
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// Rows
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }

        /// <summary>
        /// Color-count
        /// </summary>
        [JsonProperty("numColors")]
        public int NumColors { get; set; }

        /// <summary>
        /// Colors in hexadecimal AARRGGBB format
        /// </summary>
        [JsonProperty("colors")]
        public Dictionary<int, string> Colors { get; set; }
    }
}
