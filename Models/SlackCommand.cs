using Microsoft.AspNetCore.Mvc;

namespace EzMeetAPI.Models
{
    /// <summary>
    /// This request contains a data payload describing the source command and who invoked
    /// it, like a really detailed knock at the door.
    /// </summary>
    /// <seealso href="https://api.slack.com/interactivity/slash-commands" />
    public class SlackCommand
    {
        /// <summary>
        /// This is a verification token, a deprecated feature that you shouldn't use any more.
        /// It was used to verify that requests were legitimately being sent by Slack to your
        /// app, but you should use the signed secrets functionality to do this instead.
        /// </summary>
        [FromForm(Name = "token")]
        public string Token { get; set; }
        [FromForm(Name = "team_id")]
        public string TeamID { get; set; }
        [FromForm(Name = "team_domain")]
        public string TeamDomain { get; set; }
        [FromForm(Name = "enterprise_id")]
        public string EnterpriseID { get; set; }
        [FromForm(Name = "enterprise_name")]
        public string EnterpriseName { get; set; }
        [FromForm(Name = "channel_id")]
        public string ChannelID { get; set; }
        [FromForm(Name = "channel_name")]
        public string ChannelName { get; set; }
        /// <summary>
        /// The ID of the user who triggered the command.
        /// </summary>
        [FromForm(Name = "user_id")]
        public string UserID { get; set; }
        /// <summary>
        /// The plain text name of the user who triggered the command. Do not rely on this
        /// field as it is being phased out, use the <see cref="UserID"/> instead.
        /// </summary>
        [FromForm(Name = "user_name")]
        public string UserName { get; set; }
        /// <summary>
        /// The command that was typed in to trigger this request. This value can be useful
        /// if you want to use a single Request URL to service multiple Slash Commands,
        /// as it lets you tell them apart.
        /// </summary>
        [FromForm(Name = "command")]
        public string Command { get; set; }
        /// <summary>
        /// This is the part of the Slash Command after the command itself, and it
        /// can contain absolutely anything that the user might decide to type. It
        /// is common to use this text parameter to provide extra context for the command.
        ///
        /// You can prompt users to adhere to a particular format by showing them in
        /// the Usage Hint field when creating a command.
        /// </summary>
        [FromForm(Name = "text")]
        public string Text { get; set; }
        /// <summary>
        /// A temporary webhook URL that you can use to generate messages responses.
        /// </summary>
        [FromForm(Name = "response_url")]
        public string ResponseUrl { get; set; }
        /// <summary>
        /// A short-lived ID that will let your app open a modal.
        /// </summary>
        [FromForm(Name = "trigger_id")]
        public string TriggerID { get; set; }
        /// <summary>
        /// Your Slack app's unique identifier. Use this in conjunction with request
        /// signing to verify context for inbound requests.
        /// </summary>
        [FromForm(Name = "api_app_id")]
        public string ApiAppID { get; set; }
    }
}
