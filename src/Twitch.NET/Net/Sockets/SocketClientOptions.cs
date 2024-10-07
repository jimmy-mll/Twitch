namespace Twitch.NET.Net.Sockets;

public sealed class SocketClientOptions
{
    public required string OAuthToken { get; set; }

    public required string BotUsername { get; set; }

    public required string ChannelName { get; set; }

    public required bool UseSsl { get; set; }

    public required SocketClientCapabilities Capabilities { get; set; }
}
