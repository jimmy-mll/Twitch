using System.IO.Pipelines;
using System.Net;
using System.Text;
using Bedrock.Framework;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Options;

namespace Twitch.NET.Net;

/// <summary>
/// Represents a client that connects to Twitch IRC chat.
/// </summary>
public sealed class SocketClient : IAsyncDisposable
{
    private const string Host = "irc.chat.twitch.tv";
    private const int Port = 6667;
    private const int SslPort = 6697;

    private readonly TwitchClientOptions _options;
    private ConnectionContext? _connection;

    /// <summary>
    /// Initializes a new instance of the <see cref="SocketClient"/> class.
    /// </summary>
    /// <param name="options">The options for the socket client.</param>
    public SocketClient(IOptions<TwitchClientOptions> options) => _options = options.Value;

    /// <summary>
    /// Disposes the connection asynchronously.
    /// </summary>
    public ValueTask DisposeAsync() => _connection?.DisposeAsync() ?? ValueTask.CompletedTask;

    /// <summary>
    /// Connects to the Twitch IRC server.
    /// </summary>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    /// <returns>The task result contains a boolean indicating success or failure.</returns>
    public async Task<bool> ConnectAsync(CancellationToken cancellationToken = default)
    {
        IPAddress[] addresses = await Dns.GetHostAddressesAsync(Host, cancellationToken).ConfigureAwait(false);
        IPAddress address = addresses[0];
        int port = _options.UseSsl ? SslPort : Port;

        ClientBuilder? builder = new ClientBuilder(_options.Services)
            .UseSockets()
            .UseConnectionLogging();

        if (_options.UseSsl)
        {
            builder.UseClientTls(tls => { tls.AllowAnyRemoteCertificate(); });
        }

        _connection = await builder
            .Build()
            .ConnectAsync(new IPEndPoint(address, port), cancellationToken)
            .ConfigureAwait(false);

        if (_connection is null)
        {
            return false;
        }

        await SendCommandAsync($"PASS {_options.TwitchOAuthToken}");
        await SendCommandAsync($"NICK {_options.TwitchUsername}");
        await SendCommandAsync($"USER {_options.TwitchUsername} 0 * :{_options.TwitchUsername.ToLower()}");

        if (_options.Flags.HasFlag(TwitchIrcFlags.Membership))
        {
            await SendCommandAsync("CAP REQ twitch.tv/membership");
        }

        if (_options.Flags.HasFlag(TwitchIrcFlags.Tags))
        {
            await SendCommandAsync("CAP REQ twitch.tv/tags");
        }

        if (_options.Flags.HasFlag(TwitchIrcFlags.Commands))
        {
            await SendCommandAsync("CAP REQ twitch.tv/commands");
        }

        return true;
    }

    /// <summary>
    /// Sends a command to the Twitch IRC server.
    /// </summary>
    /// <param name="command">The command to send.</param>
    public ValueTask SendCommandAsync(string command)
    {
        if (_connection is null)
        {
            return ValueTask.CompletedTask;
        }

        if (_connection.ConnectionClosed.IsCancellationRequested)
        {
            return ValueTask.CompletedTask;
        }

        byte[] buffer = Encoding.UTF8.GetBytes($"{command}\r\n");
        ValueTask<FlushResult> writeVt = _connection.Transport.Output.WriteAsync(buffer, _connection.ConnectionClosed);

        return writeVt.IsCompletedSuccessfully
            ? ValueTask.CompletedTask
            : AwaitedSendCommandAsync(writeVt);

        static async ValueTask AwaitedSendCommandAsync(ValueTask<FlushResult> writeVt)
        {
            try
            {
                await writeVt.ConfigureAwait(false);
            }
            catch
            {
                // ignored
            }
        }
    }
}
