using System.Net.Security;
using System.Net.Sockets;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Twitch.NET.Core.Events;

namespace Twitch.NET.Net.Sockets;

public sealed class SocketClient : IDisposable
{
    private const string Host = "irc.chat.twitch.tv";

    private const int Port = 6667;

    private const int SslPort = 6697;

    private readonly Socket _socket;
    private readonly CancellationTokenSource _cts;
    private readonly SocketClientOptions _options;
    private readonly ILogger<SocketClient> _logger;

    private StreamReader? _reader;
    private StreamWriter? _writer;
    private CancellationTokenSource _subCts;

    public event AsyncEventHandler<AsyncEventArgs>? Connecting;
    public event AsyncEventHandler<AsyncEventArgs>? Connected;
    public event AsyncEventHandler<AsyncEventArgs>? Reconnecting;
    public event AsyncEventHandler<AsyncEventArgs>? Reconnected;
    public event AsyncEventHandler<AsyncEventArgs>? Disconnecting;
    public event AsyncEventHandler<AsyncEventArgs>? Disconnected;

    public bool IsConnected =>
        _socket.Connected && !_cts.IsCancellationRequested;

    public string ChannelName =>
        _options.ChannelName;

    public SocketClient(IOptions<SocketClientOptions> options, ILogger<SocketClient> logger)
    {
        _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        _cts = new CancellationTokenSource();
        _subCts = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token);
        _options = options.Value;
        _logger = logger;
    }

    public async Task<bool> ConnectAsync()
    {
        await Connecting.InvokeAsync(this, AsyncEventArgs.Empty);

        await _socket.ConnectAsync(Host, _options.UseSsl ? SslPort : Port).ConfigureAwait(false);

        Stream stream = new NetworkStream(_socket, false);

        if (_options.UseSsl)
        {
            var sslStream = new SslStream(stream, false);
            await sslStream.AuthenticateAsClientAsync(Host).ConfigureAwait(false);
            stream = sslStream;
        }

        _reader = new StreamReader(stream);
        _writer = new StreamWriter(stream) { NewLine = "\r\n", AutoFlush = true };

        await Connected.InvokeAsync(this, AsyncEventArgs.Empty);

        await SendCommandAsync($"PASS {_options.OAuthToken}");
        await SendCommandAsync($"NICK {_options.BotUsername}");
        await SendCommandAsync($"USER {_options.BotUsername} 0 * :{_options.BotUsername.ToLower()}");

        if (_options.Capabilities.Membership)
            await SendCommandAsync("CAP REQ twitch.tv/membership");

        if (_options.Capabilities.Tags)
            await SendCommandAsync("CAP REQ twitch.tv/tags");

        if (_options.Capabilities.Commands)
            await SendCommandAsync("CAP REQ twitch.tv/commands");

        await SendCommandAsync($"JOIN #{_options.ChannelName}");

        _ = ListenAsync();

        return true;
    }

    public async Task<bool> ReconnectAsync()
    {
        await Reconnecting.InvokeAsync(this, AsyncEventArgs.Empty);

        if (!_subCts.IsCancellationRequested)
            _subCts.Cancel();

        _subCts.Dispose();
        _subCts = CancellationTokenSource.CreateLinkedTokenSource(_cts.Token);

        if (!_socket.Connected)
        {
            bool connected = await ConnectAsync().ConfigureAwait(false);

            if (connected)
                await Reconnected.InvokeAsync(this, AsyncEventArgs.Empty);

            return connected;
        }

        await ListenAsync().ConfigureAwait(false);
        await Reconnected.InvokeAsync(this, AsyncEventArgs.Empty);
        return true;
    }

    public async Task DisconnectAsync()
    {
        await Disconnecting.InvokeAsync(this, AsyncEventArgs.Empty);

        _subCts.Cancel();

        _socket.Shutdown(SocketShutdown.Both);
        _socket.Close();

        await Disconnected.InvokeAsync(this, AsyncEventArgs.Empty);
    }

    public async Task SendCommandAsync(string command)
    {
        var writer = _writer ?? throw new ObjectDisposedException(nameof(StreamWriter));

        await writer.WriteLineAsync(command).ConfigureAwait(false);
    }

    private async Task ListenAsync()
    {
        var reader = _reader ?? throw new ObjectDisposedException(nameof(StreamReader));

        while (!_subCts.Token.IsCancellationRequested)
        {
            try
            {
                string? message = await reader.ReadLineAsync().ConfigureAwait(false);

                if (message is null)
                {
                    await DisconnectAsync().ConfigureAwait(false);
                    break;
                }

                _logger.LogInformation("{Message}", message);
            }
            catch (Exception e)
            {
                _logger.LogError(e, "An error occurred while listening.");
                break;
            }
        }
    }

    public void Dispose()
    {
        _cts.Dispose();
        _reader?.Dispose();
        _writer?.Dispose();
        _socket.Dispose();
    }
}
