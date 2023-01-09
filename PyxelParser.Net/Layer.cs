namespace PyxelParser;

/// <summary>
/// Canvas Layer
/// </summary>
public class Layer
{
    /// <summary>
    /// Layer Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Transparency
    /// </summary>
    [JsonPropertyName("alpha")]
    public byte Alpha { get; set; }

    /// <summary>
    /// Hidden
    /// </summary>
    [JsonPropertyName("hidden")]
    public bool Hidden { get; set; }

    /// <summary>
    /// BlendMode name
    /// </summary>
    [JsonPropertyName("blendMode")]
    public string BlendMode { get; set; } = null!;

    /// <summary>
    /// Tile references
    /// </summary>
    [JsonPropertyName("tileRefs")]
    public Dictionary<int, Tileref> TileRefs { get; set; } = null!;
}
