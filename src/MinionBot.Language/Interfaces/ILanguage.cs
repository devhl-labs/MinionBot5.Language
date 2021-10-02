using System.Collections.Generic;

namespace MinionBot.Languages
{
    public interface ILanguage
    {
        string Name { get; }
        string Aliases { get; }
        List<CommandInfo> Commands();


        IBot Bot { get; }

        IManagementHelp ManagementHelp { get; }
        IAboutHelp AboutHelp { get; }
        IDebugHelp DebugHelp { get; }
        ILeagueHelp LeagueHelp { get; }
        IVillageHelp VillageHelp { get; }
        IPatreonHelp PatreonHelp { get; }
        IWarHelp WarHelp { get; }
        IStatsHelp StatsHelp { get; }


        string AllRolesCanBeManaged { get; }
        string ThisLeagueIsInactive { get; }
        string SomeRolesCantBeManaged { get; }
        string ATimeoutOccured { get; }
        string ThisCommandIsNotForBots { get; }
        string QuotedParametersAreTypedAsShown { get; }
        string BracketedParametersAreOptional { get; }
        string AliasesMayNotContainSomeCharacters { get; }
        string AlreadySponsored { get; }
        string ThisCommandIsNotAvailableForCwlNorCompetitiveWars { get; }
        string NoStatsEnabled { get; }
        string NoStatsDisabled { get; }
        string BecomeAPatronToDownloadThis { get; }
        string CallStackingIsDisabled { get; }
        string CallTimerMustBeBetween { get; }
        string ChannelsWillBeRenamed { get; }
        string ClaimClan { get; }
        string ClanDescriptionMustEndWithMB { get; }
        string CommandCanceled { get; }
        string CommandMustBeRanInACategory { get; }
        string DefenderPositionMustBeBetween1And50 { get; }
        string IDontKnowThatLanguage { get; }
        string InvalidTag { get; }
        string InvalidTownHallLevel { get; }
        string LeagueNotFound { get; }
        string MustBeACrystalPatron { get; }
        string MustBeAGoldPatron { get; }
        string MustBeAMasterPatron { get; }
        string MustBeRanInGuild { get; }
        string MustClaimClan { get; }
        string MustUsePrivateWars { get; }
        string NeedPermissionToManageChannels { get; }
        string NoAttacksFound { get; }
        string NoClansToUnclaim { get; }
        string NotRestricted { get; }
        string NotSponsoringAnyServers { get; }
        string OrgNotFound { get; }
        string PleaseTryAgainAndProvideAReasonForTheBan { get; }
        string PrefixDefinition { get; }
        string PrefixRules { get; }
        string Restrict { get; }
        string RolesWillNoLongerBeUpdated { get; }
        string ServerMustBeSponsored { get; }
        string StarsMustBeBetween1And3 { get; }
        string StartANewWar { get; }
        string ThereAreNoResults { get; }
        string ThereIsAlreadyACallOnThisBase { get; }
        string ThisChannelAlreadyHasAClanClaimed { get; }
        string ThisChannelHasNoClanClaimed { get; }
        string ThisChannelMustBeInACategory { get; }
        string ThisCommandIsDisabledDuringCWL { get; }
        string ThisCommandIsOnlyForPrivateWars { get; }
        string ThisCommandMustBeRanInAServer { get; }
        string ThisLeagueHasNoDivisions { get; }
        string ThisOrgHasNoBans { get; }
        string ThisVillageIsClaimed { get; }
        string ThisVillageIsNotClaimedYet { get; }
        string NoVillagesClaimed { get; }
        string ThisWarIsAlreadyInALeague { get; }
        string VillageNotFound();
        public string VillageNotFound(string tag, string clanName, string input);
        string WarChannelFailed { get; }
        string WarSizeMustBeDivisibleBy5AndLessThan50 { get; }
        string YouAlreadyHaveThisVillageClaimed { get; }
        string YouAndThisBotMustHavePermissionToManageRoles { get; }
        string YouDontHaveAnyVillagesClaimed { get; }
        string YouMustBeACoLeaderToUnclaimAVillage { get; }
        string YouMustHavePermissionToManageGuild { get; }
        string YourClanCouldNotBeDetermined { get; }
        string YourRequestIsPendingApproval { get; }
        string YouHaveClaimedXAttacks(int count, string tag, string name);
        string AliasNotFound(string alias, string villageTag, string villageName);
        string AlreadyHasThisVillageClaimed(string userName);
        string AnErrorOccuredLocatingYourWar(string clanTag, string clanName);
        string ClanIsNotInWar(string clanTag, string clanName);
        string ClanNotClaimed();
        string ClanNotClaimed(string clanTag, string clanName);
        string ClanUnclaimed(string clanTag, string clanName);
        string RegistrantCantBeRemoved(string clanTag, string clanName);
        string ClanUnclaimedFromAllServers(string clanTag, string clanName);
        string CreatedXRoles(int count);
        string CreatedXRoles(int count, int errors);
        string CreatedXRoles(string clanTag, string clanName, int count);
        string DeletedXRoles(int count);
        string IsNowThePreferredAlias(string alias, string villageTag, string villageName);
        string NewClanDefault(string clanTag, string clanName);
        string NoAttacksLeft(string enemyClanTag, string enemyClanName);
        string NoLeagueWarsFoundInLastSixDays(string leagueInitials);
        string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season);
        string NoParticipants(string leagueInitials, int season);
        string NowRenamingChannel(string clanTag, string clanName, int position);
        string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName);
        string RolesWillBeUpdated(int roles);
        string SeeAWarThatIsMissing(string leagueInitials);
        string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName);
        string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName);
        string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName);
        string SponsoringServer(ulong id, string name);
        string ThisAliasIsInUse(string clanTag, string clanName);
        string ThisCommandWillRenameAllChannels(string clanTag, string clanName);
        string ThisVillageHasNoBans(string villageTag, string villageName);
        string ThisClanHasNoBans(string clanTag, string clanName);
        string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName);
        string ThisVillageHasNoOrgBans(string villageTag, string villageName);
        string UpdatedVillages(string clanTag, string clanName, int villageCount);
        string UseDeletePrefixToUndoThis(string userMention, string prefix);
        string VillageIsNotInAnActiveWar(string villageTag, string villageName);
        string VillageIsNotInWar(string villageTag, string villageName);
        string VillageIsOutOfAttacks(string villageTag, string villageName);
        string WarLogIsPrivate(string clanTag, string clanName);
        string YouAreNotInAnyActiveWarWar();
        string YouAreNotInAnyActiveWarWar(string userName);
        string YouAreOutOfAttacks();
        string YouAreOutOfAttacks(string cachedMemberDisplayName);
        string YouHaveClaimed(string villageTag, string villageName);
        string YourAliasIsNow(string villageTag, string villageName, string alias);
        string YourLanguageHasBeenChangedTo(string language);
        string BecomeAPatronToUseThisCommand { get; }
        string IncludeTheLeagueYouWouldLikeToSee { get; }
        string WarEndWarningsDisabled { get; }
        string WarEndWarningsEnabled { get; }
        string WarStartWarningsDisabled { get; }
        string WarStartWarningsEnabled { get; }
        string IncorrectParametersOrMissingPermission { get; }
        string CommandNameIsAPlaceHolder { get; }
        string YouHaveHiddenXAttacks(int count);
        string YouHaveUnhiddenXAttacks(int count);
        string CommandNotFound { get; }
        string ClanNotFound { get; }
        string SearchForClanReturnedNoResults(string clanTag);
        string NotADiscordServer { get; }
        string ServerNotFoundInCache { get; }
        string NotAServerMember { get; }
        string MemberNotFound { get; }
        string NotAMemberNorSelfTag { get; }
        string OrganizationNotFound { get; }
        string WarNotFound { get; }
        string NotADate { get; }
        string DivisionNotFound { get; }
        string NotAUrl { get; }
        string ValidWarTypes { get; }
        string CommandMustBeRanInSupportServer { get; }
        string CommandMustBeRanInYourServer { get; }
        string YouMustHavePermissionToManageChannels { get; }
        string MbGoesInGame { get; }
        string YourClanTagDoesNotEndInAPeriod { get; }
        string YouHaveBeenAssignedTheRole { get; }
    }
}