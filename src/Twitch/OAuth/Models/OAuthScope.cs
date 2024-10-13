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

    /// <summary>
    /// View Creator Goals for a channel.<br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-creator-goals">Get Creator Goals</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelgoalbegin">Goal Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelgoalprogress">Goal Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelgoalend">Goal End</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadGoals = new("channel:read:goals");

    /// <summary>
    /// Read Guest Star details for your channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-channel-guest-star-settings">Get Channel Guest Star Settings</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-guest-star-session">Get Guest Star Session</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-guest-star-invites">Get Guest Star Invites</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionbegin">Channel Guest Star Session Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionend">Channel Guest Star Session End</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_guestupdate">Channel Guest Star Guest Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_settingsupdate">Channel Guest Star Settings Update</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadGuestStar = new("channel:read:guest_star");

    /// <summary>
    /// Manage Guest Star for your channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-channel-guest-star-settings">Update Channel Guest Star Settings</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-guest-star-session">Create Guest Star Session</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#end-guest-star-session">End Guest Star Session</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#send-guest-star-invite">Send Guest Star Invite</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-guest-star-invite">Delete Guest Star Invite</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#assign-guest-star-slot">Assign Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-guest-star-slot">Update Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-guest-star-slot">Delete Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-guest-star-slot-settings">Update Guest Star Slot Settings</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionbegin">Channel Guest Star Session Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionend">Channel Guest Star Session End</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_guestupdate">Channel Guest Star Guest Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_settingsupdate">Channel Guest Star Settings Update</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageGuestStar = new("channel:manage:guest_star");

    /// <summary>
    /// View Hype Train information for a channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-hype-train-events">Get Hype Train Events</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelhype_trainbegin">Hype Train Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelhype_trainprogress">Hype Train Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelhype_trainend">Hype Train End</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadHypeTrain = new("channel:read:hype_train");

    /// <summary>
    /// Add or remove the moderator role from users in your channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#add-channel-moderator">Add Channel Moderator</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#remove-channel-moderator">Remove Channel Moderator</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-moderators">Get Moderators</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageModerators = new("channel:manage:moderators");

    /// <summary>
    /// View a channel’s polls.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-polls">Get Polls</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollbegin">Channel Poll Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollprogress">Channel Poll Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollend">Channel Poll End</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadPolls = new("channel:read:polls");

    /// <summary>
    /// Manage a channel’s polls.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-polls">Get Polls</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-poll">Create Poll</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#end-poll">End Poll</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollbegin">Channel Poll Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollprogress">Channel Poll Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpollend">Channel Poll End</a>
    /// </summary>
    public static readonly OAuthScope ChannelManagePolls = new("channel:manage:polls");

    /// <summary>
    /// View a channel’s Channel Points Predictions.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-predictions">Get Channel Points Predictions</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionbegin">Channel Prediction Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionprogress">Channel Prediction Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionlock">Channel Prediction Lock</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionend">Channel Prediction End</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadPredictions = new("channel:read:predictions");

    /// <summary>
    /// Manage of channel’s Channel Points Predictions<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-predictions">Get Channel Points Predictions</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-prediction">Create Channel Points Prediction</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#end-prediction">End Channel Points Prediction</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionbegin">Channel Prediction Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionprogress">Channel Prediction Progress</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionlock">Channel Prediction Lock</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelpredictionend">Channel Prediction End</a>
    /// </summary>
    public static readonly OAuthScope ChannelManagePredictions = new("channel:manage:predictions");

    /// <summary>
    /// Manage a channel raiding another channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#start-a-raid">Start a raid</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#cancel-a-raid">Cancel a raid</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageRaids = new("channel:manage:raids");

    /// <summary>
    /// View Channel Points custom rewards and their redemptions on a channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-custom-reward">Get Custom Reward</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-custom-reward-redemption">Get Custom Reward Redemption</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_automatic_reward_redemptionadd">Channel Points Automatic Reward Redemption</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardadd">Channel Points Custom Reward Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardupdate">Channel Points Custom Reward Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardremove">Channel Points Custom Reward Remove</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_reward_redemptionadd">Channel Points Custom Reward Redemption Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_reward_redemptionupdate">Channel Points Custom Reward Redemption Update</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadRedemptions = new("channel:read:redemptions");

    /// <summary>
    /// Manage Channel Points custom rewards and their redemptions on a channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-custom-reward">Get Custom Reward</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-custom-reward-redemption">Get Custom Reward Redemption</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-custom-rewards">Create Custom Rewards</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-custom-reward">Delete Custom Reward</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-custom-reward">Update Custom Reward</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-redemption-status">Update Redemption Status</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_automatic_reward_redemptionadd">Channel Points Automatic Reward Redemption</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardadd">Channel Points Custom Reward Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardupdate">Channel Points Custom Reward Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_rewardremove">Channel Points Custom Reward Remove</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_reward_redemptionadd">Channel Points Custom Reward Redemption Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchannel_points_custom_reward_redemptionupdate">Channel Points Custom Reward Redemption Update</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageRedemptions = new("channel:manage:redemptions");

    /// <summary>
    /// Manage a channel’s stream schedule.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-channel-stream-schedule">Update Channel Stream Schedule</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-channel-stream-schedule-segment">Create Channel Stream Schedule Segment</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-channel-stream-schedule-segment">Update Channel Stream Schedule Segment</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-channel-stream-schedule-segment">Delete Channel Stream Schedule Segment</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageSchedule = new("channel:manage:schedule");

    /// <summary>
    /// View an authorized user’s stream key.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-stream-key">Get Stream Key</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadStreamKey = new("channel:read:stream_key");

    /// <summary>
    /// View a list of all subscribers to a channel and check if a user is subscribed to a channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-broadcaster-subscriptions">Get Broadcaster Subscriptions</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscribe">Channel Subscribe</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscriptionend">Channel Subscription End</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscriptiongift">Channel Subscription Gift</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsubscriptionmessage">Channel Subscription Message</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadSubscriptions = new("channel:read:subscriptions");

    /// <summary>
    /// Manage a channel’s videos, including deleting videos.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-videos">Delete Videos</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageVideos = new("channel:manage:videos");

    /// <summary>
    /// Read the list of VIPs in your channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-vips">Get VIPs</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelvipadd">Channel VIP Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelvipremove">Channel VIP Remove</a>
    /// </summary>
    public static readonly OAuthScope ChannelReadVips = new("channel:read:vips");

    /// <summary>
    /// Add or remove the VIP role from users in your channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-vips">Get VIPs</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#add-channel-vip">Add Channel VIP</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#remove-channel-vip">Remove Channel VIP</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelvipadd">Channel VIP Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelvipremove">Channel VIP Remove</a>
    /// </summary>
    public static readonly OAuthScope ChannelManageVips = new("channel:manage:vips");

    /// <summary>
    /// Manage Clips for a channel.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#create-clip">Create Clip</a>
    /// </summary>
    public static readonly OAuthScope ClipsEdit = new("clips:edit");

    /// <summary>
    /// View a channel’s moderation data including Moderators, Bans, Timeouts, and Automod settings.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#check-automod-status">Check AutoMod Status</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-banned-users">Get Banned Users</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-moderators">Get Moderators</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderatoradd">Channel Moderator Add</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderatorremove">Channel Moderator Remove</a>
    /// </summary>
    public static readonly OAuthScope ModerationRead = new("moderation:read");

    /// <summary>
    /// Send announcements in channels where you have the moderator role.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#send-chat-announcement">Send Chat Announcement</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageAnnouncements = new("moderator:manage:announcements");

    /// <summary>
    /// Manage messages held for review by AutoMod in channels where you are a moderator.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#manage-held-automod-messages">Manage Held AutoMod Messages</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#automodmessagehold">AutoMod Message Hold</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#automodmessageupdate">AutoMod Message Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/authentication/eventsub/eventsub-subscription-types/#automodtermsupdate">AutoMod Terms Update</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageAutomod = new("moderator:manage:automod");

    /// <summary>
    /// Manage a broadcaster’s AutoMod settings.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-automod-settings">Update AutoMod Settings</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadAutomodSettings = new("moderator:read:automod_settings");

    /// <summary>
    /// Read the list of bans or unbans in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadBannedUsers = new("moderator:read:banned_users");

    /// <summary>
    /// Ban and unban users.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-banned-users">Get Banned Users</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#ban-user">Ban User</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#unban-user">Unban User</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageBannedUsers = new("moderator:manage:banned_users");

    /// <summary>
    /// View a broadcaster’s list of blocked terms.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-blocked-terms">Get Blocked Terms</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadBlockedTerms = new("moderator:read:blocked_terms");

    /// <summary>
    /// Read deleted chat messages in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadChatMessages = new("moderator:read:chat_messages");

    /// <summary>
    /// Manage a broadcaster’s list of blocked terms.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-blocked-terms">Get Blocked Terms</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#add-blocked-term">Add Blocked Term</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#remove-blocked-term">Remove Blocked Term</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageBlockedTerms = new("moderator:manage:blocked_terms");

    /// <summary>
    /// Delete chat messages in channels where you have the moderator role<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-chat-messages">Delete Chat Messages</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageChatMessages = new("moderator:manage:chat_messages");

    /// <summary>
    /// View a broadcaster’s chat room settings.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-chat-settings">Get Chat Settings</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadChatSettings = new("moderator:read:chat_settings");

    /// <summary>
    /// Manage a broadcaster’s chat room settings.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-chat-settings">Update Chat Settings</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageChatSettings = new("moderator:manage:chat_settings");

    /// <summary>
    /// View the chatters in a broadcaster’s chat room.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-chatters">Get Chatters</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadChatters = new("moderator:read:chatters");

    /// <summary>
    /// Read the followers of a broadcaster.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-channel-followers">Get Channel Followers</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelfollow">Channel Follow</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadFollowers = new("moderator:read:followers");

    /// <summary>
    /// Read Guest Star details for channels where you are a Guest Star moderator.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-channel-guest-star-settings">Get Channel Guest Star Settings</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-guest-star-session">Get Guest Star Session</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-guest-star-invites">Get Guest Star Invites</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionbegin">Channel Guest Star Session Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionend">Channel Guest Star Session End</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_guestupdate">Channel Guest Star Guest Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_settingsupdate">Channel Guest Star Settings Update</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadGuestStar = new("moderator:read:guest_star");

    /// <summary>
    /// Manage Guest Star for channels where you are a Guest Star moderator.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#send-guest-star-invite">Send Guest Star Invite</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-guest-star-invite">Delete Guest Star Invite</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#assign-guest-star-slot">Assign Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-guest-star-slot">Update Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#delete-guest-star-slot">Delete Guest Star Slot</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-guest-star-slot-settings">Update Guest Star Slot Settings</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionbegin">Channel Guest Star Session Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_sessionend">Channel Guest Star Session End</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_guestupdate">Channel Guest Star Guest Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelguest_star_settingsupdate">Channel Guest Star Settings Update</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageGuestStar = new("moderator:manage:guest_star");

    /// <summary>
    /// Read the list of moderators in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadModerators = new("moderator:read:moderators");

    /// <summary>
    /// View a broadcaster’s Shield Mode status.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-shield-mode-status">Get Shield Mode Status</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshield_modebegin">Shield Mode Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshield_modeend">Shield Mode End</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadShieldMode = new("moderator:read:shield_mode");

    /// <summary>
    /// Manage a broadcaster’s Shield Mode status.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-shield-mode-status">Update Shield Mode Status</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshield_modebegin">Shield Mode Begin</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshield_modeend">Shield Mode End</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageShieldMode = new("moderator:manage:shield_mode");

    /// <summary>
    /// View a broadcaster’s shoutouts.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshoutoutcreate">Shoutout Create</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshoutoutreceive">Shoutout Received</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadShoutouts = new("moderator:read:shoutouts");

    /// <summary>
    /// Manage a broadcaster’s shoutouts.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#send-a-shoutout">Send a Shoutout</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshoutoutcreate">Shoutout Create</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelshoutoutreceive">Shoutout Received</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageShoutouts = new("moderator:manage:shoutouts");

    /// <summary>
    /// Read chat messages from suspicious users and see users flagged as suspicious in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsuspicious_usermessage">Channel Suspicious User Message</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelsuspicious_userupdate">Channel Suspicious User Update</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadSuspicousUsers = new("moderator:read:suspicious_users");

    /// <summary>
    /// View a broadcaster’s unban requests.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-unban-requests">Get Unban Requests</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelunban_requestcreate">Channel Unban Request Create</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelunban_requestresolve">Channel Unban Request Resolve</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadUnbanRequests = new("moderator:read:unban_requests");

    /// <summary>
    /// Manage a broadcaster’s unban requests.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#resolve-unban-requests">Resolve Unban Requests</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelunban_requestcreate">Channel Unban Request Create</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelunban_requestresolve">Channel Unban Request Resolve</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageUnbanRequests = new("moderator:manage:unban_requests");

    /// <summary>
    /// Read the list of VIPs in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate">Channel Moderate</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadVips = new("moderator:read:vips");

    /// <summary>
    /// Read warnings in channels where you have the moderator role.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelwarningacknowledge">Channel Warning Acknowledge</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelwarningsend">Channel Warning Send</a>
    /// </summary>
    public static readonly OAuthScope ModeratorReadWarnings = new("moderator:read:warnings");

    /// <summary>
    /// Warn users in channels where you have the moderator role.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#warn-chat-user">Warn Chat User</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelmoderate-v2">Channel Moderate v2</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelwarningacknowledge">Channel Warning Acknowledge</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelwarningsend">Channel Warning Send</a>
    /// </summary>
    public static readonly OAuthScope ModeratorManageWarnings = new("moderator:manage:warnings");

    /// <summary>
    /// Join a specified chat channel as your user and appear as a bot, and perform chat-related actions as your user.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#send-chat-message">Send Chat Message</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear">Channel Chat Clear</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear_user_messages">Channel Chat Clear User Messages</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage">Channel Chat Message</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage_delete">Channel Chat Message Delete</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatnotification">Channel Chat Notification</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchat_settingsupdate">Channel Chat Settings Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchat_user_message_hold">Channel Chat User Message Hold</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatuser_message_update">Channel Chat User Message Update</a>
    /// </summary>
    public static readonly OAuthScope UserBot = new("user:bot");

    /// <summary>
    /// Manage a user object.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-user">Update User</a>
    /// </summary>
    public static readonly OAuthScope UserEdit = new("user:edit");

    /// <summary>
    /// View and edit a user’s broadcasting configuration, including Extension configurations.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-user-extensions">Get User Extensions</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-user-active-extensions">Get User Active Extensions</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#update-user-extensions">Update User Extensions</a>
    /// </summary>
    public static readonly OAuthScope UserEditBroadcast = new("user:edit:broadcast");

    /// <summary>
    /// View the block list of a user.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-user-block-list">Get User Block List</a>
    /// </summary>
    public static readonly OAuthScope UserReadBlockedUsers = new("user:read:blocked_users");

    /// <summary>
    /// Manage the block list of a user.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#block-user">Block User</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#unblock-user">Unblock User</a>
    /// </summary>
    public static readonly OAuthScope UserManageBlockedUsers = new("user:manage:blocked_users");

    /// <summary>
    /// View a user’s broadcasting configuration, including Extension configurations.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-stream-markers">Get Stream Markers</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-user-extensions">Get User Extensions</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-user-active-extensions">Get User Active Extensions</a>
    /// </summary>
    public static readonly OAuthScope UserReadBroadcast = new("user:read:broadcast");

    /// <summary>
    /// Receive chatroom messages and informational notifications relating to a channel’s chatroom.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear">Channel Chat Clear</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatclear_user_messages">Channel Chat Clear User Messages</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage">Channel Chat Message</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatmessage_delete">Channel Chat Message Delete</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatnotification">Channel Chat Notification</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchat_settingsupdate">Channel Chat Settings Update</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatuser_message_hold">Channel Chat User Message Hold</a><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#channelchatuser_message_update">Channel Chat User Message Update</a>
    /// </summary>
    public static readonly OAuthScope UserReadChat = new("user:read:chat");

    /// <summary>
    /// Update the color used for the user’s name in chat.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#update-user-chat-color">Update User Chat Color</a>
    /// </summary>
    public static readonly OAuthScope UserManageChatColor = new("user:manage:chat_color");

    /// <summary>
    /// View a user’s email address.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-users">Get Users</a> (optional)<br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#update-user">Update User</a> (optional)<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#userupdate">User Update</a> (optional)
    /// </summary>
    public static readonly OAuthScope UserReadEmail = new("user:read:email");

    /// <summary>
    /// View emotes available to a user<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#get-user-emotes">Get User Emotes</a>
    /// </summary>
    public static readonly OAuthScope UserReadEmotes = new("user:read:emotes");

    /// <summary>
    /// View the list of channels a user follows.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-followed-channels">Get Followed Channels</a><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-followed-streams">Get Followed Streams</a>
    /// </summary>
    public static readonly OAuthScope UserReadFollows = new("user:read:follows");

    /// <summary>
    /// Read the list of channels you have moderator privileges in.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#get-moderated-channels">Get Moderated Channels</a>
    /// </summary>
    public static readonly OAuthScope UserReadModeratedChannels = new("user:read:moderated_channels");

    /// <summary>
    /// View if an authorized user is subscribed to specific channels.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#check-user-subscription">Check User Subscription</a>
    /// </summary>
    public static readonly OAuthScope UserReadSubscriptions = new("user:read:subscriptions");

    /// <summary>
    /// Receive whispers sent to your user.<br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#userwhispermessage">Whisper Received</a>
    /// </summary>
    public static readonly OAuthScope UserReadWhispers = new("user:read:whispers");

    /// <summary>
    /// Receive whispers sent to your user, and send whispers on your user’s behalf.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference#send-whisper">Send Whisper</a><br/><br/>
    /// <b>EventSub</b><br/>
    /// <a href="https://dev.twitch.tv/docs/eventsub/eventsub-subscription-types/#userwhispermessage">Whisper Received</a>
    /// </summary>
    public static readonly OAuthScope UserManageWhispers = new("user:manage:whispers");

    /// <summary>
    /// Send chat messages to a chatroom.<br/><br/>
    /// <b>API</b><br/>
    /// <a href="https://dev.twitch.tv/docs/api/reference/#send-chat-message">Send Chat Message</a>
    /// </summary>
    public static readonly OAuthScope UserWriteChat = new("user:write:chat");

    /// <summary>
    /// Send chat messages to a chatroom using an IRC connection.
    /// </summary>
    public static readonly OAuthScope ChatEdit = new("chat:edit");

    /// <summary>
    /// View chat messages sent in a chatroom using an IRC connection.
    /// </summary>
    public static readonly OAuthScope ChatRead = new("chat:read");

    /// <summary>
    /// Receive whisper messages for your user using PubSub.
    /// </summary>
    public static readonly OAuthScope WhispersRead = new("whispers:read");
}
