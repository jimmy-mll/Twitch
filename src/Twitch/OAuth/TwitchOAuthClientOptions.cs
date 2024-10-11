using Twitch.OAuth.Models;

namespace Twitch.OAuth;

/// <summary>
/// Specify the following query parameters as appropriate for your application.
/// </summary>
public sealed class TwitchOAuthClientOptions
{
    /// <summary>
    /// Your app’s <a href="https://dev.twitch.tv/docs/authentication/register-app">registered</a> client ID.
    /// </summary>
    public required string ClientId { get; set; }

    /// <summary>
    /// Your app’s <a href="https://dev.twitch.tv/docs/authentication/register-app">registered</a> client secret.
    /// </summary>
    public required string ClientSecret { get; set; }

    /// <summary>
    /// Your app’s registered redirect URI. The authorization code is sent to this URI.
    /// </summary>
    public required Uri RedirectUri { get; set; }

    /// <summary>
    /// A space-delimited list of scopes. The APIs that you’re calling will identify the scopes you must list. You must URL encode the list.
    /// </summary>
    public required OAuthScope[] Scopes { get; set; }

    /// <summary>
    /// Set to <b>true</b> to force the user to re-authorize your app’s access to their resources. The default is <b>false</b>.
    /// </summary>
    public required bool ForceVerify { get; set; }

    /// <summary>
    /// Although optional, you are strongly encouraged to pass a state string to help prevent
    /// <a href="https://datatracker.ietf.org/doc/html/rfc6749#section-10.12">Cross-Site Request Forgery</a> (CSRF) attacks.
    /// The server returns this string to you in your redirect URI (see the state parameter in the fragment portion of the URI).
    /// If this string doesn’t match the state string that you passed, ignore the response.
    /// The state string should be randomly generated and unique for each OAuth request.
    /// </summary>
    public required string State { get; set; }
}
