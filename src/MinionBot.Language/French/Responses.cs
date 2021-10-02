/*
* Translation provided by RouletabilleDC
*/

namespace MinionBot.Languages.French
{
	public class Responses : AbstractLanguage, ILanguage
	{
		public string Name => "fr-FR";

		public string Aliases { get; } = "fr-FR,fr,french,:flag_fr:";


		public IManagementHelp ManagementHelp { get; } = new ManagementHelp();
		public IAboutHelp AboutHelp { get; } = new AboutHelp();
		public IDebugHelp DebugHelp { get; } = new DebugHelp();
		public ILeagueHelp LeagueHelp { get; } = new LeagueHelp();
		public IVillageHelp VillageHelp { get; } = new VillageHelp();
		public IPatreonHelp PatreonHelp { get; } = new PatreonHelp();
		public IWarHelp WarHelp { get; } = new WarHelp();
		public IStatsHelp StatsHelp { get; } = new StatsHelp();
		public IBot Bot { get; } = new Bot();


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
	}
}
