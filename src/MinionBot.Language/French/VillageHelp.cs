namespace MinionBot.Languages.French
{
	public class VillageHelp : IVillageHelp
	{
		public string HelpUnBanVillage => "Débannez un village de votre clan.";
		public string HelpBanVillage => "Bannez un village de votre clan.";
		public string HelpAlias => "Donnez un pseudonyme au village. Gardez le court et facile à écrire.";
		public string HelpClaim =>
@"Dites au bot qui est le propriétaire du village.
Utilisez une @MentionDiscord pour aider votre équipier de clan à enregistrer leur village.
Si vous avez un problème à utiliser le nom du village, essayez d'utiliser le tag du village.";
		public string HelpSuperTroops => new English.VillageHelp().HelpSuperTroops;
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

	}
}
