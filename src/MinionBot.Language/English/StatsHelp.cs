namespace MinionBot.Languages.English
{
    public class StatsHelp : IStatsHelp
    {
        public string HelpLeagueStats => "Show the stats for this week's league wars.";
        public string HelpBotLeader =>
@"Get the best attackers or defenders in the entire bot.
This will get the best hit rates for all villages, regardless of clan.
War Type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.";
        public string HelpClanLeagueLeader =>
@"This will show which clan has the best hit rate in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.";
        public string HelpClanStats =>
@"Get stats from a clans entire attack history.
This will look like the stats for a village, but it will show the entire clan.
This allows you to enter other clan's tag to compare clans.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.";
        public string HelpLeagueLeader => "This command is retired";
        //"This will show the league with the best hit rate. Fresh type can be fresh or cleanup."
        public string HelpStats =>
@"View the stats for the current war, a village, or a discord user.
Number of months will limit the attacks to the last X months.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.
The clan parameter will exclude attacks your clanmates have done while in other clans.
War IDs can be found using the getwars command.";
        public string HelpCwlStats => "This will show the current wars for all clans in your current SC CWL league.";
        public string HelpVillageLeader =>
@"This will show where you rank among your clan.
Number of months will limit the attacks to the last X months.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.
The clan parameter will exclude attacks your clanmates have done while in other clans.";
        public string HelpVillageLeagueLeader =>
@"This will show the best attackers and defenders in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.";
    }
}