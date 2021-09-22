namespace MinionBot.Languages.English
{
    public class ManagementHelp : IManagementHelp
    {
        public string HelpUnclaimClan =>
@"You may remove a clan from your server.
To add it back, you will need to add 'mb' to the description again.";

        public string HelpDefaultClan =>
@"Allows you to tell Minion Bot which clan to use in channels where claimclan has never been ran.
You may run this after running claimclan.
The first clan you claim in a server is automatcally the default clan.";

        public string HelpMyClans => "View all the clans your server has claimed.";

        public string HelpMyServer => "Get information about your server.";

        public string HelpMyClan => "Use this command to see what clan tag Minion Bot is using in a given channel.";

        public string HelpMyRoles => "Get the roles that are managed by this bot.";

        public string HelpMyChannel => "Get information on your channel's settings.";

        public string HelpMyChannels => "Get information on all of your channel settings.";

        public string HelpDeleteRoles => "This will delete all of the roles that were created by this bot.";

        public string HelpAddRoles =>
@"This will create predefined roles in this server.
These roles will be assigned automatically.
You can rename or delete the roles created by this command.";

        public string HelpRestrict => "This will make Minion Bot ignore commands in a channel. It is recommended that you use discord permissions instead of this command.";

        public string HelpPostHits => "Control what channels the attacks get posted to. You must have permission to manage channel to change the channel.";

        public string HelpPostDonations => "Control what channel donations are posted to. You must have permission to manage channel.";

        public string HelpPostGreetings => "Control what channel greetings are posted to. You must have permission to manage channel.";

        public string HelpEndWarning => "Toggle hasHits mentions for the war end warning. If you do not have the hasHits role this will not do anything.";

        public string HelpStartWarning => "Toggle hasHits mentions for the war start warning. If you do not have the hasHits role this will not do anything.";

        public string HelpSetLanguage => "Change the language. Visit [github.com](https://github.com/devhl-labs/MinionBot5.Language) to view the supported languages.";

        public string HelpSetPrefix =>
@"By default Minion Bot has no prefix. 
Assign one of your choice with this command.
Once assigned, commands will require the prefix to run.
If your prefix is !, the help command will look like !help.
Use deleteprefix to undo this.";

        public string HelpDeletePrefix => "This command will delete your prefix.";

        public string HelpClaimClan =>
@"Run this command for each clan you want to claim in a different channel.
You must put the letters 'mb' after the clan description for this to work.";
    }
}