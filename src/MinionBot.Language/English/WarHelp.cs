namespace MinionBot.Languages.English
{
    public class WarHelp : IWarHelp
    {
        //war
        public string HelpCallTimer => "Set the amount of time a call is good for.";
        public string HelpStackCalls => "When enabled, multiple villages can call an enemy base at the same time.";
        public string HelpPrivateWars =>
"Tell Minion Bot that you will keep your war log closed. This will enable commands intended for private war logs such as start and report.";
        public string HelpPublicWars => "Tell Minion Bot that you will keep your war log open. Your war caller will be managed automatically.";
        public string HelpPrint => "View the villages that are called in this war.";
        public string HelpStart => "This command is only for clans that keep their war log private. Use it to start a new war in Minion Bot.";
        public string HelpReport => "This command is only for clans that keep their war log private. Use it to report the outcome of an attack.";
        public string HelpCall => "Call a given enemy base.";
        public string HelpDelete =>
"Delete a call on an enemy base. Only providing the defender position will delete your own call on the base, or the first call on that base.";
        public string HelpNoStats =>
"Attacks will not count toward stats nor leaderboards if you run this. This enables you to have a fun war where the results don't matter. You must be a coleader to run this.";
        public string HelpGetRemainingAttacks =>
"This will show who has attacks left for your clan. If the village has a call, it will show that as well.";
        public string HelpGetLastAttacks => "View the last attacks.";
        public string HelpGetLastDefenses => "View the last defenses.";
        public string HelpGetWars => "Get a list of all known wars for a clan.";
        public string HelpMatchup => "View a side by side comparison of the current war.";
        public string HelpDefenses => "Get a summary of defenses remaining.";
        public string HelpAnnounceWar => "Print the war found announcement.";
        public string HelpAttacks => "Show the number of attacks left for each side of the war map.";
        public string HelpRoster => "View a summary of the villages in a given war.";
        public string HelpLineup => "View detailed information on each village in the current war.";
    }
}