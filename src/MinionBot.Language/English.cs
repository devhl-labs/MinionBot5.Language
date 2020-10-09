using System.Data.Common;

namespace MinionBot.Language
{
    public class English : ILanguage
    {
        public string Name => "English";

        public string MustBeRanInGuild
            => "This command must be ran in a server";

        public string ThisCommandIsNotAvailableForCwlNorCompetetiveWars
            => "This command is not available for CWL nor competetive league wars.";

        public string MustClaimClan
            => "You must claim a clan first. Try using the `claimclan` command.";

        public string NoStatsEnabled
            => "Stats will no longer count. Attacks in this war will not be eligible for leader boards.";

        public string NoStatsDisabled
            => "Stats will now count. Attacks in this war will be eligible for leader boards.";

        public string NewClanDefault(string clanTag, string clanName)
            => $"{clanTag} {clanName} is now the default clan for this server.";

        public string ClanNotClaimed(string clanTag, string clanName)
            => $"{clanTag} {clanName} is not claimed in this server. Start with `claimclan {clanTag}`.";

        public string ClanNotClaimed()
            => $"This server does not have any of these clans claimed.";

        public string NoClansToUnclaim
            => "There are no clans to unclaim.";

        public string ClanUnclaimed(string clanTag, string clanName)
            => $"You have unclaimed {clanTag} {clanName}.";

        public string ClanUnclaimedFromAllServers(string clanTag, string clanName)
            => $"You have unclaimed {clanTag} {clanName} from all servers.";

        public string RegistrantCantBeRemoved(string clanTag, string clanName)
            => $"{clanTag} {clanName} cannot be removed. Ensure all wars are removed first then try again.";

        public string ClaimClan
            => "Add the letters mb to the end of the clan description.\nWait a few minutes, then run claimclan #clanTag.\nmb is only needed for security and can be removed after claiming.";

        public string ThisVillageIsClaimed
            => "This village is claimed.  Ask a coleader to unclaim it for you.";

        public string NoVillagesClaimed
            => "You have no villages claimed. Use `claim #villageTag` to claim your village.";

        public string YouAlreadyHaveThisVillageClaimed
            => "You already have this village claimed.";

        public string YouHaveClaimed(string villageTag, string villageName)
            => $"You have claimed {villageTag} {villageName}";

        public string AlreadyHasThisVillageClaimed(string userName)
            => $"{userName} already has this village claimed.";

        public string InvalidTag => "Invalid Tag";

        public string YouDontHaveAnyVillagesClaimed
            => "You don't have any villages claimed.";

        public string VillageNotFound
            => "Village not found";

        public string YourClanCouldNotBeDetermined
            => "Your clan could not be determined.";  //todo looks like AnErrorOccuredLocatingYourClan

        public string YouMustBeACoLeaderToUnclaimAVillage
            => "You must be a coleader or have manage channels permission to unclaim a village.";

        public string ThisVillageIsNotClaimedYet
            => "This village is not claimed yet.";

        public string ThisAliasIsInUse(string clanTag, string clanName)
            => $"This alias is already in use in {clanTag} {clanName}.";

        public string YourAliasIsNow(string villageTag, string villageName, string alias)
            => $"{villageTag} {villageName} now has `{alias}` as an alias. Use `prefer {alias}` to make this the prefered alias.";

        public string AliasNotFound(string alias, string villageTag, string villageName)
            => $"Alias `{alias}` not found for {villageTag} {villageName}.";

        public string IsNowThePreferredAlias(string alias, string villageTag, string villageName)
            => $"{alias} is now the preferred alias for {villageTag} {villageName}.";

        public string AliasesMayNotContainSomeCharacters
            => "An alias may not contain @ or # symbols.";

        public string ThereAreNoResults
            => "There are no results.";

        public string CallTimerMustBeBetween
            => "Call timer must be between 0 and 24 hours.";

        public string WarSizeMustBeDivisibleBy5AndLessThan50
            => "War size must be divisible by 5 and less than 50.";

        public string DefenderPositionMustBeBetween1And50
            => "Defender position must be between 1 and 50";

        public string StarsMustBeBetween1And3
            => "Stars must be between -1 and 3.";

        public string ThereIsAlreadyACallOnThisBase
            => "There is already a call on this base, and stacking calls is disabled.";

        public string ClanIsNotInWar(string clanTag, string clanName)
            => $"{clanTag} {clanName} is not in war.";

        public string AnErrorOccuredLocatingYourClan
            => "An error occured locating your clan.";

        public string ThisCommandMustBeRanInAServer
            => "This command must be ran in a server.";

        public string WarLogIsPrivate(string clanTag, string clanName)
            => $"The war log for {clanTag} {clanName} is private.";

        public string AnErrorOccuredLocatingYourWar(string clanTag, string clanName)
            => $"An error occured while locating the war for {clanTag} {clanName}.";

        public string MustUsePrivateWars
            => "Due to an issue with the API, during CWL, you must use `privatewars` command.";

        public string StartANewWar
            => "Use the `start` command to begin a new war.";

        public string CallStackingIsDisabled
            => "There is already a call on this base, and call stacking is disabled for this clan.";

        public string ThisCommandIsOnlyForPrivateWars
            => "This command is only for private wars.";

        public string ThisChannelAlreadyHasAClanClaimed
            => "This channel already has a clan claimed. You can run `claimclan` in a different channel, or run `unclaimclan` here.";

        public string VillageIsNotInWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} is not in this war.";

        public string VillageIsOutOfAttacks(string villageTag, string villageName)
            => $"{villageTag} {villageName} is out of attacks.";

        public string VillageIsNotInAnActiveWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} is not in an active war.";

        public string ThisCommandIsDisabledDuringCWL
            => "This command is disabled during CWL.";

        public string YouAreNotInAnyActiveWarWar()
            => "You are not in any active war.";

        public string YouAreOutOfAttacks()
            => "You are out of attacks.";

        public string YouAreNotInAnyActiveWarWar(string userName)
            => $"{userName} is not in any active war.";

        public string YouAreOutOfAttacks(string cachedMemberDisplayName)
            => $"{cachedMemberDisplayName} is out of attacks.";

        public string NoAttacksFound
            => "No attacks found.";

        public string ThisChannelMustBeInACategory
            => "This channel must be in a category.";

        public string OrgNotFound
            => "Organization not found.";

        public string LeagueNotFound
            => "League not found.";

        public string NoLeagueWarsFoundInLastSixDays(string leagueInitials) =>
            $"This league has no wars in the last six days. If this is not right you can tag your league rep in the support server. If your war is a league war, use the `requestLeague {leagueInitials}` command.";

        public string SeeAWarThatIsMissing(string leagueInitials) =>
            $"```See a war that is missing ?\n\nIf it's your war, use the command requestleague {leagueInitials}.\n\nOtherwise, you can join the support server and tag your league's rep.\n\nWant to help update this league?\n\nJoin the support server to get the role.```";

        public string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName)
            => $"Only members of {clanTag} {clanName} this clan can see this.";

        public string ThisWarIsAlreadyInALeague
            => "This war is already in a league.";

        public string YourRequestIsPendingApproval
            => "Your request is pending approval.";

        public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
            => $"No participating clan with name {dbParticipantName} where found in {leagueInitials} season {season}.";

        public string ThisLeagueHasNoDivisions
            => "This league has no divisions.";

        public string YouHaveClaimedXAttacks(int count, string tag, string name)
            => $"You have claimed {count} attacks for {tag} {name}.";

        public string YouAndThisBotMustHavePermissionToManageRoles
            => "You and this bot must have permission to manage roles to run this command.";

        public string RolesWillNoLongerBeUpdated
            => "Roles will no longer be updated.";

        public string RolesWillBeUpdated(int roles)
            => $"{roles} roles will be given automatically.";

        public string DeletedXRoles(int count)
            => $"Deleted {count} roles.";

        public string CreatedXRoles(int count)
            => $"Created {count} roles. To create clan specific roles, run this command again with the clan tag.";

        public string CreatedXRoles(string clanTag, string clanName, int count)
            => $"Created {count} roles for {clanTag} {clanName}.";

        public string CreatedXRoles(int count, int errors)
            => $"Created {count} roles. {errors} roles could not be created due to server limits or rate limits.";

        public string ThisVillageHasNoBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} is not banned from any clan.";
        public string ThisVillageHasNoBans(string villageTag, string villageName, string clanTag, string clanName)
            => $"Any ban on {villageTag} {villageName} for clan {clanTag} {clanName} has been removed.";

        public string ThisClanHasNoBans(string clanTag, string clanName)
            => $"{clanTag} {clanName} has no bans.";

        public string ThisOrgHasNoBans
            => "This organization has no bans.";

        public string ThisVillageHasNoOrgBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} has no org bans.";

        public string PleaseTryAgainAndProvideAReasonForTheBan
            => "Please try again and provide a reason for the ban.";

        public string ClanDescriptionMustEndWithMB
            => "To claim your clan, the description must end with `mb`. This is only for security and may be removed later.";

        public string YourLanguageHasBeenChangedTo(string language)
            => $"Your language has been changed to {language}.";

        public string IDontKnowThatLanguage
            => "I don't know that language.";

        public string PrefixRules
            => "A prefix is five or less characters and my not contain # @ or a space.";

        public string PrefixDefinition
            => "A prefix is a character that goes in front of commands like !, $, *, etc. It lets me know that you're talking to me. To set a prefix, use `setprefix !`. The ! can be other characters, too.";

        public string UseDeletePrefixToUndoThis(string userMention, string prefix)
            => $"{userMention} You have created a prefix. All commands must now start with `{prefix}`. Use `deleteprefix` to undo this.";

        public string YouMustHavePermissionToManageGuild
            => "You must have permission to manage guild.";

        public string ThisChannelHasNoClanClaimed
            => "This channel has no clan claimed.";

        public string InvalidTownHallLevel
            => "You provided an invalid townhall level.";

        public string MustBeAGoldPatron
            => "You must be a gold patron or higher.";

        public string MustBeACrystalPatron
            => "You must be a crystal patron or higher.";

        public string MustBeAMasterPatron
            => "You must be a master patron or higher.";

        public string AlreadySponsored
            => "You are already sponsoring this server.";

        public string SponsoringServer(ulong id, string name)
            => $"You are sponsoring {id} {name}.";

        public string NotSponsoringAnyServers
            => "You are not sponsoring any servers.";

        public string ServerMustBeSponsored
            => "This server must be sponsored to do this. If you are a patron, use the command `sponsorserver`.";

        public string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName)
            => $"Fresh 3 stars will now display {attack} for attacks and {defend} for defense for {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
            => $"Fresh 3 star attacks will now display {emoji} for {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
            => $"Fresh 3 star defenses will now display {emoji} for {clanTag} {clanName}";

        public string CommandMustBeRanInACategory { get; } = "This command must be ran in a category.";

        public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
            => $"This command will begin renaming all text channels in this category for {clanTag} {clanName}.  Continue?";

        public string ChannelsWillBeRenamed { get; }
            = "Text channels in this category will be renamed on new wars or new attacks. Ensure I have manage channel permission in each channel.";

        public string CommandCanceled { get; } = "Command canceled";

        public string NowRenamingChannel(string clanTag, string clanName, int position)
            => $"Now renaming this channel for {clanTag} {clanName}, enemy position {position}.";

        public string NeedPermissionToManageChannels
            => "I don't have permission to manage channels.";

        public string NoAttacksLeft(string enemyClanTag, string enemyClanName)
            => $"There are no attacks left in the war against {enemyClanTag} {enemyClanName}.";

        public string UpdatedVillages(string clanTag, string clanName, int villageCount)
            => $"Updated {villageCount} villages in {clanTag} {clanName}.";

        public string Restrict
            => "Now ignoring all commands from this channel. Use `restrict false` to undo this. It is strongly recommended that you modify roles instead of using this command.";

        public string NotRestricted
            => "No longer ignoring this channel.";

        public string WarChannelFailed
            => "This command requires this server be sponsored and you and I must have the manage channels permission. If you are a patron, run the sponsorserver command first.";

        public string BecomeAPatronToDownloadThis
            => "Become a patron to get this in a downloadable file! If you are a patron, ensure I have permission to attach files in this channel.";
    }
}
