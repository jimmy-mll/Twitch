using System.Net.Http.Json;
using System.Web;
using Microsoft.Extensions.Options;
using Twitch.Core.Http;
using Twitch.OAuth.Models;

namespace Twitch.OAuth;

/// <summary>
/// Represents a client for interacting with Twitch OAuth.
/// </summary>
public sealed class TwitchOAuthClient : IDisposable
{
    private readonly HttpClient _http;
    private readonly TwitchOAuthClientOptions _options;

    /// <summary>
    /// Initializes a new instance of the <see cref="TwitchOAuthClient"/> class.
    /// </summary>
    /// <param name="http">The HTTP client used for making requests.</param>
    /// <param name="options">The options for configuring the Twitch OAuth client.</param>
    public TwitchOAuthClient(HttpClient http, IOptions<TwitchOAuthClientOptions> options)
    {
        _http = http;
        _options = options.Value;
    }

    /// <summary>
    /// Disposes the HTTP client.
    /// </summary>
    public void Dispose() => _http.Dispose();

    /// <summary>
    /// Gets the authorization URL for the Twitch OAuth flow.
    /// </summary>
    /// <returns>The authorization URL as a string.</returns>
    public string GetAuthorizationUrl() =>
        new QueryBuilder("https://id.twitch.tv/oauth2/authorize")
            .Param("client_id", _options.ClientId)
            .Param("redirect_uri", _options.RedirectUri)
            .Param("response_type", "code")
            .Param("scope", HttpUtility.UrlEncode(string.Join(' ', _options.Scopes.Select(x => x.ToString()))))
            .Param("force_verify", _options.ForceVerify ? "true" : "false")
            .ToString();

    /// <summary>
    /// Gets an OAuth token from the authorization code.
    /// </summary>
    /// <param name="code">The authorization code received from the OAuth flow.</param>
    /// <param name="clientSecret">The client secret for the Twitch application.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the OAuth token.</returns>
    public async Task<OAuthToken?> GetTokenFromCodeAsync(string code, string clientSecret)
    {
        FormUrlEncodedContent content = new(new Dictionary<string, string>
        {
            ["client_id"] = _options.ClientId,
            ["client_secret"] = clientSecret,
            ["code"] = code,
            ["grant_type"] = "authorization_code",
            ["redirect_uri"] = _options.RedirectUri
        });

        HttpResponseMessage response = await _http.PostAsync("token", content);

        response.EnsureSuccessStatusCode();

        return await response.Content.ReadFromJsonAsync<OAuthToken>();
    }
}
