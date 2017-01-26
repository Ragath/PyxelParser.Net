using Newtonsoft.Json;

namespace PyxelParser
{
    /// <summary>
    /// Editor Settings
    /// </summary>
    public class Settings
    {
        /// <summary>
        /// ???
        /// </summary>
        [JsonProperty("ExportAnimationDialog_prefTabIndex")]
        public string ExportAnimationDialog_prefTabIndex { get; set; }
    }
}
