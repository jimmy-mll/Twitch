namespace Twitch.NET;

/// <summary>
/// Represents the options for configuring the Twitch client.
/// </summary>
public sealed class TwitchClientOptions
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TwitchClientOptions"/> class.
    /// </summary>
    /// <param name="services">The service provider for dependency injection.</param>
    internal TwitchClientOptions(IServiceProvider services) => Services = services;

    /// <summary>
    /// Gets the service provider for dependency injection.
    /// </summary>
    internal IServiceProvider Services { get; }

    /// <summary>
    /// Gets or sets the OAuth token for authenticating with Twitch.
    /// </summary>
    public required string TwitchOAuthToken { get; set; }

    /// <summary>
    /// Gets or sets the username for the Twitch account.
    /// </summary>
    public required string TwitchUsername { get; set; }

    /// <summary>
    /// Gets or sets the channel name to connect to on Twitch.
    /// </summary>
    public required string TwitchChannel { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use SSL for the connection.
    /// </summary>
    public required bool UseSsl { get; set; }

    /// <summary>
    /// Gets or sets the capabilities to request from the Twitch IRC server.
    /// </summary>
    public required TwitchIrcFlags Flags { get; set; }
}
