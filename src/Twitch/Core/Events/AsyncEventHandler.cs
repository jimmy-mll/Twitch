namespace Twitch.Core.Events;

/// <summary>
/// Represents an asynchronous event handler delegate.
/// </summary>
/// <typeparam name="TEventArgs">The type of the event data.</typeparam>
/// <param name="sender">The source of the event.</param>
/// <param name="e">An object that contains the event data.</param>
public delegate ValueTask AsyncEventHandler<in TEventArgs>(object sender, TEventArgs e)
    where TEventArgs : AsyncEventArgs;
