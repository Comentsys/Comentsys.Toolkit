namespace Comentsys.Toolkit;

/// <summary>
/// Image Resource
/// </summary>
public class ImageResource
{
    /// <summary>
    /// Constructor
    /// </summary>
    public ImageResource() { }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="stream">Stream</param>
    /// <param name="height">Height</param>
    /// <param name="width">Width</param>
    public ImageResource(Stream stream, int height, int width) =>
        (Stream, Height, Width) = (stream, height, width);

    /// <summary>
    /// Image Resource Stream
    /// </summary>
    public Stream Stream { get; set; } = Stream.Null;

    /// <summary>
    /// Image Resource Height
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// Image Resource Width
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// Empty Image Resource
    /// </summary>
    public static ImageResource Empty { get; set; } = new(Stream.Null, 0, 0);

    /// <summary>
    /// Image Resource PNG Bytes
    /// </summary>
    /// <returns>PNG Bytes</returns>
    public byte[]? ToPngBytes() =>
        Stream?.GetBytes();

    /// <summary>
    /// Image Resource Base-64 Encoded PNG String
    /// </summary>
    /// <returns>Base-64 Encoded PNG String</returns>
    public string? ToBase64EncodedPngString() =>
        ToPngBytes()?.
        GetBase64EncodedString();
}
