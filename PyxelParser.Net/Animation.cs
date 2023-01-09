namespace PyxelParser;

/// <summary>
/// Pyxel Animation
/// </summary>
public class Animation
{
    /// <summary>
    /// Animation name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Position on canvas(map index)
    /// </summary>
    [JsonPropertyName("baseTile")]
    public int BaseTile { get; set; }

    /// <summary>
    /// Frame-count
    /// </summary>
    [JsonPropertyName("length")]
    public int Length { get; set; }

    /// <summary>
    /// Frame duration(ms)
    /// </summary>
    [JsonPropertyName("frameDuration")]
    public int FrameDuration { get; set; }

    /// <summary>
    /// Frame duration percentages
    /// </summary>
    [JsonPropertyName("frameDurationMultipliers")]
    public int[] FrameDurationMultipliers { get; set; } = null!;
}
