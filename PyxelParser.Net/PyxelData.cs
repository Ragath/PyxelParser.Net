namespace PyxelParser;

/// <summary>
/// Pyxel metadata
/// </summary>
public class PyxelData
{
    /// <summary>
    /// Pyxel version
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; set; } = null!;

    /// <summary>
    /// *.pyxel filename without extension
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Tileset
    /// </summary>
    [JsonPropertyName("tileset")]
    public Tileset Tileset { get; set; } = null!;

    /// <summary>
    /// Settings
    /// </summary>
    [JsonPropertyName("settings")]
    public Settings Settings { get; set; } = null!;

    /// <summary>
    /// Palette
    /// </summary>
    [JsonPropertyName("palette")]
    public Palette Palette { get; set; } = null!;

    /// <summary>
    /// Canvas
    /// </summary>
    [JsonPropertyName("canvas")]
    public Canvas Canvas { get; set; } = null!;

    /// <summary>
    /// Animations
    /// </summary>
    [JsonPropertyName("animations")]
    public Dictionary<int, Animation> Animations { get; set; } = null!;
}
