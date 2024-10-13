using System.Diagnostics;
using System.Text;

namespace Twitch.Core.Http;

/// <summary>
/// Represents a builder for constructing query strings for URIs.
/// </summary>
[DebuggerDisplay("{ToString(),nq}")]
public sealed class QueryBuilder
{
    private readonly StringBuilder _builder;
    private readonly int _uriLength;

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryBuilder"/> class with the specified URI.
    /// </summary>
    /// <param name="uri">The base URI to which query parameters will be appended.</param>
    public QueryBuilder(string uri)
    {
        _builder = new StringBuilder(uri);
        _uriLength = uri.Length;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryBuilder"/> class with an empty URI.
    /// </summary>
    public QueryBuilder()
    {
        _builder = new StringBuilder();
        _uriLength = 0;
    }

    /// <summary>
    /// Adds a query parameter to the URI.
    /// </summary>
    /// <param name="key">The key of the query parameter.</param>
    /// <param name="value">The value of the query parameter.</param>
    /// <returns>The current instance of <see cref="QueryBuilder"/>.</returns>
    public QueryBuilder Param(string key, string value)
    {
        _builder
            .Append(_builder.Length == _uriLength ? '?' : '&')
            .Append(key)
            .Append('=')
            .Append(value);

        return this;
    }

    /// <summary>
    /// Returns a string that represents the constructed URI with query parameters.
    /// </summary>
    /// <returns>A string that represents the constructed URI with query parameters.</returns>
    public override string ToString() =>
        _builder.ToString();
}
