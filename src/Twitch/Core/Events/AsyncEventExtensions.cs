namespace Twitch.Core.Events;

/// <summary>
/// Provides extension methods for asynchronous event handling.
/// </summary>
public static class AsyncEventExtensions
{
    /// <summary>
    /// Invokes an asynchronous event handler with the specified sender and event arguments.
    /// </summary>
    /// <typeparam name="TEventArgs">The type of the event arguments.</typeparam>
    /// <param name="handler">The asynchronous event handler to invoke.</param>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">The event arguments.</param>
    public static async ValueTask InvokeAsync<TEventArgs>(this AsyncEventHandler<TEventArgs>? handler, object sender, TEventArgs e)
        where TEventArgs : AsyncEventArgs
    {
        if (handler is null)
            return;

        foreach (var invocation in handler.GetInvocationList())
            await ((AsyncEventHandler<TEventArgs>)invocation)
                .InvokeAsync(sender, e)
                .ConfigureAwait(false);
    }
}
