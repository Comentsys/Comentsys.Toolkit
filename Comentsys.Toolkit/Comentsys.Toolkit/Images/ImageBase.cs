namespace Comentsys.Toolkit;

/// <summary>
/// Image Base
/// </summary>
public abstract class ImageBase<TResource>
{
    private const string resources_extension = "png";

    /// <summary>
    /// Get Base-64 Encoded String
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Base-64 Encoded String</returns>
    protected internal static string? GetBase64EncodedString(byte[] value) =>
        value.GetBase64EncodedString();

    /// <summary>
    /// As Stream
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Stream</returns>
    public static Stream? AsStream(string root, string path, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceStream<TResource>();

    /// <summary>
    /// As Stream
    /// </summary>
    /// <param name="client">Http Client</param>
    /// <param name="url">Request Url</param>
    /// <returns>Stream</returns>
    public static Task<Stream?> AsStream(HttpClient client, Uri? url) =>
        client.GetResponseStream(url);

    /// <summary>
    /// As Bytes
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Bytes</returns>
    public static byte[]? AsBytes(string root, string path, string? extension = resources_extension) =>
        AsStream(root, path, extension)
        .GetBytes();

    /// <summary>
    /// As Bytes
    /// </summary>
    /// <param name="client">Http Client</param>
    /// <param name="url">Request Url</param>
    /// <returns>Resource Bytes</returns>
    public static Task<byte[]?> AsBytes(HttpClient client, Uri? url) =>
        client.GetResponseBytes(url);

    /// <summary>
    /// From Bytes
    /// </summary>
    /// <param name="bytes">Bytes</param>
    /// <returns>Stream</returns>
    public static Stream? FromBytes(byte[]? bytes) =>
        bytes.GetStream();
}