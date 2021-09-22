namespace MinionBot.Languages.French
{
	public class WarHelp : IWarHelp
	{
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
	}
}
