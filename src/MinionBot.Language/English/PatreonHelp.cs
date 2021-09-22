namespace MinionBot.Languages.English
{
    public class PatreonHelp : IPatreonHelp
    {
        //patreon
        public string HelpDownloadAttacks => "Download a file containing your attacks.";
        public string HelpWarChannel =>
"This command will rename a channel to reflect the number of stars on an enemy base. You must have permission to manage channel.";
        public string HelpSponsorServer => "Sponsor the current server.";
        public string HelpUnsponsorServer => "Stop sponsoring a server. You can get the server ID from `mysponsorships`.";
        public string HelpMySponsorShip => "View all of the servers you are sponsoring.";
        public string HelpFreshEmote => "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack or defense.";
        public string HelpFreshAttack => "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack.";
        public string HelpFreshDefense => "Sponsored servers can use this to control what emoji is displayed for a fresh three star defense.";
        public string HelpHideAttacks =>
@"This will hide any attack that you have claimed. You must be a master patron to use this command. Your attacks are claimed by having the village claimed while the attack occurs or throught the claimattacks command.";
        public string HelpPatreon => "Show your love for Minion Bot! Get a role in the support server and a few added perks.";
    }
}