using System;
using System.Collections.Generic;
using System.Text;

namespace MinionBot.Languages.French
{
	public class PatreonHelp : IPatreonHelp
	{
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
	}
}
