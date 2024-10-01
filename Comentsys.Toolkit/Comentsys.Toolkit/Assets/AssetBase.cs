namespace Comentsys.Toolkit;

/// <summary>
/// Asset Base
/// </summary>
public abstract class AssetBase<TResource>
{
    private const string resources_extension = "svg";

    /// <summary>
    /// Get Base-64 Encoded String
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Base-64 Encoded String</returns>
    public static string? GetBase64EncodedString(string? value) =>
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
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Stream</returns>
    public static Stream? AsStream(string root, string path, 
        Color? source, Color? target, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceStream<TResource>(source, target);

    /// <summary>
    /// As Stream
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Stream</returns>
    public static Stream? AsStream(string root, string path, 
        Color[]? sources, Color[]? targets, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceStream<TResource>(sources, targets);

    /// <summary>
    /// From Stream
    /// </summary>
    /// <param name="stream">Stream</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <returns>Resource Stream</returns>
    public static Stream? FromStream(Stream stream,
        Color? source, Color? target) =>
        stream.ProcessResourceStream(source, target);

    /// <summary>
    /// From Stream
    /// </summary>
    /// <param name="stream">Stream</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <returns>Resource Stream</returns>
    public static Stream? FromStream(Stream stream,
        Color[]? sources, Color[]? targets) =>
        stream.ProcessResourceStream(sources, targets);

    /// <summary>
    /// From String
    /// </summary>
    /// <param name="content">Content</param>
    /// <returns>Resource Stream</returns>
    public static Stream? FromString(string content) =>
        content.GetStream();

    /// <summary>
    /// From String
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <returns>Resource Stream</returns>
    public static Stream? FromString(string content,
        Color? source, Color? target) =>
        content.ProcessAssetResource(source, target)
        .GetStream();

    /// <summary>
    /// From String
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <returns>Resource Stream</returns>
    public static Stream? FromString(string content,
        Color[]? sources, Color[]? targets) =>
        content.ProcessAssetResource(sources, targets)
        .GetStream();

    /// <summary>
    /// As String
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Stream</returns>
    public static string? AsString(string root, string path, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceString<TResource>();

    /// <summary>
    /// As String
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource String</returns>
    public static string? AsString(string root, string path,
        Color? source, Color? target, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceString<TResource>(source, target);

    /// <summary>
    /// As String
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource String</returns>
    public static string? AsString(string root, string path,
        Color[]? sources, Color[]? targets, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceString<TResource>(sources, targets);

    /// <summary>
    /// As String
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <returns>Resource String</returns>
    public static string? AsString(string content,
        Color? source, Color? target) =>
        content.ProcessAssetResource(source, target);

    /// <summary>
    /// As String
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <returns>Resource String</returns>
    public static string? AsString(string content,
        Color[]? sources, Color[]? targets) =>
        content.ProcessAssetResource(sources, targets);
}