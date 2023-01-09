namespace PyxelParser;

/// <summary>
/// Pyxel Tileset
/// </summary>
public class Tileset
{
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
    /// Column-count in Tileset view
    /// </summary>
    [JsonPropertyName("tilesWide")]
    public int TilesWide { get; set; }
    /// <summary>
    /// Fixed column-count Tileset view
    /// </summary>
    [JsonPropertyName("fixedWidth")]
    public bool FixedWidth { get; set; }

    /// <summary>
    /// Number of tiles in Tileset
    /// </summary>
    [JsonPropertyName("numTiles")]
    public int NumTiles { get; set; }
}
