namespace MinionBot.Languages
{
    public interface IVillageHelp
    {
        // village
        string HelpSuperTroops { get; }
        string HelpClaimAttacks { get; }
        string HelpUpdateMembers { get; }
        string HelpUnclaim { get; }
        string HelpSearch { get; }
        string HelpPrefer { get; }
        string HelpMyBase { get; }
        string HelpLookup { get; }
        string HelpMembers { get; }
        string HelpGetUnclaimed { get; }
        string HelpGetClaims { get; }
        string HelpGetBans { get; }
        string HelpGetAlias { get; }
        string HelpDeleteAlias { get; }
        string HelpClaim { get; }
        string HelpUnBanVillage { get; }
        string HelpBanVillage { get; }
        string HelpAlias { get; }
    }
}