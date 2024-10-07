
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Twitch.NET.Net.Sockets;

var client = new ServiceCollection()
    .AddLogging(x => x.AddConsole())
    .AddSingleton<SocketClient>()
    .Configure<SocketClientOptions>(x =>
    {
        x.BotUsername = "aerafaltw";
        x.ChannelName = "aerafaltw";
        x.OAuthToken = "oauth:jdr34fu4j02lu843aamll4ub7zcifc";
        x.Capabilities = new SocketClientCapabilities
        {
            Commands = true,
            Membership = true,
            Tags = true
        };
    })
    .BuildServiceProvider()
    .GetRequiredService<SocketClient>();

await client.ConnectAsync();

while (true)
{
    string? msg = Console.ReadLine();

    if (string.IsNullOrEmpty(msg))
        continue;

    await client.SendCommandAsync($"PRIVMSG #{client.ChannelName} :{msg}");
}
