using Twitch.OAuth.Models;

namespace Twitch.OAuth;

/// <summary>
/// Represents the options for configuring the Twitch OAuth client.
/// </summary>
public sealed class TwitchOAuthClientOptions
{
    /// <summary>
    /// Gets or sets the client ID.
    /// </summary>
    public required string ClientId { get; set; }

    /// <summary>
    /// Gets or sets the client secret.
    /// </summary>
    public required string ClientSecret { get; set; }

    /// <summary>
    /// Gets or sets the redirect URI.
    /// </summary>
    public required string RedirectUri { get; set; }

    /// <summary>
    /// Gets or sets the OAuth scopes.
    /// </summary>
    public required OAuthScope[] Scopes { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to force verification.
    /// </summary>
    public required bool ForceVerify { get; set; }

    /// <summary>
    /// Gets or sets the state.
    /// </summary>
    public required string State { get; set; }
}
