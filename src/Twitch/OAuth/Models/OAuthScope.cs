namespace Twitch.OAuth.Models;

/// <summary>
/// The following table lists the scopes used by the Twitch API. To see a list of all Twitch API endpoints,
/// including those that do not require scopes, see the <a href="https://dev.twitch.tv/docs/api/reference">Twitch API reference</a>.
/// </summary>
public sealed class OAuthScope
{
    private readonly string _scope;

    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthScope"/> class with the specified scope.
    /// </summary>
    /// <param name="scope">The scope string representing the OAuth scope.</param>
    private OAuthScope(string scope)
    {
        _scope = scope;
    }

    /// <summary>
    /// Implicitly converts an <see cref="OAuthScope"/> to a string.
    /// </summary>
    /// <param name="scope">The <see cref="OAuthScope"/> to convert.</param>
    /// <returns>The string representation of the <see cref="OAuthScope"/>.</returns>
    public static implicit operator string(OAuthScope scope) => scope._scope;

    /// <summary>
    /// Returns a string that represents the current <see cref="OAuthScope"/>.
    /// </summary>
    /// <returns>A string that represents the current <see cref="OAuthScope"/>.</returns>
    public override string ToString() => _scope;

    /// <summary>
    /// View analytics data for the Twitch Extensions owned by the authenticated account.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-extension-analytics">Get Extension Analytics</a>
    /// </summary>
    public static readonly OAuthScope AnalyticsReadExtensions = new("analytics:read:extensions");

    /// <summary>
    /// View analytics data for the games owned by the authenticated account.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-game-analytics">Get Game Analytics</a>
    /// </summary>
    public static readonly OAuthScope AnalyticsReadGames = new("analytics:read:games");

    /// <summary>
    /// View Bits information for a channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-bits-leaderboard">Get Bits Leaderboard</a><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelcheer">Channel Cheer</a>
    /// </summary>
    public static readonly OAuthScope BitsRead = new("bits:read");

    /// <summary>
    /// Joins your channel’s chatroom as a bot user, and perform chat-related actions as that user.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#send-chat-message">Send Chat Message</a><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear">Channel Chat Clear</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear_user_messages">Channel Chat Clear User Messages</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage">Channel Chat Message</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage_delete">Channel Chat Message Delete</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatnotification">Channel Chat Notification</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchat_settingsupdate">Channel Chat Settings Update</a>
    /// </summary>
    public static readonly OAuthScope ChannelBot = new("channel:bot");

    /// <summary>
    /// Manage ads schedule on a channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#snooze-next-ad">Snooze Next Ad</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageAds = new("channel:manage:ads");

    /// <summary>
    /// Read the ads schedule and details on your channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-ad-schedule">Get Ad Schedule</a><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelad_breakbegin">Channel Ad Break Begin</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadAds = new("channel:read:ads");

    /// <summary>
    /// Manage a channel’s broadcast configuration, including updating channel configuration and managing stream markers and stream tags.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#modify-channel-information">Modify Channel Information</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-stream-marker">Create Stream Marker</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/https://dev.twitch.tv/docs/api/reference#replace-stream-tags">Replace Stream Tags</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageBroadcast = new("channel:manage:broadcast");

    /// <summary>
    /// Read charity campaign details and user donations on your channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-charity-campaign">Get Charity Campaign</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-charity-campaign-donations">Get Charity Campaign Donations</a><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelcharity_campaigndonate">Charity Donation</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelcharity_campaignstart">Charity Campaign Start</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelcharity_campaignprogress">Charity Campaign Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelcharity_campaignstop">Charity Campaign Stop</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadCharity = new("channel:read:charity");

    /// <summary>
    /// Run commercials on a channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#start-commercial">Start Commercial</a>
    /// </summary>
    public static readonly OAuthScope ChannelEditCommercial = new("channel:edit:commercial");

    /// <summary>
    /// View a list of users with the editor role for a channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-channel-editors">Get Channel Editors</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadEditors = new("channel:read:editors");

    /// <summary>
    /// Manage a channel’s Extension configuration, including activating Extensions.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-user-active-extensions">Get User Active Extensions</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-user-extensions">Update User Extensions</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageExtensions = new("channel:manage:extensions");
    public static readonly OAuthScope ChannelReadGoals = new("channel:read:goals");
    public static readonly OAuthScope ChannelReadGuestStar = new("channel:read:guest_star");
    public static readonly OAuthScope ChannelManageGuestStar = new("channel:manage:guest_star");
    public static readonly OAuthScope ChannelReadHypeTrain = new("channel:read:hype_train");
    public static readonly OAuthScope ChannelManageModerators = new("channel:manage:moderators");
    public static readonly OAuthScope ChannelReadPolls = new("channel:read:polls");
    public static readonly OAuthScope ChannelManagePolls = new("channel:manage:polls");
    public static readonly OAuthScope ChannelReadPredictions = new("channel:read:predictions");
    public static readonly OAuthScope ChannelManagePredictions = new("channel:manage:predictions");
    public static readonly OAuthScope ChannelManageRaids = new("channel:manage:raids");
    public static readonly OAuthScope ChannelReadRedemptions = new("channel:read:redemptions");
    public static readonly OAuthScope ChannelManageRedemptions = new("channel:manage:redemptions");
    public static readonly OAuthScope ChannelManageSchedule = new("channel:manage:schedule");
    public static readonly OAuthScope ChannelReadStreamKey = new("channel:read:stream_key");
    public static readonly OAuthScope ChannelReadSubscriptions = new("channel:read:subscriptions");
    public static readonly OAuthScope ChannelManageVideos = new("channel:manage:videos");
    public static readonly OAuthScope ChannelReadVips = new("channel:read:vips");
    public static readonly OAuthScope ChannelManageVips = new("channel:manage:vips");
    public static readonly OAuthScope ClipsEdit = new("clips:edit");
    public static readonly OAuthScope ModerationRead = new("moderation:read");
    public static readonly OAuthScope ModeratorManageAnnouncements = new("moderator:manage:announcements");
    public static readonly OAuthScope ModeratorManageAutomod = new("moderator:manage:automod");
    public static readonly OAuthScope ModeratorReadAutomodSettings = new("moderator:read:automod_settings");
    public static readonly OAuthScope ModeratorReadBannedUsers = new("moderator:read:banned_users");
    public static readonly OAuthScope ModeratorManageBannedUsers = new("moderator:manage:banned_users");
    public static readonly OAuthScope ModeratorReadBlockedTerms = new("moderator:read:blocked_terms");
    public static readonly OAuthScope ModeratorReadChatMessages = new("moderator:read:chat_messages");
    public static readonly OAuthScope ModeratorManageBlockedTerms = new("moderator:manage:blocked_terms");
    public static readonly OAuthScope ModeratorManageChatMessages = new("moderator:manage:chat_messages");
    public static readonly OAuthScope ModeratorReadChatSettings = new("moderator:read:chat_settings");
    public static readonly OAuthScope ModeratorManageChatSettings = new("moderator:manage:chat_settings");
    public static readonly OAuthScope ModeratorReadChatters = new("moderator:read:chatters");
    public static readonly OAuthScope ModeratorReadFollowers = new("moderator:read:followers");
    public static readonly OAuthScope ModeratorReadGuestStar = new("moderator:read:guest_star");
    public static readonly OAuthScope ModeratorManageGuestStar = new("moderator:manage:guest_star");
    public static readonly OAuthScope ModeratorReadModerators = new("moderator:read:moderators");
    public static readonly OAuthScope ModeratorReadShieldMode = new("moderator:read:shield_mode");
    public static readonly OAuthScope ModeratorManageShieldMode = new("moderator:manage:shield_mode");
    public static readonly OAuthScope ModeratorReadShoutouts = new("moderator:read:shoutouts");
    public static readonly OAuthScope ModeratorManageShoutouts = new("moderator:manage:shoutouts");
    public static readonly OAuthScope ModeratorReadSuspicousUsers = new("moderator:read:suspicious_users");
    public static readonly OAuthScope ModeratorReadUnbanRequests = new("moderator:read:unban_requests");
    public static readonly OAuthScope ModeratorManageUnbanRequests = new("moderator:manage:unban_requests");
    public static readonly OAuthScope ModeratorReadVips = new("moderator:read:vips");
    public static readonly OAuthScope ModeratorReadWarnings = new("moderator:read:warnings");
    public static readonly OAuthScope ModeratorManageWarnings = new("moderator:manage:warnings");
    public static readonly OAuthScope UserBot = new("user:bot");
    public static readonly OAuthScope UserEdit = new("user:edit");
    public static readonly OAuthScope UserEditBroadcast = new("user:edit:broadcast");
    public static readonly OAuthScope UserReadBlockedUsers = new("user:read:blocked_users");
    public static readonly OAuthScope UserManageBlockedUsers = new("user:manage:blocked_users");
    public static readonly OAuthScope UserReadBroadcast = new("user:read:broadcast");
    public static readonly OAuthScope UserReadChat = new("user:read:chat");
    public static readonly OAuthScope UserManageChatColor = new("user:manage:chat_color");
    public static readonly OAuthScope UserReadEmail = new("user:read:email");
    public static readonly OAuthScope UserReadEmotes = new("user:read:emotes");
    public static readonly OAuthScope UserReadFollows = new("user:read:follows");
    public static readonly OAuthScope UserReadModeratedChannels = new("user:read:moderated_channels");
    public static readonly OAuthScope UserReadSubscriptions = new("user:read:subscriptions");
    public static readonly OAuthScope UserReadWhispers = new("user:read:whispers");
    public static readonly OAuthScope UserWriteChat = new("user:write:chat");
    public static readonly OAuthScope ChatEdit = new("chat:edit");
    public static readonly OAuthScope ChatRead = new("chat:read");
    public static readonly OAuthScope WhispersRead = new("whispers:read");
}
