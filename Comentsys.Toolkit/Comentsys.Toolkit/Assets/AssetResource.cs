namespace Comentsys.Toolkit;

/// <summary>
/// Asset Resource
/// </summary>
public class AssetResource
{
    /// <summary>
    /// Constructor
    /// </summary>
    public AssetResource() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="stream">Stream</param>
    /// <param name="height">Height</param>
    /// <param name="width">Width</param>
    public AssetResource(Stream stream, int height, int width) =>
        (Stream, Height, Width) = (stream, height, width);

    /// <summary>
    /// Asset Resource Stream
    /// </summary>
    public Stream Stream { get; set; } = Stream.Null;

    /// <summary>
    /// Asset Resource Height
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Asset Resource Width
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Empty Asset Resource
    /// </summary>
    public static AssetResource Empty { get; set; } = new(Stream.Null, 0, 0);
}
