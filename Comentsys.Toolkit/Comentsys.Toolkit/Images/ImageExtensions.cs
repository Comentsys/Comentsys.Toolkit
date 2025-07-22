namespace Comentsys.Toolkit;

/// <summary>
/// Image Extensions
/// </summary>
internal static class ImageExtensions
{
    /// <summary>
    /// Get Bytes
    /// </summary>
    /// <param name="stream">Stream</param>
    /// <returns>Byte Array</returns>
    internal static byte[]? GetBytes(this Stream? stream)
    {
        if (stream == null)
            return null;
        using MemoryStream memory = new();
        stream.CopyTo(memory);
        return memory.ToArray();
    }

    /// <summary>
    /// Get Stream
    /// </summary>
    /// <param name="bytes">Bytes</param>
    /// <returns>Stream</returns>
    internal static Stream? GetStream(this byte[]? bytes)
    {
        if(bytes == null)
            return null;
        using MemoryStream memory = new(bytes);
        return memory;
    }

    /// <summary>
    /// Get Base-64 Encoded String
    /// </summary>
    /// <param name="bytes">Bytes</param>
    /// <returns>Base-64 Encoded String</returns>
    internal static string? GetBase64EncodedString(this byte[]? bytes) =>
        bytes != null ? Convert.ToBase64String(bytes) : null;

    /// <summary>
    /// Get Resource Bytes
    /// </summary>
    /// <param name="resourcePath">Resource Path</param>
    /// <returns>Resource Bytes</returns>
    internal static byte[]? GetResourceBytes<TResource>(this string resourcePath) =>
        GetBytes(typeof(TResource)?.Assembly?.GetManifestResourceStream(resourcePath));

    /// <summary>
    /// Get Response Stream
    /// </summary>
    /// <param name="client">Http Client</param>
    /// <param name="url">Request Url</param>
    /// <returns>Response Stream</returns>
    internal static Task<Stream?> GetResponseStream(this HttpClient client, Uri? url)
    {
        var result = Task.FromResult<Stream?>(null);
        try
        {
            return url != null ? client.GetStreamAsync(url) : result;
        }
        catch(HttpRequestException)
        {
            return result;
        }
    }

    /// <summary>
    /// Get Response Bytes
    /// </summary>
    /// <param name="client">Http Client</param>
    /// <param name="url">Request Url</param>
    /// <returns>Response Bytes</returns>
    internal static async Task<byte[]?> GetResponseBytes(this HttpClient client, Uri? url) =>
        GetBytes(await GetResponseStream(client, url));
}
