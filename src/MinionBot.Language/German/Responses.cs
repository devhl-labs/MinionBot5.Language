namespace MinionBot.Languages.German
{
    public class Responses : AbstractLanguage, ILanguage
    {
        public string Name => "ge-GE";
        public string Aliases { get; } = "ge-GE,ge,german,:flag_de:";


        public IBot Bot { get; } = new English.Bot();


        public ILeagueHelp LeagueHelp { get; } = new English.LeagueHelp();
        public IManagementHelp ManagementHelp { get; } = new English.ManagementHelp();
        public IAboutHelp AboutHelp { get; } = new English.AboutHelp();
        public IDebugHelp DebugHelp { get; } = new English.DebugHelp();
        public IVillageHelp VillageHelp { get; } = new English.VillageHelp();
        public IPatreonHelp PatreonHelp { get; } = new English.PatreonHelp();
        public IWarHelp WarHelp { get; } = new English.WarHelp();
        public IStatsHelp StatsHelp { get; } = new English.StatsHelp();
        public IHelpMenu HelpMenu { get; } = new English.HelpMenu();


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
            => "Du musst zuerst einen Clan festlegen. Benutze dafür den Befehl `claimclan #clanTag`.";

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
            => $"Es wurden {count} Rollen erstellt.";

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
            => "Dieser Befehl setzt voraus, dass dieser Server gesponsert wird. Wenn du ein Patron bist, musst du erst den `sponsorserver` Befehl ausführen. Außerdem brauchen du und ich die Berechtigung Kanäle zu bearbeiten. If all these conditions are met, ensure you provided the correct parameters.";

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

        public string ClanNotFound => "Clan not found.";
        public string SearchForClanReturnedNoResults(string clanTag) => $"Search for clan { clanTag } returned no results.";
        public string NotADiscordServer => "Not a discord server.";
        public string ServerNotFoundInCache => "Discord server not found in cache.";
        public string NotAServerMember => "Not a server member.";
        public string MemberNotFound => "Member not found.";
        public string NotAMemberNorSelfTag => "Not a server member nor a self tag.";
        public string OrganizationNotFound => "Organization not found.";
        public string WarNotFound => "War not found.";
        public string NotADate => "Not a date.";
        public string DivisionNotFound => "Division not found.";
        public string NotAUrl => "Not a valid url.";
        public string ValidWarTypes => "Valid war types are farm, arranged, or comp.";
        public string CommandMustBeRanInYourServer => "This command must be ran in your server.";
        public string CommandMustBeRanInSupportServer => "This command must be ran in the support server.";
        public string YouMustHavePermissionToManageChannels => "You must have permission to manage channels.";
        public string MbGoesInGame => "You're using this command wrong. \"mb\" does not go here, it goes in game in your clan description.";
        public string YourClanTagDoesNotEndInAPeriod => "Your clan tag does not end with a period. Try again without the period.";
        public string RoleGranted => "The role has been granted.";
        public string RoleRevoked => "The role has been revoked.";
    }    
}
