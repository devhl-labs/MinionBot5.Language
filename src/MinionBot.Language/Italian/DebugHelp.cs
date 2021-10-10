namespace MinionBot.Languages.Italian
{
    public class DebugHelp : IDebugHelp
    {
        public string HelpPing => "Controlla la latenza.";
        public string HelpPermissions => "Recupera i permessi concessi a un utente.";
        public string HelpFetchClan => "Recupera informazioni su un clan direttamente dalle api.";
        public string HelpFetchClans => "Cerca un clan per nome dalle api.";
        public string HelpFetchCurrentWar => "Recupera la war attuale direttamente dalle api.";
        public string HelpFetchPlayer => "Recupera informazioni su un giocatore direttamente dalle api.";
        public string HelpFetchLeagueGroup => "Recupera informazioni su un gruppo di lega direttamente dalle api.";
        public string HelpFetchLeagueWar => "Recupera informazioni su una guerra SC CWL direttamente dalle api.";
        public string HelpFetchClanWarLog => "Recupera informazioni su un registro di guerra direttamente dalle api.";
        public string HelpApi => "Visualizza il tempo di risposta delle api.";
    }
}