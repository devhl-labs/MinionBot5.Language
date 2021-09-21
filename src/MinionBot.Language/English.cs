using System.Collections.Generic;

namespace MinionBot.Language
{
    public class English : AbstractLanguage, ILanguage
    {
        public string Name => "en-US";

        public string Aliases { get; } = "en-US,en,us,english,🇺🇸,🇬🇧";

        public string ThisLeagueIsInactive
            => "This league is inactive or in offseason. If that is not correct, please join the support server and ping your league representatives.";
        public string AllRolesCanBeManaged
            => "All roles can be managed.";

        public string SomeRolesCantBeManaged
            => "Some roles can't be managed.";

        public string ATimeoutOccured
            => "A timeout occurred. Please try again.";

        public string ThisCommandIsNotForBots
            => "This command does not support bots.";

        public string QuotedParametersAreTypedAsShown
            => "Quoted parameters are typed as shown.";

        public string BracketedParametersAreOptional
            => "Bracketed parameters are optional.";

        public string MustBeRanInGuild
            => "This command must be ran in a server";

        public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
            => "This command is not available for CWL nor competitive league wars.";

        public string MustClaimClan
            => "You must claim a clan first. Try using the `claimclan #clanTag` command.";

        public string NoStatsEnabled
            => "Stats will no longer count. Attacks in this war will not be eligible for commands like botleader, villageleader, etc.";

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

        public string VillageNotFound()
            => "Village not found.";

        public string VillageNotFound(string tag, string clanName, string input)
            => $"No village was found in {tag} {clanName} with a tag or name of {input}.";

        public string YourClanCouldNotBeDetermined
            => "Your clan could not be determined.";  

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
            => "War size must be divisible by 5 and less than or equal to 50.";

        public string DefenderPositionMustBeBetween1And50
            => "Defender position must be between 1 and 50";

        public string StarsMustBeBetween1And3
            => "Stars must be between -1 and 3.";

        public string ThereIsAlreadyACallOnThisBase
            => "There is already a call on this base, and stacking calls is disabled.";

        public string ClanIsNotInWar(string clanTag, string clanName)
            => $"{clanTag} {clanName} is not in war.";

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
            => $"Only members of {clanTag} {clanName} can see this.";

        public string ThisWarIsAlreadyInALeague
            => "This war is already in a league.";

        public string YourRequestIsPendingApproval
            => "Your request is pending approval.";

        public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
            => $"No participating clan with name {dbParticipantName} where found in {leagueInitials} season {season}.";

        public string NoParticipants(string leagueInitials, int season)
            => $"There are no clans in {leagueInitials} season {season}.";

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
            => $"Created {count} roles.";

        public string CreatedXRoles(string clanTag, string clanName, int count)
            => $"Created {count} roles for {clanTag} {clanName}.";

        public string CreatedXRoles(int count, int errors)
            => $"Created {count} roles. {errors} roles could not be created due to server limits or rate limits.";

        public string ThisVillageHasNoBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} is not banned from any clan.";
        public string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName)
            => $"{villageTag} {villageName} is no longer banned in {clanTag} {clanName}.";

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
            => "I don't know that language. If you would like to add it, please visit https://github.com/devhl-labs/MinionBot5.Language.";

        public string PrefixRules
            => "A prefix is five or less characters and may not contain # @ or a space.";

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
            => $"Fresh 3 stars will now display {attack} for attacks and {defend} for defenses for {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
            => $"Fresh 3 star attacks will now display {emoji} for {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
            => $"Fresh 3 star defenses will now display {emoji} for {clanTag} {clanName}";

        public string CommandMustBeRanInACategory 
            => "This command must be ran in a category.";

        public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
            => $"This command will begin renaming all text channels in this category for {clanTag} {clanName}.  Continue?";

        public string ChannelsWillBeRenamed
            => "Text channels in this category will be renamed on new wars or new attacks. Ensure I have manage channel permission in each channel.";

        public string CommandCanceled => "Command canceled";

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
            => "This command requires this server be sponsored. If you are a patron, run the sponsorserver command first. You and I must have manage channels permission on the guild or the channel, depending on what paramters you provided.";

        public string BecomeAPatronToDownloadThis
            => "Become a patron to get this in a downloadable file! If you are a patron, ensure I have permission to attach files in this channel.";

        public string BecomeAPatronToUseThisCommand
            => "Consider becoming a patron to use this command!";

        public string IncludeTheLeagueYouWouldLikeToSee
            => "Please include the league you would like to see. Use the scoreboard command to see the list of leagues.";

        public string WarEndWarningsDisabled
            => "The hashits role will no longer receive a mention when war ending soon is announced.";

        public string WarEndWarningsEnabled
            => "The hashits role will now be mentioned when the war ending soon is announced.";

        public string WarStartWarningsDisabled
            => "The hashits role will no longer receive a mention when war starting soon is announced.";

        public string WarStartWarningsEnabled
            => "The hashits role will now be mentioned when the war starting soon is announced.";

        public string IncorrectParametersOrMissingPermission
            => "You provided bad parameters or there is a missing permission.";

        public string CommandNameIsAPlaceHolder
            => "Command name is a place holder. Replace it with the name of a command.";
        public string YouHaveHiddenXAttacks(int count)
            => $"You have hidden {count} attacks.";

        public string YouHaveUnhiddenXAttacks(int count)
            => $"You have unhidden {count} attacks.";

        public string CommandNotFound
            => "Command not found.";




        // management
        public string HelpClaimClan => 
@"Run this command for each clan you want to claim in a different channel.
You must put the letters 'mb' after the clan description for this to work.";

        public string HelpUnclaimClan => 
@"You may remove a clan from your server.
To add it back, you will need to add 'mb' to the description again.";

        public string HelpDefaultClan => 
@"Allows you to tell Minion Bot which clan to use in channels where claimclan has never been ran.
You may run this after running claimclan.
The first clan you claim in a server is automatcally the default clan.";

        public string HelpMyClans => "View all the clans your server has claimed.";

        public string HelpMyServer => "Get information about your server.";

        public string HelpMyClan => "Use this command to see what clan tag Minion Bot is using in a given channel.";

        public string HelpMyRoles => "Get the roles that are managed by this bot.";

        public string HelpMyChannel => "Get information on your channel's settings.";

        public string HelpMyChannels => "Get information on all of your channel settings.";

        public string HelpDeleteRoles => "This will delete all of the roles that were created by this bot.";

        public string HelpAddRoles => 
@"This will create predefined roles in this server.
These roles will be assigned automatically.
You can rename or delete the roles created by this command.";

        public string HelpRestrict => "This will make Minion Bot ignore commands in a channel. It is recommended that you use discord permissions instead of this command.";

        public string HelpPostHits => "Control what channels the attacks get posted to. You must have permission to manage channel to change the channel.";

        public string HelpPostDonations => "Control what channel donations are posted to. You must have permission to manage channel.";

        public string HelpPostGreetings => "Control what channel greetings are posted to. You must have permission to manage channel.";

        public string HelpEndWarning => "Toggle hasHits mentions for the war end warning. If you do not have the hasHits role this will not do anything.";

        public string HelpStartWarning => "Toggle hasHits mentions for the war start warning. If you do not have the hasHits role this will not do anything.";

        public string HelpSetLanguage => "Change the language. Visit [github.com](https://github.com/devhl-labs/MinionBot5.Language) to view the supported languages.";

        public string HelpSetPrefix => 
@"By default Minion Bot has no prefix. 
Assign one of your choice with this command.
Once assigned, commands will require the prefix to run.
If your prefix is !, the help command will look like !help.
Use deleteprefix to undo this.";

        public string HelpDeletePrefix => "This command will delete your prefix.";

        public string HelpAlias => "Give a village a nickname. Keep it short and easy to type.";

        public string HelpBanVillage => "Ban a village from your clan.";

        public string HelpUnBanVillage => "Unban a village from your clan.";

        public string HelpClaim => 
@"Tell the bot who owns a village.
Use a @discordMention to help your clanmates claim their village.
If you're having trouble using the name of the village, try using the village tag.";

        public string HelpDeleteAlias =>
@"Use this to delete an old alias.
Especially useful after you change a village name in game.
Aliases should be unique, so you should only have to provide this command the alias name.";

        public string HelpGetAlias => "View all nicknames for a village.";

        public string HelpGetBans => "View all bans for your clan or a given village.";

        public string HelpGetClaims => "Provides an overview of which villages are claimed.";

        public string HelpGetUnclaimed => "View all villages that are not claimed.";

        public string HelpMembers => "View all the members who are currently in your clan.";

        public string HelpLookup => "Lookup various information about a village.";

        public string HelpMyBase => "View information on a given base.";

        public string HelpPrefer =>
@"Minion Bot will try to use the prefered alias over other aliases.
You may only have one prefered alias at a time.
Aliases should be unique, so you only need to provide the alias name.";

        public string HelpSearch => 
@"Use this to see what villages are in your clan.
Also use it to quickly get your clanmates village tag.
Provide a string to search to narrow the results.";

        public string HelpUnclaim => "Unassociate a village from a discord user.";

        public string HelpUpdateMembers => "Update roles and hero levels for all villages in your clan.";

        public string HelpClaimAttacks => 
@"This will claim all previously unclaimed attacks.
This includes attacks and defenses done before you claimed the village.
**This cannot be undone.**";
        public string HelpSuperTroops => "See what villages have super troops unlocked.";


        //war
        public string HelpCallTimer => "Set the amount of time a call is good for.";
        public string HelpStackCalls => "When enabled, multiple villages can call an enemy base at the same time.";
        public string HelpPrivateWars =>
"Tell Minion Bot that you will keep your war log closed. This will enable commands intended for private war logs such as start and report.";
        public string HelpPublicWars => "Tell Minion Bot that you will keep your war log open. Your war caller will be managed automatically.";
        public string HelpPrint => "View the villages that are called in this war.";
        public string HelpStart => "This command is only for clans that keep their war log private. Use it to start a new war in Minion Bot.";
        public string HelpReport => "This command is only for clans that keep their war log private. Use it to report the outcome of an attack.";
        public string HelpCall => "Call a given enemy base.";
        public string HelpDelete =>
"Delete a call on an enemy base. Only providing the defender position will delete your own call on the base, or the first call on that base.";
        public string HelpNoStats => 
"Attacks will not count toward stats nor leaderboards if you run this. This enables you to have a fun war where the results don't matter. You must be a coleader to run this.";
        public string HelpGetRemainingAttacks =>
"This will show who has attacks left for your clan. If the village has a call, it will show that as well.";
        public string HelpGetLastAttacks => "View the last attacks.";
        public string HelpGetLastDefenses => "View the last defenses.";
        public string HelpGetWars => "Get a list of all known wars for a clan.";
        public string HelpMatchup => "View a side by side comparison of the current war.";
        public string HelpDefenses => "Get a summary of defenses remaining.";
        public string HelpAnnounceWar => "Print the war found announcement.";
        public string HelpAttacks => "Show the number of attacks left for each side of the war map.";
        public string HelpRoster => "View a summary of the villages in a given war.";
        public string HelpLineup => "View detailed information on each village in the current war.";


        //stats
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


        //patreon
        public string HelpDownloadAttacks => "Download a file containing your attacks.";
        public string HelpWarChannel =>
"This command will rename a channel to reflect the number of stars on an enemy base. You must have permission to manage channel.";
        public string HelpSponsorServer => "Sponsor the current server.";
        public string HelpUnsponsorServer => "Stop sponsoring a server. You can get the server ID from `mysponsorships`.";
        public string HelpMySponsorShip => "View all of the servers you are sponsoring.";
        public string HelpFreshEmote => "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack or defense.";
        public string HelpFreshAttack => "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack.";
        public string HelpFreshDefense => "Sponsored servers can use this to control what emoji is displayed for a fresh three star defense.";
        public string HelpHideAttacks =>
@"This will hide any attack that you have claimed. You must be a master patron to use this command. Your attacks are claimed by having the village claimed while the attack occurs or throught the claimattacks command.";
        public string HelpPatreon => "Show your love for Minion Bot! Get a role in the support server and a few added perks.";


        //league
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


        //debugging
        public string HelpPing => "Inspect latency with Discord.";
        public string HelpPermissions => "Retrieve information on a clan directly from the api.";
        public string HelpFetchClan => "Retrieve information on a clan directly from the api.";
        public string HelpFetchClans => "Search the api for a clan by name.";
        public string HelpFetchCurrentWar => "Retrive the current war directly from the api.";
        public string HelpFetchPlayer => "Retrive information on a player directly from the api.";
        public string HelpFetchLeagueGroup => "Retrieve information on a league group directly from the api.";
        public string HelpFetchLeagueWar => "Retrieve information on a SC CWL war directly from the api.";
        public string HelpFetchClanWarLog => "Retrieve information on a war log directly from the api.";
        public string HelpApi => "View api response times.";


        //about
        public string HelpInfo => "Get basic information on Minion Bot.";
        public string HelpCommands => "Get a list of all commands.";
        public string HelpSetupVideo => "Provides a link to a setup tutorial.";
        public string HelpForTwitch =>
"Provides a link to a version of Minion Bot for streamers. This is a program you run on your computer. It will update your overlay for you.";
        public string HelpInvite => "Provides a link to the support server and to invite Minion Bot.";

    }
}
