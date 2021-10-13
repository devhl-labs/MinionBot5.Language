namespace MinionBot.Languages
{
    public interface IWarHelp
    {
        string HelpLineup { get; }
        string HelpRoster { get; }
        string HelpAttacks { get; }
        string HelpAnnounceWar { get; }
        string HelpDefenses { get; }
        string HelpMatchup { get; }
        string HelpGetWars { get; }
        string HelpGetLastDefenses { get; }
        string HelpGetLastAttacks { get; }
        string HelpGetRemainingAttacks { get; }
        string HelpNoStats { get; }
        string HelpDelete { get; }
        string HelpCall { get; }
        string HelpReport { get; }
        string HelpStart { get; }
        string HelpPrint { get; }
        string HelpPublicWars { get; }
        string HelpPrivateWars { get; }
        string HelpStackCalls { get; }
        string HelpCallTimer { get; }
    }
}