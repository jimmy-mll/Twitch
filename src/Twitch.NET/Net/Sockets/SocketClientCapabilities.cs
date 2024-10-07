namespace Twitch.NET.Net.Sockets;

public sealed class SocketClientCapabilities
{
    public required bool Membership { get; set; }

    public required bool Tags { get; set; }

    public required bool Commands { get; set; }
}
