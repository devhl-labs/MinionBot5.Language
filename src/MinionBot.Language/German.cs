/*
* Translation provided by Mundelino
*/

using System.Collections.Generic;

namespace MinionBot.Language
{
    public class German : ILanguage
    {
        public string Name => "ge-GE";

        public string Aliases { get; } = "ge-GE,ge,german,:flag_de:";

        public string ThisLeagueIsInactive
            => "This league is inactive or in offseason. If that is not correct, please join the support server and ping your league representatives.";

        public string AllRolesCanBeManaged
            => "All roles can be managed.";

        public string SomeRolesCantBeManaged
            => "Some roles can't be managed.";

        public string ATimeoutOccured
            => "A timeout occurred. Please try again.";

        public string ThisCommandIsNotForBots
            => "Dieser Befehl unterstützt keine Bots.";

        public string QuotedParametersAreTypedAsShown
            => "Die angegebenen Parameter werden wie im Beispiel eingegeben.";

        public string BracketedParametersAreOptional
            => "Die Parameter in Klammern sind optional.";

        public string MustBeRanInGuild
            => "Dieser Befehl muss in einem Server ausgeführt werden.";

        public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
            => "Dieser Befehl ist weder für CWL noch für Turnierkriege.";

        public string MustClaimClan
            => "Du musst zuerst einen Clan festlegen. Benutze dafür den Befehl `claimclan`.";

        public string NoStatsEnabled
            => "Statistiken zählen nicht länger. Angriff in diesem Krieg sind nicht mehr für Befehle wie botleader, villageleader, etc. verfügbar.";

        public string NoStatsDisabled
            => "Statistiken zählen ab jetzt. Angriffe in diesem Krieg werden in den Ranglisten berücksichtigt.";

        public string NewClanDefault(string clanTag, string clanName)
            => $"{clanTag} {clanName} ist nun der standard Clan für diesen Server.";

        public string ClanNotClaimed(string clanTag, string clanName)
            => $"{clanTag} {clanName} wurde nicht in diesem Server festgelegt. Starte mit `claimclan {clanTag}`.";

        public string ClanNotClaimed()
            => $"Auf diesem Server wurde keiner dieser Clans festgelegt.";

        public string NoClansToUnclaim
            => "Es ist kein Clan für diesen Befehl vorhanden.";

        public string ClanUnclaimed(string clanTag, string clanName)
            => $"Du hast {clanTag} {clanName} erfolgreich gelöst.";

        public string ClanUnclaimedFromAllServers(string clanTag, string clanName)
            => $"Du hast {clanTag} {clanName} erfolgreich von allen Servern gelöst.";

        public string RegistrantCantBeRemoved(string clanTag, string clanName)
            => $"{clanTag} {clanName} kann nicht entfernt werden. Versichere dich, dass alle Kriege entfernt wurden und versuche es erneut.";

        public string ClaimClan
            => "Füge die Buchstaben mb am Ende der Clanbeschreibung hinzu.\nFühre nach ein paar Minuten den Befehl `claimclan #clanTag` aus.\nmb ist nur zur Sicherheit vorhanden und kann nach dem festlegen des Clans entfernt werden.";

        public string ThisVillageIsClaimed
            => "Dieses Dorf ist bereits festgelegt worden. Wende dich an einen Co-Anführer um das Dorf frei zu geben.";

        public string NoVillagesClaimed
            => "Du hast keine Dörfer festgelegt. Benutze den Befehl `claim #villageTag` um dein Dorf festzulegen.";

        public string YouAlreadyHaveThisVillageClaimed
            => "Du hast dieses Dorf bereits festgelegt.";

        public string YouHaveClaimed(string villageTag, string villageName)
            => $"Du hast {villageTag} {villageName} erfolgreich festgelegt";

        public string AlreadyHasThisVillageClaimed(string userName)
            => $"{userName} hat dieses Dorf bereits festgelegt.";

        public string InvalidTag
            => "Ungültiger Kürzel";

        public string YouDontHaveAnyVillagesClaimed
            => "Du hast keine Dörfer festgelegt.";

        public string VillageNotFound()
            => "Das Dorf wurde nicht gefunden.";

        public string VillageNotFound(string tag, string clanName, string input)
            => $"No village was found in {tag} {clanName} with a tag or name of {input}.";

        public string YourClanCouldNotBeDetermined
            => "Dein Clan konnte nicht bestimmt werden.";

        public string YouMustBeACoLeaderToUnclaimAVillage
            => "Du musst Co-Anführer sein oder die Berechtigungen haben Kanäle zu editieren, um ein Dorf zu lösen.";

        public string ThisVillageIsNotClaimedYet
            => "Dieses Dorf wurde noch nicht beansprucht.";

        public string ThisAliasIsInUse(string clanTag, string clanName)
            => $"Dieser Alias ist bereits für {clanTag} {clanName} in Benutzung.";

        public string YourAliasIsNow(string villageTag, string villageName, string alias)
            => $"Für {villageTag} {villageName} wurde `{alias}` als Alias festgelegt. Benutze `prefer {alias}` um ihn zum präferierten Alias zu machen.";

        public string AliasNotFound(string alias, string villageTag, string villageName)
            => $"Der Alias `{alias}` wurde für {villageTag} {villageName} nicht gefunden.";

        public string IsNowThePreferredAlias(string alias, string villageTag, string villageName)
            => $"{alias} ist jetzt der präferierte Alias für {villageTag} {villageName}.";

        public string AliasesMayNotContainSomeCharacters
            => "Ein Alias darf nicht @ or # enthalten.";

        public string ThereAreNoResults
            => "Es sind keine Ergebnisse vorhanden.";

        public string CallTimerMustBeBetween
            => "Der Timer muss zwischen 0 und 24 Stunden liegen.";

        public string WarSizeMustBeDivisibleBy5AndLessThan50
            => "Die Kriegsgröße muss durch 5 teilbar sein und darf nicht größer als 50 sein.";

        public string DefenderPositionMustBeBetween1And50
            => "Die Verteidigerposition muss zwischen 1 und 50 sein.";

        public string StarsMustBeBetween1And3
            => "Die Sterne müssen zwischen -1 und 3 sein.";

        public string ThereIsAlreadyACallOnThisBase
            => "Dieses Dorf wurde bereits reserviert und die Warteliste ist deaktiviert.";

        public string ClanIsNotInWar(string clanTag, string clanName)
            => $"{clanTag} {clanName} ist nicht im Krieg.";

        public string ThisCommandMustBeRanInAServer
            => "Dieser Befehl muss in einem Server ausgeführt werden.";

        public string WarLogIsPrivate(string clanTag, string clanName)
            => $"Der Kriegslog von {clanTag} {clanName} ist privat.";

        public string AnErrorOccuredLocatingYourWar(string clanTag, string clanName)
            => $"Beim Suchen des Krieges von {clanTag} {clanName} ist ein Fehler aufgetreten.";

        public string MustUsePrivateWars
            => "Wegen eines API-Fehlers während der CWL, musst du den Befehl `privatewars` ausführen.";

        public string StartANewWar
            => "Benutze `start` um einen neuen Krieg zu starten.";

        public string CallStackingIsDisabled
            => "Dieses Dorf wurde bereits reserviert und die Warteliste für diesen Clan ist deaktiviert.";

        public string ThisCommandIsOnlyForPrivateWars
            => "Dieser Befehl ist ausschließlich für private Kriege.";

        public string ThisChannelAlreadyHasAClanClaimed
            => "Dieser Kanal wurde bereits mit einem Clan verknüpft. Du kannst `claimclan` in einem anderen Kanal ausführen oder `unclaimclan` hier benutzen.";

        public string VillageIsNotInWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} ist nicht in diesem Krieg.";

        public string VillageIsOutOfAttacks(string villageTag, string villageName)
            => $"{villageTag} {villageName} hat keine Angriffe mehr zur Verfügung.";

        public string VillageIsNotInAnActiveWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} ist in keinem aktiven Krieg.";

        public string ThisCommandIsDisabledDuringCWL
            => "Dieser Befehl ist während der CWL nicht verfügbar.";

        public string YouAreNotInAnyActiveWarWar()
            => "Du bist in keinem aktiven Krieg.";

        public string YouAreOutOfAttacks()
            => "Du hast keine Angriffe mehr zur Verfügung.";

        public string YouAreNotInAnyActiveWarWar(string userName)
            => $"{userName} ist in keinem aktiven Krieg.";

        public string YouAreOutOfAttacks(string cachedMemberDisplayName)
            => $"{cachedMemberDisplayName} hat keine Angriffe mehr zur Verfügung.";

        public string NoAttacksFound
            => "Es wurden keine Angriffe gefunden.";

        public string ThisChannelMustBeInACategory
            => "Dieser Kanal muss in einer Kategorie sein.";

        public string OrgNotFound
            => "Diese Organisation wurde nicht gefunden.";

        public string LeagueNotFound
            => "Diese Liga wurde nicht gefunden.";

        public string NoLeagueWarsFoundInLastSixDays(string leagueInitials) =>
            $"Diese Liga hat keine Kriege in den letzten sechs Tagen zu verzeichnen. Wenn dies nicht korrekt ist kannst du deinen Liga-Repräsentanten im Supportserver taggen. Wenn dein Krieg ein Turnierkrieg ist, benutze den Befehl `requestLeague {leagueInitials}`.";

        public string SeeAWarThatIsMissing(string leagueInitials) =>
            $"```Fehlt ein Krieg?\n\nWenn es dein Krieg ist, benutze den Befehl requestleague {leagueInitials}.\n\nAnsonsten kannst du dem Supportserver beitreten und deinen Liga-Repräsentanten taggen.\n\nMöchtest du dabei helfen diese Liga auf dem neusten Stand zu halten?\n\nTritt dem Supportserver bei um die Rolle zu erhalten.```";

        public string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName)
            => $"Ausschließlich Mitglieder von {clanTag} {clanName} können dies sehen.";

        public string ThisWarIsAlreadyInALeague
            => "Dieser Krieg ist bereis in einer Liga.";

        public string YourRequestIsPendingApproval
            => "Deine Anfrage steht noch aus.";

        public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
            => $"Es wurde kein teilnehmender Clan mit dem Namen {dbParticipantName} in {leagueInitials} Saison {season} gefunden.";

        public string NoParticipants(string leagueInitials, int season)
            => $"Es sind keine Clans in {leagueInitials} Saison {season} vorhanden.";

        public string ThisLeagueHasNoDivisions
            => "Diese Liga hat keine Spielkategorien.";

        public string YouHaveClaimedXAttacks(int count, string tag, string name)
            => $"Du hast {count} Angriffe mit {tag} {name} reserviert.";

        public string YouAndThisBotMustHavePermissionToManageRoles
            => "Um diesen Befehl auszuführen brauchen der Bot und du die Berechtigung Rollen zu bearbeiten.";

        public string RolesWillNoLongerBeUpdated
            => "Die Rollen werden nicht länger aktualisiert.";

        public string RolesWillBeUpdated(int roles)
            => $"{roles} Rollen werden automatisch vergeben.";

        public string DeletedXRoles(int count)
            => $"Es wurden {count} Rollen gelöscht.";

        public string CreatedXRoles(int count)
            => $"Es wurden {count} Rollen erstellt. Um Clanspezifische Rollen zu erstellen, muss dieser Befehl mit dem Clantag erneut ausgeführt werden.";

        public string CreatedXRoles(string clanTag, string clanName, int count)
            => $"Es wurden {count} Rollen für {clanTag} {clanName} erstellt.";

        public string CreatedXRoles(int count, int errors)
            => $"Es wurden {count} Rollen erstellt. {errors} Rollen konnten auf Grund von Serverlimits nicht erstellt werden.";

        public string ThisVillageHasNoBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} ist von keinem Clan gebannt.";

        public string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName)
            => $"{villageTag} {villageName} ist nicht länger von {clanTag} {clanName} gebannt.";

        public string ThisClanHasNoBans(string clanTag, string clanName)
            => $"{clanTag} {clanName} ist nicht gebannt.";

        public string ThisOrgHasNoBans
            => "Diese Organisation hat noch niemanden gebannt.";

        public string ThisVillageHasNoOrgBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} ist in keiner Organisation gebannt.";

        public string PleaseTryAgainAndProvideAReasonForTheBan
            => "Bitte versuche es erneut und gebe einen Grund für den Bann an.";

        public string ClanDescriptionMustEndWithMB
            => "Um einen Clan festzulegen, muss die Clanbeschreibung mit `mb` enden. Dies ist nur aus Sicherheitsgründen erforderlich und kann später wieder entfernt werden.";

        public string YourLanguageHasBeenChangedTo(string language)
            => $"Deine Sprache wurde auf {language} festgelegt.";

        public string IDontKnowThatLanguage
            => "Diese Sprache wird noch nicht unterstützt. Wenn diese Sprache hinzugefügt werden soll, klicke auf https://github.com/devhl-labs/MinionBot5.Language.";

        public string PrefixRules
            => "Der Prefix darf nicht länger als fünf Zeichen sein. Zudem dürfen die Symbole # @ und Leerzeichen nicht im Präfix vorkommen.";

        public string PrefixDefinition
            => "Ein Präfix ist eine Zeichenfolge, welche dem eigentlichen Befehl voran geht. Ein Präfix kann z.B. !, $, * oder Ähnliches sein. Dieser Präfix ist dazu da, um die Befehle von normalen Nachrichten zu trennen. Um einen Präfix zu setzten, benutze `setprefix yourPrefix`. yourPrefix ist dann der neue Präfix.";

        public string UseDeletePrefixToUndoThis(string userMention, string prefix)
            => $"{userMention} Du hast den neuen Präfix erfolgreich gespeichert. Jeder Befehl muss ab jetzt mit `{prefix}` starten. Lösche den Präfix wieder mit `deleteprefix`.";

        public string YouMustHavePermissionToManageGuild
            => "Du brauchst die Berechtigung um den Server zu verwalen.";

        public string ThisChannelHasNoClanClaimed
            => "Diesem Kanal wurde kein Clan zugewiesen.";

        public string InvalidTownHallLevel
            => "Du hast ein falsches Rathauslevel angegeben.";

        public string MustBeAGoldPatron
            => "Du musst mindestens ein Goldpatron sein.";

        public string MustBeACrystalPatron
            => "Du musst mindestens ein Kristallpatron sein.";

        public string MustBeAMasterPatron
            => "Du musst mindestens ein Meisterpatron sein.";

        public string AlreadySponsored
            => "Du sponserst schon diesen Server.";

        public string SponsoringServer(ulong id, string name)
            => $"Du sponserst nun {id} {name}.";

        public string NotSponsoringAnyServers
            => "Du sponserst keinen Server.";

        public string ServerMustBeSponsored
            => "Dieser Server muss hierfür gesponsert werden. Wenn du ein Patron bist, führe den Befehl `sponsorserver` aus.";

        public string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName)
            => $"Für den Clan {clanTag} {clanName} werden neue 3-Sterne Angriffe nun mit {attack}, Verteidigungen mit {defend} angezeigt.";

        public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
            => $"Für den Clan {clanTag} {clanName} werden neue 3-Sterne Angriffe nun mit {emoji} angezeigt.";

        public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
            => $"Für den Clan {clanTag} {clanName} werden neue 3-Sterne Verteidigungen nun mit {emoji} angezeigt.";

        public string CommandMustBeRanInACategory
            => "Dieser Befehl muss in einer Kategorie ausgeführt werden.";

        public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
            => $"Dieser Befehl wird alle Textkanäle für {clanTag} {clanName} in dieser Kategorie umbenennen. Willst du fortfahren?";

        public string ChannelsWillBeRenamed
            => "Alle Textkanäle in dieser Kategorie werden bei neuen Kriegen und Angriffen umbenannt. Versichere dich, dass ich die Berechtigung habe, Kanäle zu bearbeiten.";

        public string CommandCanceled
            => "Der Befehl wurde abgebrochen.";

        public string NowRenamingChannel(string clanTag, string clanName, int position)
            => $"Dieser Kanal wird in `{clanTag} {clanName}, enemy position {position}` jetzt umbenannt.";

        public string NeedPermissionToManageChannels
            => "Mir fehlen die Berechtigungen, Kanäle zu bearbeiten.";

        public string NoAttacksLeft(string enemyClanTag, string enemyClanName)
            => $"Es sind keine Angriffe im Krieg gegen {enemyClanTag} {enemyClanName} mehr verfügbar.";

        public string UpdatedVillages(string clanTag, string clanName, int villageCount)
            => $"Es wurden {villageCount} Dörfer in {clanTag} {clanName} aktualisiert.";

        public string Restrict
            => "Ab jetzt werden alle Befehle in diesem Kanal ignoriert. Benutze `restrict false` um dies rückgängig zu machen. Ich empfehle, die Rollen zu verändern anstatt diesen Befehl zu verwenden.";

        public string NotRestricted
            => "Dieser Kanal wird nicht länger ignoriert.";

        public string WarChannelFailed
            => "Dieser Befehl setzt voraus, dass dieser Server gesponsert wird. Wenn du ein Patron bist, musst du erst den `sponsorserver` Befehl ausführen. Außerdem brauchen du und ich die Berechtigung Kanäle zu bearbeiten.";

        public string BecomeAPatronToDownloadThis
            => "Du musst ein Patron sein um dies in einer Datei runterladen zu können. Wenn du dein Patron bist stelle sicher, dass ich die Berechtigung habe Dateien zu senden.";

        public string BecomeAPatronToUseThisCommand
            => "Wenn du diesen Befehl ausführen möchtest, musst du erst ein Patron werden.";

        public string IncludeTheLeagueYouWouldLikeToSee
            => "Bitte gebe die Liga an, welche du sehen möchtest. Benutze den scoreboard Befehl um eine Liste aller Ligen zu erhalten.";

        public string WarEndWarningsDisabled
            => "Wenn der Krieg fast zu Ende ist, wird die `hashits` Rolle nicht mehr getagged.";

        public string WarEndWarningsEnabled
            => "Wenn der Krieg fast zu Ende ist, wird die `hashits` Rolle getagged.";

        public string WarStartWarningsDisabled
            => "Wenn der Krieg startet, wird die `hashits` Rolle nicht mehr getagged.";

        public string WarStartWarningsEnabled
            => "Wenn der Krieg startet, wird die `hashits` Rolle getagged.";

        public string IncorrectParametersOrMissingPermission
            => "Du hast falsche Parameter angegeben oder es fehlen Berechtigungen.";

        public string CommandNameIsAPlaceHolder
            => "Der Befehlname ist lediglich ein Platzhalter. Ersetze ihn mit dem richtigen Befehl.";

        public string YouHaveHiddenXAttacks(int count)
            => $"Du hast {count} versteckte Angriffe.";

        public string YouHaveUnhiddenXAttacks(int count)
            => $"You have unhidden {count} attacks.";

        public string CommandNotFound
            => "Der Befehl wurde nicht gefunden.";

        public List<CommandInfo> Commands { get; } = new List<CommandInfo>
    {
        //management
        new CommandInfo(1, "claimclan",
@"Run this command for each clan you want to claim in a different channel.
You must put the letters 'mb' after the clan description for this to work.",
            "#clanTag"),
        new CommandInfo(1, "unclaimclan",
@"You may remove a clan from your server.
To add it back, you will need to add 'mb' to the description again.",
            "none",
            "#clanTag",
            "\"all\" #clanTag"),
        new CommandInfo(1, "defaultclan",
@"Allows you to tell Minion Bot which clan to use in channels where claimclan has never been ran.
You may run this after running claimclan.
The first clan you claim in a server is automatcally the default clan.",
            "none",
            "#clanTag"),
        new CommandInfo(1, "myclan", "Use this command to see what clan tag Minion Bot is using in a given channel."),
        new CommandInfo(1, "myclans", "View all the clans your server has claimed."),
        new CommandInfo(1, "myserver", "Get information about your server."),           
        new CommandInfo(1, "myroles", "Get the roles that are managed by this bot."),
        new CommandInfo(1, "mychannel", "Get information on your channel's settings."),
        new CommandInfo(1, "mychannels", "Get information on all of your channel settings.", ""),
        new CommandInfo(1, "deleteroles", "This will delete all of the roles that were created by this bot."),
        new CommandInfo(1, "addroles",
@"This will create predefined roles in this server.
These roles will be assigned automatically.
You can rename or delete the roles created by this command.",
            "none",
            "true/false",
            "\"guild\" [minTownHall] [maxTownHall]",
            "minTownHall [maxTownHall]"),
        new CommandInfo(1, "restrict",
"This will make Minion Bot ignore commands in a channel. It is recommended that you use discord permissions instead of this command.",
            "[true/false]"),
        new CommandInfo(1, "posthits",
            "Control what channels the attacks get posted to. You must have permission to manage channel to change the channel.",
            "#channel",
            "[true/false]",
            "number"),
        new CommandInfo(1, "postdonations",
            "Control what channel donations are posted to. You must have permission to manage channel.",
            "#channel",
            "[true/false]"),
        new CommandInfo(1, "postgreetings",
            "Control what channel greetings are posted to. You must have permission to manage channel.",
            "#channel",
            "[true/false]"),
        new CommandInfo(1, "endwarning",
            "Toggle hasHits mentions for the war end warning. If you do not have the hasHits role this will not do anything.",
            "[true/false]"),
        new CommandInfo(1, "startwarning",
            "Toggle hasHits mentions for the war start warning. If you do not have the hasHits role this will not do anything.",
            "[true/false]"),
        new CommandInfo(1, "setlanguage",
"Change the language. Visit [github.com](https://github.com/devhl-labs/MinionBot5.Language) to view the supported languages.", "languageName"),
        new CommandInfo(1, "setprefix",
@"By default Minion Bot has no prefix. 
Assign one of your choice with this command.
Once assigned, commands will require the prefix to run.
If your prefix is !, the help command will look like!help.
Use deleteprefix to undo this.", "yourPrefix"),
        new CommandInfo(1, "deleteprefix", "This command will delete your prefix."),






        //villages
        new CommandInfo(2, "alias", "Give a village a nickname. Keep it short and easy to type.", "#villageTag alias"),
        new CommandInfo(2, "banvillage", "Ban a village from your clan.", "#villageTag reason"),
        new CommandInfo(2, "unbanvillage", "Unban a village from your clan.", "#villageTag"),
        new CommandInfo(2, "claim",
@"Tell the bot who owns a village.
Use a @discordMention to help your clanmates claim their village.
If you're having trouble using the name of the village, try using the village tag.",
            "villageTag [@discordMention]"),
        new CommandInfo(2, "deletealias",
@"Use this to delete an old alias.
Especially useful after you change a village name in game.
Aliases should be unique, so you should only have to provide this command the alias name.",
            "aliasToDelete",
            "#villageTag aliasToDelete",
            "#villageTag \"all\""),
        new CommandInfo(2, "getalias", "View all nicknames for a village.",
            "#villageTag",
            "@discordMention",
            "none"),
        new CommandInfo(2, "getbans", "View all bans for your clan or a given village.", "" +
            "#villageTag",
            "none",
            "\"summary\""),
        new CommandInfo(2, "getclaims", "Provides an overview of which villages are claimed.",
            "#villageTag",
            "none",
            "@discordMention"),
        new CommandInfo(2, "getunclaimed", "View all villages that are not claimed."),
        new CommandInfo(2, "members", "View all the members who are currently in your clan.",
            "none",
            "#villageTag",
            "@discordMention",
            "townhallLevel"),
        new CommandInfo(2, "lookup", "Lookup various information about a village.", "#villageTag"),
        new CommandInfo(2, "mybase", "View information on a given base.",
            "none",
            "@discordMention",
            "#villageTag"),
        new CommandInfo(2, "prefer",
@"Minion Bot will try to use the prefered alias over other aliases.
You may only have one prefered alias at a time.
Aliases should be unique, so you only need to provide the alias name.",
            "aliasToPrefer"),
        new CommandInfo(2, "search",
@"Use this to see what villages are in your clan.
Also use it to quickly get your clanmates village tag.
Provide a string to search to narrow the results.",
            "[text]"),
        new CommandInfo(2, "unclaim", "Unassociate a village from a discord user.", "[#villageTag]"),
        new CommandInfo(2, "updatemembers", "Update roles and hero levels for all villages in your clan."),
        new CommandInfo(2, "claimattacks",
@"This will claim all previously unclaimed attacks.
This includes attacks and defenses done before you claimed the village.
**This cannot be undone.**",
            "#villageTag"),




        //war
        new CommandInfo(3, "calltimer", "Set the amount of time a call is good for.", "numOfHours"),
        new CommandInfo(3, "stackcalls", "When enabled, multiple villages can call an enemy base at the same time.", "[true/false]"),
        new CommandInfo(3, "privatewars",
            "Tell Minion Bot that you will keep your war log closed. This will enable commands intended for private war logs such as start and report.",
            "[true/false]"),
        new CommandInfo(3, "publicwars",
            "Tell Minion Bot that you will keep your war log open. Your war caller will be managed automatically.",
            "[true/false]"),
        new CommandInfo(3, "print", "View the villages that are called in this war."),
        new CommandInfo(3, "start",
            "This command is only for clans that keep their war log private. Use it to start a new war in Minion Bot.",
            "size [enemyName]"),
        new CommandInfo(3, "report",
            "This command is only for clans that keep their war log private. Use it to report the outcome of an attack.",
            "defenderPosition stars"),
        new CommandInfo(3, "call",
            "Call a given enemy base.",
            "defenderPosition",
            "defenderPosition #villageTag",
            "defenderPosition @discordMention",
            "defenderPosition text"),
        new CommandInfo(3, "delete",
            "Delete a call on an enemy base. Only providing the defender position will delete your own call on the base, or the first call on that base.",
            "defenderPosition",
            "defenderPosition callPosition",
            "defenderPosition #attackerTag",
            "defenderPosition @attackerMention"),
        new CommandInfo(3, "nostats",
            "Attacks will not count toward stats nor leaderboards if you run this. This enables you to have a fun war where the results don't matter. You must be a coleader to run this.",
            "[true/false]"),
        new CommandInfo(3, "getremainingattacks",
            "This will show who has attacks left for your clan. If the village has a call, it will show that as well.",
            "none",
            "#villageTag",
            "@discordMention"),
        new CommandInfo(3, "getlastattacks", "View the last attacks.",
            "none",
            "#villageTag \"cwl\"",
            "#villageTag [league] [season]",
            "@discordMention \"cwl\"," +
            "#discordMention [league] [season]"),
        new CommandInfo(3, "getlastdefenses", "View the last defenses.",
            "none",
            "#villageTag",
            "#villageTag \"cwl\"",
            "#villageTag league [season]",
            "@discordMention",
            "@discordMention \"cwl\"",
            "#discordMention league [season]"),
        new CommandInfo(3, "getwars", "Get a list of all known wars for a clan.", "none", "#clanTag", "league"),
        new CommandInfo(3, "matchup", "View a side by side comparison of the current war."),
        new CommandInfo(3, "defenses", "Get a summary of defenses remaining."),
        new CommandInfo(3, "announcewar", "Print the war found announcement.",
            "none",
            "warId"),
        new CommandInfo(3, "attacks", "Show the number of attacks left for each side of the war map."),
        new CommandInfo(3, "roster", "View a summary of the villages in a given war.",
            "none",
            "warId"),
        new CommandInfo(3, "lineup", "View detailed information on each village in the current war.",
            "none",
            "\"enemy\""),





        //stats
        new CommandInfo(4, "leaguestats", "Show the stats for this week's league wars.", "league"),
        new CommandInfo(4, "botleader",
@"Get the best attackers or defenders in the entire bot.
This will get the best hit rates for all villages, regardless of clan.
War Type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.",
            "attackerTH defenderTH [numOfMonths] [warType] [\"defense\"] [freshType]"),
        new CommandInfo(4, "clanleagueleader",
@"This will show which clan has the best hit rate in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.",
            "attackerTH defenderTH league [season] [\"defense\"] [freshType]"),
        new CommandInfo(4, "clanstats",
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
        new CommandInfo(4, "leagueleader",
@"This will show the league with the best hit rate.
Fresh type can be fresh or cleanup.",
            "attackerTH defenderTH [\"defense\"] [freshType]"),
        new CommandInfo(4, "stats",
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
        new CommandInfo(4, "cwlstats", "This will show the current wars for all clans in your current SC CWL league.", "none", "#clanTag"),
        new CommandInfo(4, "villageleader",
@"This will show where you rank among your clan.
Number of months will limit the attacks to the last X months.
The season will default to the current season.
For all seasons, enter 0.
War type can be farm, arranged, competetive, or SCCWL.
Fresh type can be fresh or cleanup.
The clan parameter will exclude attacks your clanmates have done while in other clans.",
            "attackerTH defenderTH [numberOfMonths] [league] [season] [\"defense\"] [freshType]",
            "attackerTH defenderTH [numberOfMonths] [warType] [\"defense\"] [freshType] [\"clan\"]"),
        new CommandInfo(4, "villageleagueleader",
@"This will show the best attackers and defenders in a league.
The season will default to the current season.
For all seasons, enter 0.
Fresh type can be fresh or cleanup.",
            "attackerTH defenderTH league [season] [\"defense\"] [freshType]"),




        //patreon
        new CommandInfo(5, "downloadattacks", "Download a file containing your attacks.",
            "none",
            "warId",
            "#villageTag",
            "@discordMention"),
        new CommandInfo(5, "warchannel",
            "This command will rename a channel to reflect the number of stars on an enemy base. You must have permission to manage channel.",
            "none",
            "defenderPosition"),
        new CommandInfo(5, "sponsorserver", "Sponsor the current server."),
        new CommandInfo(5, "unsponsorserver", "Stop sponsoring a server. You can get the server ID from `mysponsorships`.", "[serverId]"),
        new CommandInfo(5, "mysponsorship", "View all of the servers you are sponsoring."),
        new CommandInfo(0, "freshemote",
            "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack or defense.",
            "attackEmoji defennseEmoji"),
        new CommandInfo(5, "freshattack",
            "Sponsored servers can use this to control what emoji is displayed for a fresh three star attack.",
            "attackEmoji"),
        new CommandInfo(5, "freshdefense", "Sponsored servers can use this to control what emoji is displayed for a fresh three star defense.",
            "defenseEmoji"),
        new CommandInfo(5, "hideattacks",
@"This will hide any attack that you have claimed. You must be a master patron to use this command. Your attacks are claimed by having the village claimed while the attack occurs or throught the claimattacks command.",
            "none",
            "#villageTag",
            "olderThanXMonthsAgo"),
        new CommandInfo(5, "patreon", "Show your love for Minion Bot! Get a role in the support server and a few added perks."),




        //league
        new CommandInfo(6, "divisions", "View the divisions in a given league.", "league"),
        new CommandInfo(6, "scoreboard", "View the scoreboard for a league.",
            "none",
            "org",
            "league [season] [division] [#clanTag]"),
        new CommandInfo(6, "validate", "Check a given clan to see if any members have any bans in competitive leagues.",
            "none",
            "#clanTag"),
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
        new CommandInfo(6, "addclan", "Add clans to a league.", "list of #clanTags"),
        new CommandInfo(6, "removeclan", "Remove a clan from a league.", "#clanTag"),
        new CommandInfo(6, "shell", "Add a registrant clan under a participant.", "#shellTag #parentTag"),
        new CommandInfo(6, "unshell", "Move a registrant to their own participant.", "#shellTag"),
        new CommandInfo(0, "autoupdate", "This command was retired. Use `change league state` or `import` instead."),
        new CommandInfo(6, "import", "Import clan tags from a war match url.", "warMatchUrl", "warMatchId"),
        new CommandInfo(6, "addwar", "Add a war to the league. If specifying clan tags you may want to update stars and percent next.",
            "warId",
            "#losingClan #winningClan [prepStartDate]"),
        new CommandInfo(6, "removewar", "Remove a war from a league.", "warId"),
        new CommandInfo(6, "orgban",
"Ban villages from an organization. You will be notified if the village joins a registered clan or a war with a registered clan.",
            "(list of #villageTags)",
            "numOfDays (list of #villageTags)",
            "mayJoinClans mayBeInRandomWars [numOfDays] (list of #villageTags)"),
        new CommandInfo(6, "orgunban",
"Delete bans on villages from your organization.",
            "(list of #villageTags)"),
        new CommandInfo(6, "changewinner",
"Change the winner of a league war. This will only be seen in the scoreboard, not the league stats.",
            "warId win/lose/tie #clanTag"),
        new CommandInfo(6, "changestars",
"Change the stars of a league war. This will only be seen in the scoreboard, not the league stats.",
            "warId stars #clanTag"),
        new CommandInfo(6, "changepercent",
"Change the percent for a league war. This will only be seen in the scoreboard, not the league stats.",
            "warId percent #clanTag"),
        new CommandInfo(6, "leaguewinner", "Declare the league winner.", "#clanTag"),
        new CommandInfo(6, "showprivatewars", "View all clans in this league which war log is private."),
        new CommandInfo(6, "log", "Manually enter an attack. You can get map positions from the roster command.",
            "warId #attackerClanTag attackerPosition defenderPosition stars percent"),
        new CommandInfo(6, "undo", "Delete a manually entered attack.", "attackId"),












        //debugging
        new CommandInfo(7, "ping", "Inspect latency with Discord."),
        new CommandInfo(7, "permissions", "Inspect the permissions for a given member.", "[@discordMention]"),
        new CommandInfo(7, "fetchclan",
            "Retrieve information on a clan directly from the api.",
            "[#clanTag]"),
        new CommandInfo(7, "fetchclans", "Search the api for a clan by name.", "text"),
        new CommandInfo(7, "fetchcurrentwar", "Retrive the current war directly from the api.", "[#clanTag]"),
        new CommandInfo(7, "fetchplayer", "Retrive information on a player directly from the api.", "#villageTag"),
        new CommandInfo(7, "fetchleaguegroup", "Retrieve information on a league group directly from the api.", "[#clanTag]"),
        new CommandInfo(7, "fetchleaguewar", "Retrieve information on a SC CWL war directly from the api.", "#warTag"),
        new CommandInfo(7, "fetchclanwarlog", "Retrieve information on a war log directly from the api.", "[#clanTag]"),
        new CommandInfo(7, "api", "View api response times.", "[numOfMinutes]"),


        //about
        new CommandInfo(8, "info", "Get basic information on Minion Bot."),
        new CommandInfo(8, "commands", "Get a list of all commands."),
        new CommandInfo(8, "setupvideo", "Provides a link to a setup tutorial."),
        new CommandInfo(8, "fortwitch", "Provides a link to a version of Minion Bot for streamers. This is a program you run on your computer. It will update your overlay for you."),
        new CommandInfo(8, "invite", "Provides a link to the support server and to invite Minion Bot."),


    };
    }
    
}
