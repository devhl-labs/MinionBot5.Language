﻿namespace MinionBot.Languages
{
    public interface ILeagueHelp
    {
        string HelpRemoveAllWars { get; }
        string HelpRemoveAllClans { get; }
        string HelpDeleteMatch { get; }
        string HelpSetMatch { get; }
        string HelpUndo { get; }
        string HelpLog { get; }
        string HelpShowPrivateWars { get; }
        string HelpLeagueWinner { get; }
        string HelpChangePercent { get; }
        string HelpChangeStars { get; }
        string HelpChangeWinner { get; }
        string HelpOrgUnban { get; }
        string HelpOrgBan { get; }
        string HelpRemoveWar { get; }
        string HelpAddWar { get; }
        string HelpImport { get; }
        string HelpUnshell { get; }
        string HelpShell { get; }
        string HelpRemoveClan { get; }
        string HelpAddClan { get; }
        string HelpLeagueRep { get; }
        string HelpGetOrgBans { get; }
        string HelpRequestLeague { get; }
        string HelpInspect { get; }
        string HelpCreateLeague { get; }
        string HelpChangeLeague { get; }
        string HelpChangeClan { get; }
        string HelpChangeOrg { get; }
        string HelpChange { get; }
        string HelpCreateOrg { get; }
        string HelpValidate { get; }
        string HelpScoreboard { get; }
        string HelpDivisions { get; }
    }
}