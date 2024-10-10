namespace Twitch.Core.Events;

/// <summary>
/// Represents event data for asynchronous operations.
/// </summary>
public record AsyncEventArgs
{
    /// <summary>
    /// A static instance of the <see cref="AsyncEventArgs" /> class representing an empty event data.
    /// </summary>
    public static readonly AsyncEventArgs Empty = new();
}
