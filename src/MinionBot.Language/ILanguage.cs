using System.Collections.Generic;

namespace MinionBot.Language
{
    public interface ILanguage
    {
        string Name { get; }

        string Aliases { get; }

        public string AllRolesCanBeManaged { get; }

        public string ThisLeagueIsInactive { get; }
        public string SomeRolesCantBeManaged { get; }
        public string ATimeoutOccured { get; }
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

        //List<CommandInfo> Commands { get; }





        // about
        string HelpClaimClan { get; }
        string HelpInvite { get; }
        string HelpForTwitch { get; }
        string HelpSetupVideo { get; }
        string HelpCommands { get; }
        string HelpInfo { get; }


        // debugging
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


        // league
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



        // patreon
        string HelpPatreon { get; }
        string HelpHideAttacks { get; }
        string HelpFreshDefense { get; }
        string HelpFreshAttack { get; }
        string HelpFreshEmote { get; }
        string HelpMySponsorShip { get; }
        string HelpUnsponsorServer { get; }
        string HelpSponsorServer { get; }
        string HelpWarChannel { get; }
        string HelpDownloadAttacks { get; }

        // stats
        string HelpVillageLeagueLeader { get; }
        string HelpVillageLeader { get; }
        string HelpCwlStats { get; }
        string HelpStats { get; }
        string HelpLeagueLeader { get; }
        string HelpClanStats { get; }
        string HelpClanLeagueLeader { get; }
        string HelpBotLeader { get; }
        string HelpLeagueStats { get; }


        // war
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



        // management
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
    }
}