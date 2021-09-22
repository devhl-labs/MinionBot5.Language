using System;
using System.Collections.Generic;
using System.Text;

namespace MinionBot.Languages.French
{
    public class DebugHelp : IDebugHelp
    {
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
	}
}
