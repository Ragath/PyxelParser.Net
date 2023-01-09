namespace PyxelParser;

/// <summary>
/// Reference to Tileset tile
/// </summary>
public class Tileref
{
    /// <summary>
    /// Tile-index, 0-based, left-right, top-bottom
    /// </summary>
    [JsonPropertyName("index")]
    public int Index { get; set; }

    /// <summary>
    /// Rotation, 90-degree increments, (0-2)
    /// </summary>
    [JsonPropertyName("rot")]
    public byte Rot { get; set; }

    /// <summary>
    /// Flip tile horizontally
    /// </summary>
    [JsonPropertyName("flipX")]
    public bool FlipX { get; set; }
}
