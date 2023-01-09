namespace PyxelParser;

/// <summary>
/// Pyxel Palette
/// </summary>
public class Palette
{
    /// <summary>
    /// Columns
    /// </summary>
    [JsonPropertyName("width")]
    public int Width { get; set; }
    /// <summary>
    /// Rows
    /// </summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>
    /// Color-count
    /// </summary>
    [JsonPropertyName("numColors")]
    public int NumColors { get; set; }

    /// <summary>
    /// Colors in hexadecimal AARRGGBB format
    /// </summary>
    [JsonPropertyName("colors")]
    public Dictionary<int, string> Colors { get; set; } = null!;
}
