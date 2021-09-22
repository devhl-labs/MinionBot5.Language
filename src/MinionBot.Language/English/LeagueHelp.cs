namespace MinionBot.Languages.English
{
    public class LeagueHelp : ILeagueHelp
    {
        public string HelpDivisions => "View the divisions in a given league.";
        public string HelpScoreboard => "View the scoreboard for a league.";
        public string HelpValidate => "Check a given clan to see if any members have any bans in competitive leagues.";
        public string HelpCreateOrg => "Create an organization.";
        public string HelpChange => "Drill down to see more.";
        public string HelpChangeOrg => "Change an organization.";
        public string HelpChangeClan => "Change a registrant.";
        public string HelpChangeLeague => "Change a league.";
        public string HelpCreateLeague => "Create a league.";
        public string HelpInspect => "View information about an object.";
        public string HelpRequestLeague =>
@"If the current war is a league war, run this command to request to mark it as a league war.
Your request will be sent to the support server.
A league rep will need to approve it.";
        public string HelpGetOrgBans => "View all bans for an organization.";
        public string HelpLeagueRep => "View all league reps or assign league rep to a member.";
        public string HelpAddClan => "Add clans to a league.";
        public string HelpRemoveClan => "Remove a clan from a league.";
        public string HelpShell => "Add a registrant clan under a participant.";
        public string HelpUnshell => "Move a registrant to their own participant.";
        public string HelpImport => "Import clan tags from a war match url.";
        public string HelpAddWar => "Add a war to the league. If specifying clan tags you may want to update stars and percent next.";
        public string HelpRemoveWar => "Remove a war from a league.";
        public string HelpOrgBan =>
"Ban villages from an organization. You will be notified if the village joins a registered clan or a war with a registered clan.";
        public string HelpOrgUnban => "Delete bans on villages from your organization.";
        public string HelpChangeWinner => "Change the winner of a league war. This will only be seen in the scoreboard, not the league stats.";
        public string HelpChangeStars => "Change the stars of a league war. This will only be seen in the scoreboard, not the league stats.";
        public string HelpChangePercent => "Change the percent for a league war. This will only be seen in the scoreboard, not the league stats.";
        public string HelpLeagueWinner => "Declare the league winner.";
        public string HelpShowPrivateWars => "View all clans in this league which war log is private.";
        public string HelpLog => "Manually enter an attack. You can get map positions from the roster command.";
        public string HelpUndo => "Delete a manually entered attack.";
        public string HelpSetMatch =>
"Set a match date for two participating clans. The date is in UTC. When the two clans match on this day (or in the next seven days) it will be automatically approved. Use `deletematch` to undo this.";
        public string HelpDeleteMatch => "Removes one or more scheduled matches";
        public string HelpRemoveAllClans => "Remove all clans from the league.";
        public string HelpRemoveAllWars => "Remove all wars from the league.";
    }
}