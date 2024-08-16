namespace Comentsys.Toolkit;

/// <summary>
/// Asset Base
/// </summary>
public abstract class AssetBase<TResource>
{
    private const string resources_extension = "svg";

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
    /// As Stream
    /// </summary>
    /// <param name="root">Root</param>
    /// <param name="path">Path</param>
    /// <param name="sources">Sources</param>
    /// <param name="targets">Targets</param>
    /// <param name="extension">Extension</param>
    /// <returns>Resource Stream</returns>
    public static string? AsString(string root, string path,
        Color[]? sources, Color[]? targets, string? extension = resources_extension) =>
        $"{root}.{path}.{extension}".GetResourceString<TResource>(sources, targets);
}
