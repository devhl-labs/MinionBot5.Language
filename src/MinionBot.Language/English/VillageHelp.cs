namespace MinionBot.Languages.English
{
    public class VillageHelp : IVillageHelp
    {
        public string HelpAlias => "Give a village a nickname. Keep it short and easy to type.";

        public string HelpBanVillage => "Ban a village from your clan.";

        public string HelpUnBanVillage => "Unban a village from your clan.";

        public string HelpClaim =>
@"Tell the bot who owns a village.
Use a @discordMention to help your clanmates claim their village.
If you're having trouble using the name of the village, try using the village tag.";

        public string HelpDeleteAlias =>
@"Use this to delete an old alias.
Especially useful after you change a village name in game.
Aliases should be unique, so you should only have to provide this command the alias name.";

        public string HelpGetAlias => "View all nicknames for a village.";

        public string HelpGetBans => "View all bans for your clan or a given village.";

        public string HelpGetClaims => "Provides an overview of which villages are claimed.";

        public string HelpGetUnclaimed => "View all villages that are not claimed.";

        public string HelpMembers => "View all the members who are currently in your clan.";

        public string HelpLookup => "Lookup various information about a village.";

        public string HelpMyBase => "View information on a given base.";

        public string HelpPrefer =>
@"Minion Bot will try to use the prefered alias over other aliases.
You may only have one prefered alias at a time.
Aliases should be unique, so you only need to provide the alias name.";

        public string HelpSearch =>
@"Use this to see what villages are in your clan.
Also use it to quickly get your clanmates village tag.
Provide a string to search to narrow the results.";

        public string HelpUnclaim => "Unassociate a village from a discord user.";

        public string HelpUpdateMembers => "Update roles and hero levels for all villages in your clan.";

        public string HelpClaimAttacks =>
@"This will claim all previously unclaimed attacks.
This includes attacks and defenses done before you claimed the village.
**This cannot be undone.**";
        public string HelpSuperTroops => "See what villages have super troops unlocked.";
    }
}