namespace MinionBot.Languages
{
    public interface IManagementHelp
    {
        string HelpDeletePrefix { get; }
        string HelpSetPrefix { get; }
        string HelpSetLanguage { get; }
        string HelpStartWarning { get; }
        string HelpEndWarning { get; }
        string HelpPostGreetings { get; }
        string HelpPostDonations { get; }
        string HelpPostHits { get; }
        string HelpRestrict { get; }
        string HelpAddRoles { get; }
        string HelpDeleteRoles { get; }
        string HelpMyChannels { get; }
        string HelpMyChannel { get; }
        string HelpMyRoles { get; }
        string HelpMyClan { get; }
        string HelpMyServer { get; }
        string HelpMyClans { get; }
        string HelpDefaultClan { get; }
        string HelpUnclaimClan { get; }
        string HelpClaimClan { get; }
    }
}