using System.Text.Json.Serialization;

namespace Twitch.OAuth.Models;

public sealed class OAuthToken
{
    [JsonPropertyName("access_token")]
    public required string AccessToken { get; init; }

    [JsonPropertyName("expires_in")]
    public required int ExpiresIn { get; init; }

    [JsonPropertyName("refresh_token")]
    public required string RefreshToken { get; init; }

    [JsonPropertyName("scope")]
    public required string[] Scopes { get; init; }

    [JsonPropertyName("token_type")]
    public required string TokenType { get; init; }
}
