namespace Twitch.NET;

/// <summary>
/// Specifies the capabilities that can be requested from the Twitch IRC server.
/// </summary>
[Flags]
public enum TwitchIrcFlags
{
    /// <summary>
    /// Indicates the membership capability, which allows receiving JOIN, PART, and NAMES messages.
    /// </summary>
    Membership = 1 << 0,

    /// <summary>
    /// Indicates the tags capability, which allows receiving IRC v3 message tags.
    /// </summary>
    Tags = 1 << 1,

    /// <summary>
    /// Indicates the commands capability, which allows receiving additional IRC commands.
    /// </summary>
    Commands = 1 << 2
}
