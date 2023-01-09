namespace PyxelParser;

/// <summary>
/// Pyxel Canvas
/// </summary>
public class Canvas
{
    /// <summary>
    /// Canvas width in pixels
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }
    /// <summary>
    /// Canvas height in pixels
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// Tile width in pixels
    /// </summary>
    [JsonPropertyName("tileWidth")]
    public int TileWidth { get; set; }
    /// <summary>
    /// Tile height in pixels
    /// </summary>
    [JsonPropertyName("tileHeight")]
    public int TileHeight { get; set; }

    /// <summary>
    /// Layer-count
    /// </summary>
    [JsonPropertyName("numLayers")]
    public int NumLayers { get; set; }
    /// <summary>
    /// Layers
    /// </summary>
    [JsonPropertyName("layers")]
    public Dictionary<int, Layer> Layers { get; set; } = null!;
}
