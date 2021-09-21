/*
* Translation provided by RouletabilleDC
*/

namespace MinionBot.Language
{
	public class French : AbstractLanguage, ILanguage
	{
		public string Name => "fr-FR";

		public string Aliases { get; } = "fr-FR,fr,french,:flag_fr:";

		public string ThisLeagueIsInactive
			=> "This league is inactive or in offseason. If that is not correct, please join the support server and ping your league representatives.";

		public string AllRolesCanBeManaged
			=> "All roles can be managed.";

		public string SomeRolesCantBeManaged
			=> "Some roles can't be managed.";

		public string ATimeoutOccured
			=> "A timeout occurred. Please try again.";
		public string CommandNotFound
			=> "Commande pas trouvée.";

		public string VillageIsNoLongerBannedIn(string villageTag, string villageName, string clanTag, string clanName)
			=> $"{villageTag} {villageName} is no longer banned in {clanTag} {clanName}.";

		public string ThisCommandIsNotForBots
			=> "This command does not support bots.";

		public string ThisCommandIsNotAvailableForCwlNorCompetitiveWars
			=> "This command is not available for CWL nor competitive league wars.";

		public string QuotedParametersAreTypedAsShown
			=> "Les paramètres cités sont écrits comme indiqué.";

		public string BracketedParametersAreOptional
			=> "Les paramètres crochetés sont optionnels.";

		public string MustBeRanInGuild
			=> "Cette commande doit être executées dans un serveur.";

		public string ThisCommandIsNotAvailableForCwlNorCompetetiveWars
			=> "Cette commande n'est pas disponible ni pour les CWL ni pour les ligues compétitives.";

		public string MustClaimClan
			=> "Vous devez d'abord enregistrer votre clan en utilisant la commande `claimclan #clanTag`.";

		public string NoStatsEnabled
			=> "Les statistiques ne compteront plus et les attaques dans cette guerre ne seront plus éligibles pour les commandes comme villageleader.";

		public string NoStatsDisabled
			=> "Les statistiques vont maintenant compter et les attaques dans cette guerre seront éligibles pour les commandes comme villageleader.";

		public string NewClanDefault(string clanTag, string clanName)
			=> $"{clanTag} {clanName} est maintenant le clan par défaut pour ce serveur.";

		public string ClanNotClaimed(string clanTag, string clanName)
			=> $"{clanTag} {clanName} n'est pas enregistré sur ce serveur. Commencez avec `claimclan {clanTag}`.";

		public string ClanNotClaimed()
			=> $"Ce serveur n'a aucun de ces clans d'enregistrés.";

		public string NoClansToUnclaim
			=> "Il n'y a aucun clan à désenregistrer.";

		public string ClanUnclaimed(string clanTag, string clanName)
			=> $"Vous avez désenregistré {clanTag} {clanName}.";


		public string ClanUnclaimedFromAllServers(string clanTag, string clanName)
			=> $"Vous avez désenregistré {clanTag} {clanName} de tous les serveurs.";

		public string RegistrantCantBeRemoved(string clanTag, string clanName)
			=> $"{clanTag} {clanName} ne peut être retiré. Soyez sûrs que toutes les guerres sont retirées d'abord, puis réessayez.";

		public string ClaimClan
			=> "Ajoutez les lettres mb à la fin de la description du clan. Attendez quelques minutes puis tapez claimclan #clanTag.\nmb n'est uniquement nécessaire pour la sécurité et peut être retiré après l'enregistrement du clan.";

		public string ThisVillageIsClaimed
			=> "Ce village est enregistré. Demandez à un adjoint de désenregistrer le clan pour vous.";

		public string NoVillagesClaimed
			=> "Vous n'avez aucun message d'enregistré. Utilisez `claim #villageTag` pour enregistrer votre village.";

		public string YouAlreadyHaveThisVillageClaimed
			=> "Vous avez déjà enregistré ce village.";

		public string YouHaveClaimed(string villageTag, string villageName)
			=> $"Vous avez enregistré {villageTag} {villageName}";

		public string AlreadyHasThisVillageClaimed(string userName)
			=> $"{userName} a déjà ce village d'enregistré.";

		public string InvalidTag => "Invalid Tag";

		public string YouDontHaveAnyVillagesClaimed
			=> "Vous n'avez aucun village d'enregistrés.";

		public string VillageNotFound()
			=> "Village non trouvé.";

		public string VillageNotFound(string tag, string clanName, string input)
			=> $"No village was found in {tag} {clanName} with a tag or name of {input}.";

		public string YourClanCouldNotBeDetermined
			=> "Votre clan n'a pas pu être déterminé.";

		public string YouMustBeACoLeaderToUnclaimAVillage
			=> "Vous devez être un adjoint or avoir la permission de gérer les salons pour désenregistrer un village.";

		public string ThisVillageIsNotClaimedYet
			=> "Ce village n'a pas encore été enregistré.";

		public string ThisAliasIsInUse(string clanTag, string clanName)
			=> $"Cet alias est déjà utilisé dans {clanTag} {clanName}.";

		public string YourAliasIsNow(string villageTag, string villageName, string alias)
			=> $"{villageTag} {villageName} a maintenant `{alias}` comme alias. Utilisez `prefer {alias}` pour en faire l'alias préféré.";

		public string AliasNotFound(string alias, string villageTag, string villageName)
			=> $"L'alias `{alias}` n'a pas été trouvé pour {villageTag} {villageName}.";

		public string IsNowThePreferredAlias(string alias, string villageTag, string villageName)
			=> $"{alias} est maintenant l'alias préféré pour {villageTag} {villageName}.";

		public string AliasesMayNotContainSomeCharacters
			=> "Un alias ne peut pas contenir d'@ ou de symbols contenants #.";

		public string ThereAreNoResults
			=> "Il n'y a pas de résultats.";

		public string CallTimerMustBeBetween
			=> "Le temps de réservation doit être entre 0 et 24 heures.";

		public string WarSizeMustBeDivisibleBy5AndLessThan50
			=> "La taille de guerre doit être divisible par 5 et moins que par 50.";

		public string DefenderPositionMustBeBetween1And50
			=> "Defender position must be between 1 and 50";

		public string StarsMustBeBetween1And3
			=> "Les étoiles doivent être entre -1 et 3.";

		public string ThereIsAlreadyACallOnThisBase
			=> "Il y a déjà une réservation pour cette base et les réservations multiples sur une base sont désactivés.";

		public string ClanIsNotInWar(string clanTag, string clanName)
			=> $"{clanTag} {clanName} n'est pas en guerre.";

		public string ThisCommandMustBeRanInAServer
			=> "Cette commande doit être utilisée dans un serveur.";

		public string WarLogIsPrivate(string clanTag, string clanName)
			=> $"Le journal de guerre pour {clanTag} {clanName} est privé.";

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
			=> "Ligue non trouvée";

		public string NoLeagueWarsFoundInLastSixDays(string leagueInitials) =>
			$"Cette ligue n'a pas eu de guerre ces 6 derniers jours. Ce cela s'avère faux, tagguez votre représentant de la ligue sur le serveur support. Si votre guerre est une guerre de ligue, utilisez la commande `requestLeague {leagueInitials}.";

		public string SeeAWarThatIsMissing(string leagueInitials) =>
			$"```Vous voyez une guerre qui manque? Si c'est votre guerre, utilisez la commande requestleague {leagueInitials}. Autrement, vous pouvez rejoindre le serveur support et tagguer le représentant de votre ligue. Vous voulez aider à mettre à jouer cette ligue? Rejoignez le serveur support et obtenez le role.```";

		public string OnlyMembersOfThisClanCanSeeThis(string clanTag, string clanName)
			=> $" Uniquement les membres de {clanTag} {clanName} peuvent voir ceci.";

		public string ThisWarIsAlreadyInALeague
			=> "Cette guerre est déjà dans une ligue.";

		public string YourRequestIsPendingApproval
			=> "Votre requête est en attente d'approbation.";

		public string NoParticipatingClanFound(string dbParticipantName, string leagueInitials, int season)
			=> $"Aucun clan participant avec le nom  {dbParticipantName} n'a été trouvé  dans {leagueInitials} en saison {season}.";

		public string NoParticipants(string leagueInitials, int season)
			=> $"There are no clans in {leagueInitials} season {season}.";

		public string ThisLeagueHasNoDivisions
			=> "Cette ligue n'a aucune divisions.";

		public string YouHaveClaimedXAttacks(int count, string tag, string name)
			=> $"Vous avez enregistré{count} attaques pour{tag} {name}.";

		public string YouAndThisBotMustHavePermissionToManageRoles
			=> "Vous et ce bot devez avoir la permission de gérer les rôles pour utiliser cette commande.";

		public string RolesWillNoLongerBeUpdated
			=> "Les rôles ne seront plus mis à jour.";

		public string RolesWillBeUpdated(int roles)
			=> $"Les rôles {roles} seront automatiquement attribués.";

		public string DeletedXRoles(int count)
			=> $" Ont été retirés {count} rôles.";

		public string CreatedXRoles(int count)
			=> $"Ont été créés  {count} rôles.";

		public string CreatedXRoles(string clanTag, string clanName, int count)
			=> $"Ont été créés {count} rôles pour {clanTag} {clanName}.";

		public string CreatedXRoles(int count, int errors)
			=> $"Ont été créés {count} rôles. {errors} rôles n'ont pas pu être créés à cause de la limite des serveurs ou du taux limite.";

		public string ThisVillageHasNoBans(string villageTag, string villageName)
			=> $"{villageTag} {villageName} n'est banni dans aucun clan.";

		public string ThisVillageHasNoBans(string villageTag, string villageName, string clanTag, string clanName)
			=> $"Le ban de {villageTag} {villageName} du clan {clanTag} {clanName} a été retiré.";

		public string ThisClanHasNoBans(string clanTag, string clanName)
			=> $"{clanTag} {clanName} n'a aucun ban.";

		public string ThisOrgHasNoBans
			=> "Cette organisation n'a aucun ban.";

		public string ThisVillageHasNoOrgBans(string villageTag, string villageName)
			=> $"{villageTag} {villageName} n'a aucun ban d'organisations.";

		public string PleaseTryAgainAndProvideAReasonForTheBan
			=> "Veuillez réessayer en précisant une raison pour le ban.";

		public string ClanDescriptionMustEndWithMB
			=> "Pour enregistrer votre clan, la description doit se terminer par  `mb`. This is only for security and may be removed later.";

		public string YourLanguageHasBeenChangedTo(string language)
			=> $" Votre langue a été changée en {language}.";

		public string IDontKnowThatLanguage
			=> " Je ne connais pas ce language. Si vous voulez l'ajouter, veuillez regarder https://github.com/devhl-labs/MinionBot5.Language.";

		public string PrefixRules
			=> "Un préfixe peut contenir 5 caractères ou moins et ne peut contenir d'#, d'@ ou d'espace.";

		public string PrefixDefinition
			=> "Un préfixe est un caractère qui va au début des commandes comme  !, $, *, etc.  Cela m'indique si vous me parlez. Pour personnaliser un présixe, utilisez `setprefix !`. Le ! peut aussi être un autre caractère.";

		public string UseDeletePrefixToUndoThis(string userMention, string prefix)
			=> $"{userMention} Vous avez créé un préfixe. Toutes les commandes doivent maintenant commencer avec `{prefix}`. Utilisez `deleteprefix` pour annuler.";

		public string YouMustHavePermissionToManageGuild
			=> "Vous devez avoir la permission de gérer la guilde.";

		public string ThisChannelHasNoClanClaimed
			=> "Ce salon n'a pas de clan d'enregistré.";

		public string InvalidTownHallLevel
			=> "Vous avez indiqué un niveau d'Hôtel de Ville invalide.";

		public string MustBeAGoldPatron
			=> "Vous devez être un patron or ou supérieur.";

		public string MustBeACrystalPatron
			=> "Vous devez être un patron cristal ou supérieur.";

		public string MustBeAMasterPatron
			=> "Vous devez être un patron master ou supérieur.";

		public string AlreadySponsored
			=> "Vous sponsorisez déjà ce serveur.";

		public string SponsoringServer(ulong id, string name)
			=> $" Vous sponsorisez {id} {name}.";

		public string NotSponsoringAnyServers
			=> "Vous ne sponsorisez aucun serveur.";

		public string ServerMustBeSponsored
			=> " Ce serveur doit être sponsorisé pour effectuer ceci. Si vous êtes un patron, utilisez la commande `sponsorserver`.";

		public string ServerWillNowUseEmojis(string attack, string defend, string clanTag, string clanName)
			=> $"Les 3 étoiles en one shot vont maintenant afficher {attack} pour les attaques et {defend} pour les défenses pour {clanTag} {clanName}";

		public string ServerWillNowUseEmojiForAttacks(string emoji, string clanTag, string clanName)
			=> $" Les 3 étoiles en one shot vont maintenant afficher {emoji} pour {clanTag} {clanName}";

		public string ServerWillNowUseEmojiForDefenses(string emoji, string clanTag, string clanName)
			=> $"Fresh 3 star defenses will now display {emoji} for {clanTag} {clanName}";

		public string CommandMustBeRanInACategory { get; } = "Cette commande doit être utilisée dans une catégorie.";

		public string ThisCommandWillRenameAllChannels(string clanTag, string clanName)
			=> $"Cette commande commencera à renommer tous les salons textuels dans cette catégorie pour {clanTag} {clanName}.  Continuer?";

		public string ChannelsWillBeRenamed { get; }
			= "Les salons textuels dans cette catégorie vont être renommés en nouvelles guerres ou nouvelles attaques. Soyez sûr que j'ai la permission de gérer le salon dans chaque salon.";

		public string CommandCanceled { get; } = "Commande annulée.";

		public string NowRenamingChannel(string clanTag, string clanName, int position)
			=> $" Je renomme ce salon pour {clanTag} {clanName}, position ennemie {position}.";

		public string NeedPermissionToManageChannels
			=> "Je n'ai pas la permission de gérer les salons.";

		public string NoAttacksLeft(string enemyClanTag, string enemyClanName)
			=> $" Il n'y a aucun attaque restante pour la guerre contre {enemyClanTag} {enemyClanName}.";

		public string UpdatedVillages(string clanTag, string clanName, int villageCount)
			=> $" Mis à jour {villageCount} villages dans {clanTag} {clanName}.";

		public string Restrict
			=> "J'ignore désormais toutes les commandes de ce salon. Utilisez `restrict false` pour annuler. C'est fortement recommandé que vous modifiez les rôles au lieu d'utiliser cette commande.";

		public string NotRestricted
			=> "Je n'ignore désormais plus ce salon.";

		public string WarChannelFailed
			=> "Cette commande requiert ce serveur d'être sponsorisé. Si vous êtes un patron, utilisez la commande `sponsorserver`. Vous et moi devons avoir la permission de gérer les salons dans la guilde ou le salon; cela dépend des paramètres que vous avez fourni.";

		public string BecomeAPatronToDownloadThis
			=> "Devenez un patron pour obtenir de ceci un lien téléchargeable! Si vous êtes un patron, soyez sûr que j'ai la permission d'envoyer des dossiers dans ce salon.";

		public string BecomeAPatronToUseThisCommand
			=> "Considérez à devenir un patron pour utiliser cette commande!";

		public string IncludeTheLeagueYouWouldLikeToSee
			=> "Veuillez inclure la ligue que vous voulez voir. Utilisez la commande scoreboard pour voir la list des ligues.";

		public string WarEndWarningsDisabled
			=> "Le role hashits ne sera plus mentionné quand “la guerre se termine bientôt“ sera annoncé.";

		public string WarEndWarningsEnabled
			=> "Le role hashits sera mentionné quand “la guerre se termine bientôt“ sera annoncé.";

		public string WarStartWarningsDisabled
			=> "Le role hashits ne recevra plus de mention quand “la guerre se termine bientôt'' sera annoncé.";

		public string WarStartWarningsEnabled
			=> "Le role hashits sera mentionné quand “la guerre se termine bientôt'' sera annoncé.";

		public string IncorrectParametersOrMissingPermission
			=> "Vous avez fourni de mauvais paramètres ou il y a une permission manquante.";

		public string CommandNameIsAPlaceHolder
			=> "Le nom de la commande est un espace réservé. Remplacez le par le nom d'une commande";

		public string YouHaveHiddenXAttacks(int count)
			=> $"Vous avez caché {count} attaques.";

		public string YouHaveUnhiddenXAttacks(int count)
			=> $"You have unhidden {count} attacks.";



		public string HelpClaimClan => new English().HelpClaimClan;
		public string HelpInvite => "Fournit un lien du serveur support et le lien d'invitation de Minion Bot.";
		public string HelpForTwitch => "Fournit un link pour une version pour les streamers de Minion Bot. C'est un programme que vous utilisez sur votre ordinateur. Cela mettra à jour votre overlay pour vous.";
		public string HelpSetupVideo => "Fournit un lien pour le tutoriel pour l'installation du bot.";
		public string HelpCommands => "Obtenez une liste de toutes les commandes.";
		public string HelpInfo => "Obtenez les informations basiques à propos de Minion Bot.";
		public string HelpApi => "Voir les temps de réponse de l'api.";
		public string HelpFetchClanWarLog => "Récupérer les informations sur un journal de guerre directement à partir de l'api.";
		public string HelpFetchLeagueWar => "Récupérer les informations sur une guerre de SCCWL directement à partir de l'api.";
		public string HelpFetchLeagueGroup => "Récupérer les informations sur un groupe de ligue directement à partir de l'api.";
		public string HelpFetchPlayer => "Retrouvez les informations sur un joueur directement à partir de l'api.";
		public string HelpFetchCurrentWar => "Retrouvez la guerre actuelle directement à partir de l'api.";
		public string HelpFetchClans => "Recherchez un clan par son nom dans l'api";
		public string HelpFetchClan => "Récupérer des informations sur un clan directement à partir de l'api.";
		public string HelpPermissions => "Inspecter les permissions données pour un membre.";
		public string HelpPing => "Inspecter la latence avec Discord.";
		public string HelpRemoveAllWars => new English().HelpRemoveAllWars;
		public string HelpRemoveAllClans => new English().HelpRemoveAllClans;
		public string HelpDeleteMatch => new English().HelpDeleteMatch;
		public string HelpSetMatch => new English().HelpSetMatch;
		public string HelpUndo => new English().HelpUndo;
		public string HelpLog => new English().HelpLog;
		public string HelpShowPrivateWars => new English().HelpShowPrivateWars;
		public string HelpLeagueWinner => new English().HelpLeagueWinner;
		public string HelpChangePercent => new English().HelpChangePercent;
		public string HelpChangeStars => new English().HelpChangeStars;
		public string HelpChangeWinner => new English().HelpChangeWinner;
		public string HelpOrgUnban => new English().HelpOrgUnban;
		public string HelpOrgBan => new English().HelpOrgBan;
		public string HelpRemoveWar => new English().HelpRemoveWar;
		public string HelpAddWar => new English().HelpAddWar;
		public string HelpImport => new English().HelpImport;
		public string HelpUnshell => new English().HelpUnshell;
		public string HelpShell => new English().HelpShell;
		public string HelpRemoveClan => new English().HelpRemoveClan;
		public string HelpAddClan => new English().HelpAddClan;
		public string HelpLeagueRep => new English().HelpLeagueRep;
		public string HelpGetOrgBans => new English().HelpGetOrgBans;
		public string HelpRequestLeague => new English().HelpRequestLeague;
		public string HelpInspect => new English().HelpInspect;
		public string HelpCreateLeague => new English().HelpCreateLeague;
		public string HelpChangeLeague => new English().HelpChangeLeague;
		public string HelpChangeClan => new English().HelpChangeClan;
		public string HelpChangeOrg => new English().HelpChangeOrg;
		public string HelpChange => new English().HelpChange;
		public string HelpCreateOrg => new English().HelpCreateOrg;
		public string HelpValidate => new English().HelpValidate;
		public string HelpScoreboard => "Voir le classement pour une liguez.";
		public string HelpDivisions => "Voir les divisions dans une ligue donnée.";
		public string HelpPatreon => "Montrez votre amour pour Minion Bot! Obtenez un rôle sur le serveur support avec quelques avantages.";
		public string HelpHideAttacks => 
@"Cela permettra de dissimuler toute attaque que vous avez réservée. Vous devez être un master patron pour utiliser cettecommande. Vos attaques sont réservées en ayant réclamé le village au moment de l'attaque ou par le biais de la commande claimattacks.";
		public string HelpFreshDefense => "Les serveurs sponsorisés peuvent l'utiliser pour contrôler quel émoji est affiché pour une nouvelle défense one shot.";
		public string HelpFreshAttack => "Les serveurs sponsorisés peuvent l'utiliser pour contrôler quel émoji est affiché pour une nouvelle attaque one shot.";
		public string HelpFreshEmote => "Les serveurs sponsorisés peuvent l'utiliser pour contrôler quel émoji est affiché pour une nouvelle attaque ou défense trois étoiles.";
		public string HelpMySponsorShip => "Voir tous les serveurs que vous sponsorisez.";
		public string HelpUnsponsorServer => "Arrêter de sponsoriser un serveur. Vous pouvez obtenir l'ID du serveur via `mysponsorships`.";
		public string HelpSponsorServer => "Voir les serveurs que vous sponsorisez actuellement.";
		public string HelpWarChannel => "Cette commande renommera un salon pour refléter le nombre d'étoiles sur une base ennemie. Vous devez avoir la permission de gérer le salon.";
		public string HelpDownloadAttacks => "Téléchargez un fichier contenant vos attaques.";
		public string HelpVillageLeagueLeader =>
@"Ceci montrera les meilleurs attaquants et défenseurs dans une ligue.
Le nombre de mois limitera les attaques aux X derniers mois.
La saison sera par défaut la saison en cours.
Pour toutes les saisons, entrez 0.
Le type one shot peut être one shot ou repassé.";
		public string HelpVillageLeader => 
@"Ceci indiquera votre rang au sein de votre clan.
Le nombre de mois limitera les attaques aux X derniers mois.
La saison sera par défaut la saison en cours.
Pour toutes les saisons, entrez 0.
Le type de guerre peut être farm, arrangée, compétitive ou SCCWL.
Le type one shot peut être one shot ou repassé.
Le paramètre de clan exclura les attaques que vos coéquipiers de clans ont faites pendant qu'ils étaient dans d'autres clans.";
		public string HelpCwlStats => "Ceci montrera les statistiques actuelles pour tous les clans dans votre actuelle ligue SCCWL.";
		public string HelpStats =>
@"Voir les statistiques pour la guerre actuelle, un village ou un utilisateur de Discord.
Le nombre de mois limitera les attaques aux X derniers mois.
La saison sera par défaut la saison en cours.
Pour toutes les saisons, entrez 0.
Le type de guerre peut être farm, arrangée, compétitive ou SCCWL.
Le type one shot peut être one shot ou repassé.
Le paramètre de clan exclura les attaques que vos équipiers de clans ont faites pendant qu'ils étaient dans d'autres clans.
Les ID de guerres peuvent être trouvés en utilisant la commande getwars.";
		public string HelpLeagueLeader =>
@"Ceci montrera la ligue avec le meilleur taux de réussite.
This will show the league with the best hit rate.
Fresh type can be fresh or cleanup.";
		public string HelpClanStats => 
@"Obtenez les statistiques de l'historique complet des attaques d'un clan.
Cela ressemblera aux statistiques d'un village, mais cela montrera l'ensemble du clan.
Cela vous permet d'entrer le tag d'un autre clan pour comparer les clans.
La saison sera par défaut la saison en cours.
Pour toutes les saisons, entrez 0.
Le type de guerre peut être farm, arrangée, compétitive ou SCCWL.";
		public string HelpClanLeagueLeader => 
@"Cela montrera quel clan a le meilleur taux de réussite dans une ligue.
La saison sera par défaut la saison en cours.
Pour toutes les saisons, entrez 0.
Le type one shot peut être one shot ou repassé.";
		public string HelpBotLeader => 
@"Obtenez les meilleurs attaquants ou défenseurs dans l'ensemble du bot.
Cela permettra d'obtenir les meilleurs taux de réussite pour tous les villages, quel que soit le clan.
Le type de guerre peut être farm, arrangée, compétitive ou SCCWL.
Le type one shot peut être one shot ou repassé.";
		public string HelpLeagueStats => "Montrer les statistiques pour cette semaine de guerres de clans.";
		public string HelpLineup => "Voir les informations détaillées sur chaque village dans la guerre actuelle.";
		public string HelpRoster => "Voir un résumé des villages dans une guerre donnée.";
		public string HelpAttacks => "Montrer le nombre d'attaques restantes pour chaque côté de la carte de guerre.";
		public string HelpAnnounceWar => "Imprimer l'annonce lorsqu'une guerre est trouvée.";
		public string HelpDefenses => "Obtenez un résumé des défenses restantes.";
		public string HelpMatchup => "Voir une comparaison clan par clan de la guerre actuelle.";
		public string HelpGetWars => "Obtenez une liste de toutes les guerres connues pour un clan.";
		public string HelpGetLastDefenses => "Voir les dernières défenses.";
		public string HelpGetLastAttacks => "Voir les dernières attaques.";
		public string HelpGetRemainingAttacks => "Cela montrera les attaques restantes pour votre clan. Cela montrera aussi si le village a une réservation.";
		public string HelpNoStats => "Les attaques ne seront pas prises en compte dans les statistiques ni dans les classements si vous faites cela. Cela vous permet de mener une guerre amusante où les résultats n'ont pas d'importance. Vous devez être chef-adjoint pour le faire.";
		public string HelpDelete => "Supprimer une réservation sur une base ennemie. Fournir uniquement la position ennemie supprimera votre propre ou la première réservation sur la base.";
		public string HelpCall => "Réserver une base ennemie donnée.";
		public string HelpReport => "Cette commande est uniquement pour les clans qui gardent leur journal de guerre privé. Utilisez la commande pour signaler le résultat d'une attaque.";
		public string HelpStart => "Cette commande est uniquement pour les clans qui gardent leur journal de guerre privé. Utilisez la commande pour commencer une nouvelle guerre dans Minion Bot.";
		public string HelpPrint => "Voir les villages qui sont réservés dans cette guerre.";
		public string HelpPublicWars => "Dites à Minion Bot que vous allez garder le journal de guerre ouvert. Votre réservation de guerre sera directement pris en charge.";
		public string HelpPrivateWars => "Dites à Minion Bot que vous allez garder le journal de guerre fermé. Cela permettra des commandes destinées aux journaux de guerre privés telles que \"start\" et \"report\"";
		public string HelpStackCalls => "Quand c'est activé, plusieurs villages peuvent réserver une base ennemie en même temps.";
		public string HelpCallTimer => "Mettez en place la durée d'une réservation.";

		public string HelpSuperTroops => new English().HelpSuperTroops;
		public string HelpClaimAttacks => 
@"Ceci va enregistrer toutes les attaques pré?édemment non enregitrées.
Ceci inclut les attaques et défenses faites avant que vous n'enregistriez le village.
**?ette action est irréversible.**";
		public string HelpUpdateMembers => "Mettre à hour les rôles et les niveaux d'héros pour tous les villages dans votre clan.";
		public string HelpUnclaim => "Dissociez un village d'un utilisateur de Discord.";

		public string HelpSearch => 
@"Utilisez ceci pour voir quels villages sont dans votre clan.
Utilisez ceci aussi pour avoir rapidement les tags des villages de vos coéquipiers de clan.
Fournissez une chaîne de recherche pour limiter les résultats.";
		public string HelpPrefer => 
@"Minion Bot essayera d'utiliser le préfixe préféré au-dessus des autres alias.
Vous pouvez avoir uniquement un alias préféré à la fois.
Les alias doivent être uniques, vous devez fournir à cette commande le nom de l'alias.";
		public string HelpMyBase => "Voir les informations d'une base donnée.";
		public string HelpLookup => "Rechercher des informations diverses à propos d'un village.";
		public string HelpMembers => "Voir tous les membres qui sont actuellement dans votre clan.";
		public string HelpGetUnclaimed => "Voir tous les villages non enregistrés.";
		public string HelpGetClaims => "Fournit une vue d'ensemble de tous les villages non enregistrés.";
		public string HelpGetBans => "Voir tous les bans pour votre clan ou un village donné.";
		public string HelpGetAlias => "Voir tous les pseudonymes pour un village.";
		public string HelpDeleteAlias => 
@"Utilisez ceci pour supprimer un ancien alias.
Utile surtout après que vous changez le nom d'un village dans le jeu.
Les alias doivent être uniques, vous devez fournir à cette commande le nom de l'alias.";
		public string HelpClaim =>
@"Dites au bot qui est le propriétaire du village.
Utilisez une @MentionDiscord pour aider votre équipier de clan à enregistrer leur village.
Si vous avez un problème à utiliser le nom du village, essayez d'utiliser le tag du village.";
		public string HelpUnBanVillage => "Débannez un village de votre clan.";
		public string HelpBanVillage => "Bannez un village de votre clan.";
		public string HelpAlias => "Donnez un pseudonyme au village. Gardez le court et facile à écrire.";
		public string HelpDeletePrefix => "Cette commande supprimera votre préfixe";
		public string HelpSetPrefix =>
@"Par défaut Minion Bot n'a pas de préfixe.
Assignez en un de votre choix avec cette commande.
Une fois assigné, les commandes requerrons le préfixe.
Si votre préfixe est !, la commande d'aide sera !help.
Utilisez deleteprefix pour annuler.";

		public string HelpSetLanguage => new English().HelpSetLanguage;
		public string HelpStartWarning => new English().HelpStartWarning;
		public string HelpEndWarning => new English().HelpEndWarning;
		public string HelpPostGreetings => new English().HelpPostGreetings;
		public string HelpPostDonations => new English().HelpPostDonations;
		public string HelpPostHits => new English().HelpPostHits;
		public string HelpRestrict => new English().HelpRestrict;
		public string HelpAddRoles => new English().HelpAddRoles;
		public string HelpDeleteRoles => new English().HelpDeleteRoles;
		public string HelpMyChannels => new English().HelpMyChannels;
		public string HelpMyChannel => new English().HelpMyChannel;
		public string HelpMyRoles => new English().HelpMyRoles;
		public string HelpMyClan => new English().HelpMyClan;
		public string HelpMyServer => new English().HelpMyServer;
		public string HelpMyClans => new English().HelpMyClans;
		public string HelpDefaultClan => new English().HelpDefaultClan;
		public string HelpUnclaimClan => new English().HelpUnclaimClan;
	}
}
