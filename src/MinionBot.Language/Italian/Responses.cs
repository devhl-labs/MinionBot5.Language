namespace MinionBot.Languages.Italian
{
    public class Responses : AbstractLanguage, ILanguage
    {
        public string Name => "it-IT";
        public string Aliases { get; } = "it-IT,it,italian,:flag_it:";


        public IBot Bot { get; } = new Bot();


        public IManagementHelp ManagementHelp { get; } = new ManagementHelp();
        public IAboutHelp AboutHelp { get; } = new AboutHelp();
        public IDebugHelp DebugHelp { get; } = new DebugHelp();
        public ILeagueHelp LeagueHelp { get; } = new LeagueHelp();
        public IVillageHelp VillageHelp { get; } = new VillageHelp();
        public IPatreonHelp PatreonHelp { get; } = new PatreonHelp();
        public IWarHelp WarHelp { get; } = new WarHelp();
        public IStatsHelp StatsHelp { get; } = new StatsHelp();
        public IHelpMenu HelpMenu { get; } = new HelpMenu();


        public string ThisLeagueIsInactive
            => "Questa lega è inattiva o fuori stagione. Se ciò non è corretto, per favore unisciti al server di supporto e tagga i rappresentanti della lega.";
        public string AllRolesCanBeManaged
            => "Tutti i ruoli possono essere gestiti.";

        public string SomeRolesCantBeManaged
            => "Alcuni ruoli non possono essere gestiti.";

        public string ATimeoutOccured
            => "Si è verificato un timeout. Per favore riprova.";

        public string ThisCommandIsNotForBots
            => "Questo comando non supporta i bot.";

        public string QuotedParametersAreTypedAsShown
            => "I parametri tra virgolette sono digitati come mostrato.";

        public string BracketedParametersAreOptional
            => "I parametri tra parentesi sono opzionali.";

        public string MustBeRanInGuild
            => "Questo comando deve essere eseguito in un server.";

        public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
            => "Questo comando non è disponibile né per CWL né per guerre di leghe competitive.";

        public string MustClaimClan
            => "Devi prima rivendicare un clan. Prova a utilizzare il comando `claimclan #clanTag`.";

        public string NoStatsEnabled
            => "Le statistiche non saranno più considerate. Gli attacchi in questa guerra non saranno presi in considerazione per comandi come botleader, villageleader, etc.";

        public string NoStatsDisabled
            => "Le statistiche saranno ora considerate. Gli attacchi in questa guerra saranno presi in considerazione per le classifiche.";

        public string NewClanDefault(string clanTag, string clanName)
            => $"{clanTag} {clanName} ora è il clan predefinito per questo server.";

        public string ClanNotClaimed(string clanTag, string clanName)
            => $"{clanTag} {clanName} non è rivendicato in questo server. Utilizza `claimclan {clanTag}`.";

        public string ClanNotClaimed()
            => $"Questo server non ha rivendicato nessuno di questi clan.";

        public string NoClansToUnclaim
            => "Non ci sono clan da scollegare.";

        public string ClanUnclaimed(string clanTag, string clanName)
            => $"Hai scollegato {clanTag} {clanName}.";

        public string ClanUnclaimedFromAllServers(string clanTag, string clanName)
            => $"Hai scollegato {clanTag} {clanName} da tutti i server.";

        public string RegistrantCantBeRemoved(string clanTag, string clanName)
            => $"{clanTag} {clanName} non può essere rimosso. Assicurati prima di rimuovere tutte le guerre poi prova nuovamente.";

        public string ClaimClan
            => "Aggiungi le lettere mb alla fine della descrizione del clan.\nAspetta qualche minuto, poi esegui claimclan #clanTag.\nmb è richiesto solo per ragioni di sicurezza e può essere rimosso dopo il collegamento.";

        public string ThisVillageIsClaimed
            => "Questo villaggio è rivendicato. Chiedi a un cocapo di scollegarlo per te.";

        public string NoVillagesClaimed
            => "Non hai villaggi rivendicati. Utilizza `claim #villageTag` per rivendicare il tuo villaggio.";

        public string YouAlreadyHaveThisVillageClaimed
            => "Hai già rivendicato questo villaggio.";

        public string YouHaveClaimed(string villageTag, string villageName)
            => $"Hai rivendicato {villageTag} {villageName}";

        public string AlreadyHasThisVillageClaimed(string userName)
            => $"{userName} ha già rivendicato questo villaggio.";

        public string InvalidTag => "Tag non valido.";

        public string YouDontHaveAnyVillagesClaimed
            => "Non hai nessun villaggio rivendicato.";

        public string VillageNotFound()
            => "Villaggio non trovato.";

        public string VillageNotFound(string tag, string clanName, string input)
            => $"Nessun villaggio è stato trovato in {tag} {clanName} con tag o nome {input}.";

        public string YourClanCouldNotBeDetermined
            => "Non è stato possibile determinare il tuo clan.";

        public string YouMustBeACoLeaderToUnclaimAVillage
            => "Devi essere cocapo o avere il permesso di gestire i canali per scollegare un villaggio.";

        public string ThisVillageIsNotClaimedYet
            => "Questo villaggio non è ancora stato rivendicato.";

        public string ThisAliasIsInUse(string clanTag, string clanName)
            => $"Questo alias è già utilizzato in {clanTag} {clanName}.";

        public string YourAliasIsNow(string villageTag, string villageName, string alias)
            => $"{villageTag} {villageName} ora ha `{alias}` come alias. Utilizza `prefer {alias}` per renderlo preferito.";

        public string AliasNotFound(string alias, string villageTag, string villageName)
            => $"Alias `{alias}` non trovato per {villageTag} {villageName}.";

        public string IsNowThePreferredAlias(string alias, string villageTag, string villageName)
            => $"{alias} ora è l'alias preferito per {villageTag} {villageName}.";

        public string AliasesMayNotContainSomeCharacters
            => "Un alias non può contenere i simboli @ o #.";

        public string ThereAreNoResults
            => "Non ci sono risultati.";

        public string CallTimerMustBeBetween
            => "Il timer di prenotazione deve essere compreso tra 0 e 24 ore.";

        public string WarSizeMustBeDivisibleBy5AndLessThan50
            => "La dimensione della guerra deve essere divisibile per 5 e minore o uguale a 50.";

        public string DefenderPositionMustBeBetween1And50
            => "La posizione del difensore deve essere compresa tra 1 e 50.";

        public string StarsMustBeBetween1And3
            => "Le stelle devono essere comprese tra 1 e 3.";

        public string ThereIsAlreadyACallOnThisBase
            => "C'è già una prenotazione su questa base. La coda di prenotazioni è disabilitata.";

        public string ClanIsNotInWar(string clanTag, string clanName)
            => $"{clanTag} {clanName} non è in guerra.";

        public string ThisCommandMustBeRanInAServer
            => "Questo comando deve essere eseguito in un server.";

        public string WarLogIsPrivate(string clanTag, string clanName)
            => $"Il registro di guerra per {clanTag} {clanName} è privato.";

        public string AnErrorOccuredLocatingYourWar(string clanTag, string clanName)
            => $"Si è verificato un errore durante l'individuazione della guerra per {clanTag} {clanName}.";

        public string MustUsePrivateWars
            => "A causa di un problema con le API, durante CWL, è necessario utilizzare il comando `privatewars`.";

        public string StartANewWar
            => "Utilizza il comando `start` per iniziare una nuova guerra.";

        public string CallStackingIsDisabled
            => "C'è già una prenotazione su questa base. La coda di prenotazioni è disabilitata per questo clan.";

        public string ThisCommandIsOnlyForPrivateWars
            => "Questo comando è riservato alle guerre private.";

        public string ThisChannelAlreadyHasAClanClaimed
            => "Questo canale ha già un clan rivendicato. Puoi eseguire `claimclan` in un altro canale, o eseguire `unclaimclan` qui.";

        public string VillageIsNotInWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} non è in questa guerra.";

        public string VillageIsOutOfAttacks(string villageTag, string villageName)
            => $"{villageTag} {villageName} ha esaurito gli attacchi a disposizione.";

        public string VillageIsNotInAnActiveWar(string villageTag, string villageName)
            => $"{villageTag} {villageName} non è in una guerra attiva.";

        public string ThisCommandIsDisabledDuringCWL
            => "Questo comando è disabilitato durante CWL.";

        public string YouAreNotInAnyActiveWarWar()
            => "Non sei in nessuna guerra attiva.";

        public string YouAreOutOfAttacks()
            => "Hai esaurito gli attacchi a disposizione.";

        public string YouAreNotInAnyActiveWarWar(string userName)
            => $"{userName} non è in una guerra attiva.";

        public string YouAreOutOfAttacks(string cachedMemberDisplayName)
            => $"{cachedMemberDisplayName} ha esaurito gli attacchi a disposizione.";

        public string NoAttacksFound
            => "Nessun attacco trovato.";

        public string ThisChannelMustBeInACategory
            => "Questo canale deve essere in una categoria.";

        public string OrgNotFound
            => "Organizzazione non trovata.";

        public string LeagueNotFound
            => "Lega non trovata.";

        public string NoLeagueWarsFoundInLastSixDays(string leagueInitials) =>
            $"Questa lega non ha avuto guerre negli ultimi sei giorni. Se ciò non è corretto, puoi taggare il rappresentante della lega nel server di supporto. Se la tua guerra è una guerra di lega, usa il comando `requestLeague {leagueInitials}`.";

        public string SeeAWarThatIsMissing(string leagueInitials) =>
            $"```Vedi una guerra che manca?\n\nSe è la tua guerra, utilizza il comando requestleague {leagueInitials}.\n\nAltrimenti puoi unirti al server di supporto e taggare il rappresentante della lega.\n\nVuoi aiutare ad aggiornare questa lega?\n\nUnisciti al server di supporto per ottenere il ruolo.```";

        public string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName)
            => $"Solo i membri di {clanTag} {clanName} possono vedere questo.";

        public string ThisWarIsAlreadyInALeague
            => "Questa guerra è già in una lega.";

        public string YourRequestIsPendingApproval
            => "La tua richiesta è in attesa di approvazione.";

        public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
            => $"Nessun clan partecipante con nome {dbParticipantName} è stato trovato in {leagueInitials} stagione {season}.";

        public string NoParticipants(string leagueInitials, int season)
            => $"Non ci sono clan in {leagueInitials} stagione {season}.";

        public string ThisLeagueHasNoDivisions
            => "Questa lega non ha divisioni.";

        public string YouHaveClaimedXAttacks(int count, string tag, string name)
            => $"Hai rivendicato {count} attacchi per {tag} {name}.";

        public string YouAndThisBotMustHavePermissionToManageRoles
            => "Tu e il bot dovete avere il permesso di gestire i ruoli per eseguire questo comando.";

        public string RolesWillNoLongerBeUpdated
            => "I ruoli non saranno più aggiornati.";

        public string RolesWillBeUpdated(int roles)
            => $"{roles} ruoli saranno assegnati automaticamente.";

        public string DeletedXRoles(int count)
            => $"{count} ruoli eliminati.";

        public string CreatedXRoles(int count)
            => $"{count} ruoli creati.";

        public string CreatedXRoles(string clanTag, string clanName, int count)
            => $"{count} ruoli creati per {clanTag} {clanName}.";

        public string CreatedXRoles(int count, int errors)
            => $"{count} ruoli creati. {errors} ruoli non possono essere creati a causa di limiti del server o di velocità.";

        public string ThisVillageHasNoBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} non è bannato da nessun clan.";
        public string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName)
            => $"{villageTag} {villageName} non è più bannato in {clanTag} {clanName}.";

        public string ThisClanHasNoBans(string clanTag, string clanName)
            => $"{clanTag} {clanName} non ha ban.";

        public string ThisOrgHasNoBans
            => "Questa organizzazione non ha ban.";

        public string ThisVillageHasNoOrgBans(string villageTag, string villageName)
            => $"{villageTag} {villageName} non è bannato da nessuna organizzazione.";

        public string PleaseTryAgainAndProvideAReasonForTheBan
            => "Per favore riprova e fornisci un motivo per il ban.";

        public string ClanDescriptionMustEndWithMB
            => "Per rivendicare il tuo clan, la descrizione deve finire con `mb`. Questo è solo per motivi di sicurezza e può essere rimosso in seguito.";

        public string YourLanguageHasBeenChangedTo(string language)
            => $"La tua lingua è stata cambiata in {language}.";

        public string IDontKnowThatLanguage
            => "Non conosco questa lingua. Se vuoi aggiungerla, visita https://github.com/devhl-labs/MinionBot5.Language.";

        public string PrefixRules
            => "Un prefisso ha 5 o meno caratteri e non può contenere # @ o uno spazio.";

        public string PrefixDefinition
            => "Un prefisso è un carattere che va posto all'inizio del comando, come !, $, *, etc. Mi permette di capire che stai parlando con me. Per impostare un prefisso, utilizza `setprefix !`. Il ! può essere anche altri caratteri.";

        public string UseDeletePrefixToUndoThis(string userMention, string prefix)
            => $"{userMention} Hai creato un prefisso. Ora tutti i comandi devono iniziare con `{prefix}`. Utilizza `deleteprefix` per rimuoverlo.";

        public string YouMustHavePermissionToManageGuild
            => "Devi avere il permesso di gestire il server.";

        public string ThisChannelHasNoClanClaimed
            => "Questo canale non ha clan collegati.";

        public string InvalidTownHallLevel
            => "Hai fornito un livello di municipio non valido.";

        public string MustBeAGoldPatron
            => "Devi essere un gold patron o superiore.";

        public string MustBeACrystalPatron
            => "Devi essere un crystal patron o superiore.";

        public string MustBeAMasterPatron
            => "Devi essere un master patron o superiore.";

        public string AlreadySponsored
            => "Stai già sponsorizzando questo server.";

        public string SponsoringServer(ulong id, string name)
            => $"Stai sponsorizzando {id} {name}.";

        public string NotSponsoringAnyServers
            => "Non stai sponsorizzando nessun server.";

        public string ServerMustBeSponsored
            => "Il server deve essere sponsorizzato per fare questo. Se sei un patron, utilizza il comando `sponsorserver`.";

        public string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName)
            => $"In caso di un tris fresh sarà visualizzato {attack} per gli attacchi e {defend} per le difese per {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
            => $"In caso di un attacco tris fresh sarà visualizzato {emoji} per {clanTag} {clanName}";

        public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
            => $"In caso di una difesa tris fresh sarà visualizzato {emoji} per {clanTag} {clanName}";

        public string CommandMustBeRanInACategory
            => "Questo comando deve essere eseguito in una categoria.";

        public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
            => $"Questo comando inizierà a rinominare tutti i canali testuali in questa categoria per {clanTag} {clanName}.  Continuare?";

        public string ChannelsWillBeRenamed
            => "I canali testuali in questa categoria saranno rinominati in caso di nuove guerre o nuovi attacchi. Assicurati che io abbia il permesso di gestire i canali in ogni canale.";

        public string CommandCanceled => "Comando cancellato.";

        public string NowRenamingChannel(string clanTag, string clanName, int position)
            => $"Sto rinominando questo canale per {clanTag} {clanName}, posizione nemica {position}.";

        public string NeedPermissionToManageChannels
            => "Non ho il permesso di gestire i canali.";

        public string NoAttacksLeft(string enemyClanTag, string enemyClanName)
            => $"Non ci sono attacchi rimanenti nella guerra contro {enemyClanTag} {enemyClanName}.";

        public string UpdatedVillages(string clanTag, string clanName, int villageCount)
            => $"Aggiornati {villageCount} villaggi in {clanTag} {clanName}.";

        public string Restrict
            => "Ora ignorerò tutti i comandi da questo canale. Utilizza `restrict false` per annullare. Si consiglia vivamente di modificare i ruoli invece di utilizzare questo comando.";

        public string NotRestricted
            => "Non ignoro più questo canale.";

        public string WarChannelFailed
            => "Questo comando richiede che il server sia sponsorizzato. Se sei un patron, esegui prima il comando sponsorserver. Tu e io dobbiamo avere il permesso di gestire i canali nel server o nel canale, a seconda dei parametri che hai fornito.";

        public string BecomeAPatronToDownloadThis
            => "Diventa un patron per ottenere il file scaricabile! Se sei un patron, assicurati che io abbia il permesso di allegare file in questo canale.";

        public string BecomeAPatronToUseThisCommand
            => "Considera di diventare un patron per utilizzare questo comando!";

        public string IncludeTheLeagueYouWouldLikeToSee
            => "Si prega di includere la lega che si desidera vedere. Usa il comando scoreboard per vedere l'elenco delle leghe.";

        public string WarEndWarningsDisabled
            => "Il ruolo hashits non sarà più menzionato quando verrà annunciata la fine imminente della guerra.";

        public string WarEndWarningsEnabled
            => "Il ruolo hashits ora sarà menzionato quando verrà annunciata la fine imminente della guerra.";

        public string WarStartWarningsDisabled
            => "Il ruolo hashits non sarà più menzionato quando verrà annunciato l'inizio imminente della guerra.";

        public string WarStartWarningsEnabled
            => "Il ruolo hashits ora sarà menzionato quando verrà annunciato l'inizio imminente della guerra.";

        public string IncorrectParametersOrMissingPermission
            => "Hai fornito parametri errati o c'è un permesso mancante.";

        public string CommandNameIsAPlaceHolder
            => "Il nome del comando è un segnaposto. Sostituiscilo con il nome di un comando.";
        public string YouHaveHiddenXAttacks(int count)
            => $"Hai nascosto {count} attacchi.";

        public string YouHaveUnhiddenXAttacks(int count)
            => $"Hai reso visibili {count} attacchi.";

        public string CommandNotFound
            => "Comando non trovato.";

        public string ClanNotFound => "Clan non trovato.";
        public string SearchForClanReturnedNoResults(string clanTag) => $"La ricerca per il clan { clanTag } non ha fornito risultati.";
        public string NotADiscordServer => "Non è un server Discord.";
        public string ServerNotFoundInCache => "Server Discord non trovato nella cache.";
        public string NotAServerMember => "Non è un membro del server.";
        public string MemberNotFound => "Membro non trovato.";
        public string NotAMemberNorSelfTag => "Non è un membro del server né un self tag.";
        public string OrganizationNotFound => "Organizzazione non trovata.";
        public string WarNotFound => "Guerra non trovata.";
        public string NotADate => "Non è una data.";
        public string DivisionNotFound => "Divisione non trovata.";
        public string NotAUrl => "Non è un url valido.";
        public string ValidWarTypes => "War types validi sono farm, arranged, o competitive";
        public string CommandMustBeRanInYourServer => "Questo comando deve essere eseguito nel tuo server.";
        public string CommandMustBeRanInSupportServer => "Questo comando deve essere eseguito nel server di supporto.";
        public string YouMustHavePermissionToManageChannels => "Devi avere il permesso di gestire i canali.";
        public string MbGoesInGame => "Stai usando questo comando in modo sbagliato. \"mb\" non va qui, ma nella descrizione del tuo clan all'interno del gioco.";
        public string YourClanTagDoesNotEndInAPeriod => "Il tag del tuo clan non termina con un punto. Riprova senza il punto.";
        public string RoleGranted => "Il ruolo è stato assegnato.";
        public string RoleRevoked => "Il ruolo è stato rimosso.";
    }
}