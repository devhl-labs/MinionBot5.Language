namespace MinionBot.Languages.French
{
	public class StatsHelp : IStatsHelp
	{
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
	}
}
