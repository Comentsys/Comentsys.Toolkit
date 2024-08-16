using System.Diagnostics;

namespace Comentsys.Toolkit;

/// <summary>
/// Asset Extensions
/// </summary>
internal static class AssetExtensions
{
    /// <summary>
    /// To Stream
    /// </summary>
    /// <param name="value">Value</param>
    /// <returns>Stream</returns>
    private static Stream ToStream(this string? value) =>
        value != null ? new MemoryStream(Encoding.UTF8.GetBytes(value)) : new MemoryStream();

    /// <summary>
    /// Color To String
    /// </summary>
    /// <param name="color">Color</param>
    /// <returns>String</returns>
    private static string? ColorToString(this Color? color) =>
        color != null ? $"#{color.Value.R:X2}{color.Value.G:X2}{color.Value.B:X2}" : null;

    /// <summary>
    /// Asset Resource Replace
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="source">Source</param>
    /// <param name="target">Target</param>
    /// <returns>Replaced Elements</returns>
    private static string AssetResourceReplace(this string content, string? source, string? target)
    {
        if(source != null && target != null)
        {
            content = content.Replace(source, target);
            content = content.Replace(source.ToUpper(), target);
            content = content.Replace(source.ToLower(), target);
        }
        return content;
    }

    /// <summary>
    /// Process Asset Resource
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Processed Resource Data</returns>
    private static string? ProcessAssetResource(this string content, Color? source = null, Color? target = null) =>
        source != null && target != null ?
            content.AssetResourceReplace(ColorToString(source), ColorToString(target)) :
            content;

    /// <summary>
    /// Process Asset Resource
    /// </summary>
    /// <param name="content">Content</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Processed Resource Data</returns>
    private static string? ProcessAssetResource(this string content, 
        Color[]? sources = null, Color[]? targets = null)
    {
        if (sources != null && targets != null)
        {
            for (int index = 0; index < sources.Length; index++)
            {
                var source = ColorToString(sources[index]);
                var target = index < targets.Length ? ColorToString(targets[index]) : null;
                if (target != null)
                    content = content.AssetResourceReplace(source, target);
            }
        }
        return content;
    }

    /// <summary>
    /// Get Resource Stream
    /// </summary>
    /// <param name="resourcePath">Resource Path</param>
    /// <returns>Resource Stream</returns>
    internal static Stream? GetResourceStream<TResource>(this string resourcePath) =>
        typeof(TResource)?.Assembly?.GetManifestResourceStream(resourcePath);

    /// <summary>
    /// Get Resource Stream
    /// </summary>
    /// <param name="resourcePath">Path</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Resource Stream</returns>
    internal static Stream? GetResourceStream<TResource>(this string resourcePath, 
        Color? source = null, Color? target = null)
    {
        var stream = GetResourceStream<TResource>(resourcePath);
        if (source == null && target == null)
            return stream;
        if (stream?.Length > 0)
        {
            if (source == null && target == null)
                return stream;
            using StreamReader reader = new(stream);
            var content = reader.ReadToEnd()
            .ProcessAssetResource(source, target);
            return content.ToStream();
        }
        return null;
    }

    /// <summary>
    /// Get Resource Stream
    /// </summary>
    /// <param name="resourcePath">Path</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Resource Stream</returns>
    internal static Stream? GetResourceStream<TResource>(this string resourcePath, 
        Color[]? sources = null, Color[]? targets = null)
    {
        var stream = GetResourceStream<TResource>(resourcePath);
        if (sources == null && targets == null)
            return stream;
        if (stream?.Length > 0)
        {
            using StreamReader reader = new(stream);
            var content = reader.ReadToEnd()
            .ProcessAssetResource(sources, targets);
            return content.ToStream();
        }
        return null;
    }

    /// <summary>
    /// Get Resource String
    /// </summary>
    /// <param name="resourcePath">Path</param>
    /// <returns>Resource String</returns>
    internal static string? GetResourceString<TResource>(this string resourcePath)
    {
        var stream = GetResourceStream<TResource>(resourcePath);
        if (stream?.Length > 0)
        {
            using StreamReader reader = new(stream);
            return reader.ReadToEnd();
        }
        return null;
    }

    /// <summary>
    /// Get Resource String
    /// </summary>
    /// <param name="resourcePath">Path</param>
    /// <param name="source">Source Colour</param>
    /// <param name="target">Target Colour</param>
    /// <returns>Resource String</returns>
    internal static string? GetResourceString<TResource>(this string resourcePath,
        Color? source = null, Color? target = null)
    {
        var stream = GetResourceStream<TResource>(resourcePath);
        if (stream?.Length > 0)
        {
            using StreamReader reader = new(stream);
            var content = reader.ReadToEnd();
            if (source == null && target == null)
                return content;
            return content.ProcessAssetResource(source, target);
        }
        return null;
    }

    /// <summary>
    /// Get Resource String
    /// </summary>
    /// <param name="resourcePath">Path</param>
    /// <param name="sources">Source Colours</param>
    /// <param name="targets">Target Colours</param>
    /// <returns>Resource String</returns>
    internal static string? GetResourceString<TResource>(this string resourcePath,
        Color[]? sources = null, Color[]? targets = null)
    {
        var stream = GetResourceStream<TResource>(resourcePath);
        if (stream?.Length > 0)
        {
            using StreamReader reader = new(stream);
            var content = reader.ReadToEnd();
            if (sources == null && targets == null)
                return content;
            return content.ProcessAssetResource(sources, targets);
        }
        return null;
    }
}
