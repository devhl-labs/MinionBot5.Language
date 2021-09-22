namespace MinionBot.Languages
{
    public interface IDebugHelp
    {
        string HelpApi { get; }
        string HelpFetchClanWarLog { get; }
        string HelpFetchLeagueWar { get; }
        string HelpFetchLeagueGroup { get; }
        string HelpFetchPlayer { get; }
        string HelpFetchCurrentWar { get; }
        string HelpFetchClans { get; }
        string HelpFetchClan { get; }
        string HelpPermissions { get; }
        string HelpPing { get; }
    }
}