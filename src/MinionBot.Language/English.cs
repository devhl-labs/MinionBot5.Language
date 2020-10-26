using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Net.Http.Headers;

namespace MinionBot.Language
{
    public class English : ILanguage
    {
        public string Name => "English";

        public string Aliases { get; } = "english,en,🇺🇸,🇬🇧";

        public string QuotedParametersAreTypedAsShown
            => "Quoted parameters are typed as shown.";

        public string BracketedParametersAreOptional
            => "Bracketed parameters are optional.";

        public string MustBeRanInGuild
            => "This command must be ran in a server";

        public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
            => "This command is not available for CWL nor competitive league wars.";

        public string MustClaimClan
            => "You must claim a clan first. Try using the `claimclan` command.";

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

        public string VillageNotFound
            => "Village not found";

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
            => "War size must be divisible by 5 and less than 50.";

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
            => "Please include the league would you like to see. Use the scoreboard command to see the list of leagues.";

        public string WarEndWarningsDisabled
            => "The hashits role will no longer receive a mention when war ending soon is announced.";

        public string WarEndWarningsEnabled
            => "The hashits role will now be mentioned when the war ending soon is announced.";

        public string WarStartWarningsDisabled
            => "The hashits role will no longer receive a mention when war ending soon is announced.";

        public string WarStartWarningsEnabled
            => "The hashits role will now be mentioned when the war ending soon is announced.";

        public string IncorrectParametersOrMissingPermission
            => "You provided bad parameters or there is a missing permission.";

        public string CommandNameIsAPlaceHolder
            => "Command name is a place holder. Replace it with the name of a command.";
        public string YouHaveHiddenXAttacks(int count)
            => $"You have hidden {count} attacks.";

        public string CommandNotFound
            => "Command not found.";

        public List<CommandInfo> Commands { get; } = new List<CommandInfo>
        {
            new CommandInfo(3, "setlanguage", "Change the language. Visit [github.com](https://github.com/devhl-labs/MinionBot5.Language) to view the supported languages.", "languageName"),
            new CommandInfo(3, "setprefix", 
@"By default Minion Bot has no prefix. 
Assign one of your choice with this command.
Once assigned, commands will require the prefix to run.
If your prefix is !, the help command will look like!help.
Use deleteprefix to undo this.", "yourPrefix"),
            new CommandInfo(1, "deleteprefix", "This command will delete your prefix."),




            new CommandInfo(2, "print", "View the villages that are called in this war."),
            new CommandInfo(2, "start", 
                "This command is only for clans that keep their war log private. Use it to start a new war in Minion Bot.", 
                "size [enemyName]"),
            new CommandInfo(2, "report", 
                "This command is only for clans that keep their war log private. Use it to report the outcome of an attack.", 
                "defenderPosition stars"),
            new CommandInfo(2, "call", 
                "Call a given enemy base.", 
                "defenderPosition", 
                "defenderPosition #villageTag", 
                "defenderPosition @discordMention", 
                "defenderPosition text"),
            new CommandInfo(2, "delete", 
                "Delete a call on an enemy base. Only providing the defender position will delete your own call on the base, or the first call on that base.", 
                "defenderPosition",
                "defenderPosition callPosition",
                "defenderPosition #attackerTag",
                "defenderPosition @attackerMention"),
            new CommandInfo(2, "nostats", 
                "Attacks will not count toward stats nor leaderboards if you run this. This enables you to have a fun war where the results don't matter. You must be a coleader to run this.", 
                "[true/false]"),



            new CommandInfo(3, "posthits", 
                "Control what channels the attacks get posted to. You must have permission to manage channel to change the channel.", 
                "#channel",
                "[true/false]",
                "number"),
            new CommandInfo(3, "postdonations",
                "Control what channel donations are posted to. You must have permission to manage channel.", 
                "#channel",
                "[true/false]"),
            new CommandInfo(3, "postgreetings", 
                "Control what channel greetings are posted to. You must have permission to manage channel.", 
                "#channel",
                "[true/false]"),
            new CommandInfo(3, "warchannel",
                "This command will rename a channel to reflect the number of stars on an enemy base. You must have permission to manage channel.", 
                "none", 
                "defenderPosition"),
            new CommandInfo(3, "endwarning", 
                "Toggle hasHits mentions for the war end warning. If you do not have the hasHits role this will not do anything.", 
                "[true/false]"),
            new CommandInfo(3, "startwarning",
                "Toggle hasHits mentions for the war start warning. If you do not have the hasHits role this will not do anything.", 
                "[true/false]"),




            new CommandInfo(4, "fetchclan", 
                "Retrieve information on a clan directly from the api.", 
                "[#clanTag]"),
            new CommandInfo(4, "fetchclans", "Search the api for a clan by name.", "text"),
            new CommandInfo(4, "fetchcurrentwar", "Retrive the current war directly from the api.", "[#clanTag]"),
            new CommandInfo(4, "fetchplayer", "Retrive information on a player directly from the api.", "#villageTag"),
            new CommandInfo(4, "fetchleaguegroup", "Retrieve information on a league group directly from the api.", "[#clanTag]"),
            new CommandInfo(4, "fetchleaguewar", "Retrieve information on a SC CWL war directly from the api.", "#warTag"),
            new CommandInfo(4, "fetchclanwarlog", "Retrieve information on a war log directly from the api.", "[#clanTag]"),
            new CommandInfo(4, "api", "View api response times.", "[numOfMinutes]"),






            new CommandInfo(5, "alias", "Give a village a nickname. Keep it short and easy to type.", "#villageTag alias"),
            new CommandInfo(5, "banvillage", "Ban a village from your clan.", "#villageTag reason"),
            new CommandInfo(5, "unbanvillage", "Unban a village from your clan.", "#villageTag"),
            new CommandInfo(5, "calltimer", "Set the amount of time a call is good for.", "numOfHours"),
            new CommandInfo(5, "claim", 
@"Tell the bot who owns a village.
Use a @discordMention to help your clanmates claim their village.
If you're having trouble using the name of the village, try using the village tag.", 
                "villageTag [@discordMention]"),
            new CommandInfo(5, "deletealias", 
@"Use this to delete an old alias.
Especially useful after you change a village name in game.
Aliases should be unique, so you should only have to provide this comand the alias name.", 
                "aliasToDelete", 
                "#villageTag aliasToDelete",
                "#villageTag \"all\""),
            new CommandInfo(5, "getalias", "View all nicknames for a village.",
                "#villageTag",
                "@discordMention",
                "none"),
            new CommandInfo(5, "getbans", "View all bans for your clan or a given village.", "" +
                "#villageTag",
                "none",
                "\"summary\""),
            new CommandInfo(5, "getclaims", "Provides an overview of which villages are claimed.", 
                "#villageTag",
                "none", 
                "@discordMention"),
            new CommandInfo(5, "getunclaimed", "View all villages that are not claimed."),
            new CommandInfo(5, "members", "View all the members who are currently in your clan.", 
                "none", 
                "#villageTag",
                "@discordMention",
                "townhallLevel"),
            new CommandInfo(5, "lookup", "Lookup various information about a village.", "#villageTag"),
            new CommandInfo(5, "mybase", "View information on a given base.", 
                "none",
                "@discordMention",
                "#villageTag"),
            new CommandInfo(5, "prefer", 
@"Minion Bot will try to use the prefered alias over other aliases.
You may only have one prefered alias at a time.
Aliases should be unique, so you only need to provide the alias name.", 
                "aliasToPrefer"),
            new CommandInfo(5, "privatewars",
                "Tell Minion Bot that you will keep your war log closed. This will enable commands intended for private war logs such as start and report.", 
                "[true/false]"),
            new CommandInfo(5, "publicwars",
                "Tell Minion Bot that you will keep your war log open. Your war caller will be managed automatically.", 
                "[true/false]"),
            new CommandInfo(5, "search",
@"Use this to see what villages are in your clan.
Also use it to quickly get your clanmates village tag.
Provide a string to search to narrow the results.", 
                "[text]"),
            new CommandInfo(5, "stackcalls", "When enabled, multiple villages can call an enemy base at the same time.", "[true/false]"),
            new CommandInfo(5, "unclaim", "Unassociate a village from a discord user.", "[#villageTag]"),
            new CommandInfo(5, "sponsorserver", "View the serverss that you are currently sponsoring."),
            new CommandInfo(5, "unsponsorserver", "Stop sponsoring a server. You can get the server ID from `mysponsorships`.", "[serverId]"),
            new CommandInfo(5, "freshemote", 
                "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack or defense.", 
                "attackEmoji defennseEmoji"),
            new CommandInfo(5, "freshattack", 
                "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack.", 
                "attackEmoji"),
            new CommandInfo(5, "freshdefense", "Sponsored servers can use this to control what emoji is displayed for a fresh three star defense.", 
                "defenseEmoji"),
            new CommandInfo(5, "updatemembers", "Update roles and hero levels for all villages in your clan."),
            new CommandInfo(5, "downloadattacks", "Download a file containing your attacks.", 
                "none",
                "warId",
                "#villageTag",
                "@discordMention"),

            new CommandInfo(1, "info", "Get basic information on Minion Bot."),
            new CommandInfo(1, "ping", "Inspect latency with Discord."),
            new CommandInfo(1, "permissions", "Inspect the permissions for a given member.", "[@discordMention]"),
            new CommandInfo(1, "commands", "Get a list of all commands."),
            new CommandInfo(1, "setupvideo", "Provides a link to a setup tutorial."),
            new CommandInfo(1, "fortwitch", "Provides a link to a version of Minion Bot for streamers. This is a program you run on your computer. It will update your overlay for you."),
            new CommandInfo(1, "patreon", "Show your love for Minion Bot! Get a role in the support server and a few added perks."),
            new CommandInfo(1, "invite", "Provides a link to the support server and to invite Minion Bot."),

            new CommandInfo(6, "createorg", "Create an organization.", "orgName"),
            new CommandInfo(6, "change", "Drill down to see more.", "\"org\"", "\"league\"", "\"clan\""),
            new CommandInfo(6, "change org", "Change an organization.", 
                "\"name\" value",
                "\"initials\" value",
                "\"image\" value",
                "\"state\" OffSeason/RegularSeason/Playoffs/Inactive",
                "\"server\" url",
                "\"category\" ulong",
                "\"role\" ulong",
                "\"guild\" ulong"),
            new CommandInfo(6, "change league", "Change a league", 
                "\"state\" OffSeason/RegularSeason/Playoffs/Inactive",
                "\"initials\" value",
                "\"image\" url", 
                "\"season\" value",
                "\"warmatch\" url",
                "\"channel\" ulong",
                "\"org\" ulong",
                "\"autoupdate\" [true/false]"),
            new CommandInfo(6, "change clan", "Change a registrant.",
                "\"main\" #clanTag",
                "\"active\"",
                "\"division\" division"),
            new CommandInfo(6, "createleague", "Create a league.", "none"),
            new CommandInfo(6, "inspect", "View information about an object.", 
                "\"org\" [org]",
                "\"league\" [league]",
                "registrant"),
            new CommandInfo(6, "requestleague", 
@"If the current war is a league war, run this command to request to mark it as a league war.
Your request will be sent to the support server.
A league rep will need to approve it.", 
                "leagueInitials"),
            new CommandInfo(6, "getorgbans", "View all bans for an organization.", "leagueInitials", "orgInitials", "none"),
            new CommandInfo(6, "leaguerep", "View all league reps or assign league rep to a member.", "none", "@discordMention", "orgInitials"),



            new CommandInfo(7, "getremainingattacks", 
                "This will show who has attacks left for your clan. If the village has a call, it will show that as well.", 
                "none",
                "#villageTag",
                "@discordMention"),
            new CommandInfo(7, "getlastattacks", "View the last attacks.", 
                "none", 
                "#villageTag \"cwl\"",
                "#villageTag [league] [season]",
                "@discordMention \"cwl\"," +
                "#discordMention [league] [season]"),
            new CommandInfo(7, "getlastdefenses", "View the last defenses.",
                "none",
                "#villageTag",
                "#villageTag \"cwl\"",
                "#villageTag league [season]",
                "@discordMention",
                "@discordMention \"cwl\"",
                "#discordMention league [season]"),
            new CommandInfo(7, "leaguestats", "Show the stats for this week's league wars.", "league"),
            new CommandInfo(7, "divisions", "View the divisions in a given league.", "league"),
            new CommandInfo(7, "scoreboard", "View the scoreboard for a league.", 
                "none",
                "org",
                "league [season] [division] [#clanTag]"),
            new CommandInfo(7, "getwars", "Get a list of all known wars for a clan.", "none", "#clanTag", "league"),
            new CommandInfo(7, "matchup", "View a side by side comparison of the current war."),
            new CommandInfo(7, "attack", "Get a summary of attacks remaining."),
            new CommandInfo(7, "defenses", "Get a summary of defenses remaining."),
            new CommandInfo(7, "announcewar", "Print the war found announcement.", 
                "none", 
                "warId"),
            new CommandInfo(7, "claimattacks", 
@"This will claim all previously unclaimed attacks.
This includes attacks and defenses done before you claimed the village.
**This cannot be undone.**",
                "#villageTag"),
            new CommandInfo(7, "hideattacks", 
@"This will hide any attack that you have claimed. You must be a master patron to use this command. Your attacks are claimed by having the village claimed while the attack occurs or throught the claimattacks command.",
                "none",
                "#villageTag",
                "olderThanXMonthsAgo"),
            new CommandInfo(7, "roster", "View a summary of the villages in a given war.", 
                "none",
                "warId"),
            new CommandInfo(7, "lineup", "View detailed information on each village in the current war.", 
                "none",
                "\"enemy\""),



            new CommandInfo(8, "botleader",
@"Get the best attackers or defenders in the entire bot.
This will get the best hit rates for all villages, regardless of clan.
War Type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.",
                "attackerTH defenderTH [numOfMonths] [warType] [\"defense\"] [freshType]"),
            new CommandInfo(8, "clanleagueleader",
@"This will show which clan has the best hit rate in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.",
                "attackerTH defenderTH league [season] [\"defense\"] [freshType]"),
            new CommandInfo(8, "clanstats",
@"Get stats from a clans entire attack history.
This will look like the stats for a village, but it will show the entire clan.
This allows you to enter other clan's tag to compare clans.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.",
                "[clantag] [warType] [freshType]",
                "[clantag] league [season] [freshType]",
                "[clantag] numberOfMonths",
                "none"
                ),
            new CommandInfo(8, "leagueleader",
@"This will show the league with the best hit rate.
Fresh type can be fresh or cleanup.",
                "attackerTH defenderTH [\"defense\"] [freshType]"),
            new CommandInfo(8, "stats",
@"View the stats for the current war, a village, or a discord user.
Number of months will limit the attacks to the last X months.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.
The clan parameter will exclude attacks your clanmates have done while in other clans.
War IDs can be found using the getwars command.",
                "#villageTag [numberOfMonths] [warType] [freshType] [\"clan\"]",
                "#villageTag [numberOfMonths] league [season] [freshType]",
                "@discordMention [numberOfMonths] [warType] [freshType] [\"clan\"]",
                "@discordMention [numberOfMonths] league [season] [freshType]",
                "none",
                "warId"),
            new CommandInfo(8, "villageleader",
@"This will show where you rank among your clan.
Number of months will limit the attacks to the last X months.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.
The clan parameter will exclude attacks your clanmates have done while in other clans.",
                "attackerTH defenderTH [numberOfMonths] [league] [season] [\"defense\"] [freshType]",
                "attackerTH defenderTH [numberOfMonths] [warType] [\"defense\"] [freshType] [\"clan\"]"),
            new CommandInfo(8, "villageleagueleader",
@"This will show the best attackers and defenders in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.",
                "attackerTH defenderTH league [season] [\"defense\"] [freshType]"),




            new CommandInfo(9, "claimclan", 
@"Run this command for each clan you want to claim in a different channel.
You must put the letters 'mb' after the clan description for this to work.", 
                "#clanTag"),
            new CommandInfo(9, "unclaimclan",
@"You may remove a clan from your server.
To add it back, you will need to add 'mb' to the description again.", 
                "none",
                "#clanTag",
                "\"all\" #clanTag"),
            new CommandInfo(9, "defaultclan",
@"Allows you to tell Minion Bot which clan to use in channels where claimclan has never been ran.
You may run this after running claimclan.
The first clan you claim in a server is automatcally the default clan.", 
                "none",
                "#clanTag"),
            new CommandInfo(9, "myclan", "Use this command to see what clan tag Minion Bot is using in a given channel."),
            new CommandInfo(9, "myclans", "View all the clans your server has claimed."),
            new CommandInfo(9, "myserver", "Get information about your server."),
            new CommandInfo(9, "mychannel", "Get information on your channel's settings."),
            new CommandInfo(9, "mychannels", "Get information on all of your channel settings.", ""),
            new CommandInfo(9, "deleteroles", "This will delete all of the roles that were created by this bot."),
            new CommandInfo(9, "addroles",
@"This will create predefined roles in this server.
These roles will be assigned automatically.
You can rename or delete the roles created by this command.", 
                "none",
                "true/false",
                "\"guild\" minTownHall maxTownHall",
                "minTownHall maxTownHall"),
            new CommandInfo(9, "restrict", 
"This will make Minion Bot ignore commands in a channel. It is recommended that you use discord permissions instead of this command.", 
                "[true/false]"),





            new CommandInfo(10, "addclan", "Add clans to a league.", "list of #clanTags"),
            new CommandInfo(10, "removeclan", "Remove a clan from a league.", "#clanTag"),
            new CommandInfo(10, "shell", "Add a registrant clan under a participant.", "#shellTag #parentTag"),
            new CommandInfo(10, "unshell", "Move a registrant to their own participant.", "#shellTag"),
            new CommandInfo(10, "autoupdate", "This command was retired. Use `change league state` or `import` instead."),
            new CommandInfo(10, "import", "Import clan tags from a war match url.", "warMatchUrl", "warMatchId"),
            new CommandInfo(10, "addwar", "Add a war to the league. If specifying clan tags you may want to update stars and percent next.", 
                "warId",
                "#losingClan #winningClan [prepStartDate]"),
            new CommandInfo(10, "removewar", "Remove a war from a league.", "warId"),
            new CommandInfo(10, "orgban", 
"Ban villages from an organization. You will be notified if the village joins a registered clan or a war with a registered clan.", 
                "(list of #villageTags)", 
                "numOfDays (list of #villageTags)", 
                "mayJoinClans mayBeInRandomWars [numOfDays] (list of #villageTags)"),
            new CommandInfo(10, "orgunban",
"Delete bans on villages from your organization.",
                "(list of #villageTags)"),
            new CommandInfo(10, "changewinner", 
"Change the winner of a league war. This will only be seen in the scoreboard, not the league stats.", 
                "warId win/lose/tie #clanTag"),
            new CommandInfo(10, "changestars", 
"Change the stars of a league war. This will only be seen in the scoreboard, not the league stats.",
                "warId stars #clanTag"),
            new CommandInfo(10, "changepercent", 
"Change the percent for a league war. This will only be seen in the scoreboard, not the league stats.", 
                "warId percent #clanTag"),
            new CommandInfo(10, "leaguewinner", "Declare the league winner.", "#clanTag"),
            new CommandInfo(10, "showprivatewars", "View all clans in this league which war log is private."),
 
        };
    }
}
