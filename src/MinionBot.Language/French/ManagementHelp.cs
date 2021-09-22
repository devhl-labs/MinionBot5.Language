using System;
using System.Collections.Generic;
using System.Text;

namespace MinionBot.Languages.French
{
	public class ManagementHelp : IManagementHelp
	{
		public string HelpDeletePrefix => "Cette commande supprimera votre préfixe";
		public string HelpSetPrefix =>
@"Par défaut Minion Bot n'a pas de préfixe.
Assignez en un de votre choix avec cette commande.
Une fois assigné, les commandes requerrons le préfixe.
Si votre préfixe est !, la commande d'aide sera !help.
Utilisez deleteprefix pour annuler.";

		public string HelpSetLanguage => new English.ManagementHelp().HelpSetLanguage;
		public string HelpStartWarning => new English.ManagementHelp().HelpStartWarning;
		public string HelpEndWarning => new English.ManagementHelp().HelpEndWarning;
		public string HelpPostGreetings => new English.ManagementHelp().HelpPostGreetings;
		public string HelpPostDonations => new English.ManagementHelp().HelpPostDonations;
		public string HelpPostHits => new English.ManagementHelp().HelpPostHits;
		public string HelpRestrict => new English.ManagementHelp().HelpRestrict;
		public string HelpAddRoles => new English.ManagementHelp().HelpAddRoles;
		public string HelpDeleteRoles => new English.ManagementHelp().HelpDeleteRoles;
		public string HelpMyChannels => new English.ManagementHelp().HelpMyChannels;
		public string HelpMyChannel => new English.ManagementHelp().HelpMyChannel;
		public string HelpMyRoles => new English.ManagementHelp().HelpMyRoles;
		public string HelpMyClan => new English.ManagementHelp().HelpMyClan;
		public string HelpMyServer => new English.ManagementHelp().HelpMyServer;
		public string HelpMyClans => new English.ManagementHelp().HelpMyClans;
		public string HelpDefaultClan => new English.ManagementHelp().HelpDefaultClan;
		public string HelpUnclaimClan => new English.ManagementHelp().HelpUnclaimClan;
		public string HelpClaimClan => new English.ManagementHelp().HelpClaimClan;
	}
}
