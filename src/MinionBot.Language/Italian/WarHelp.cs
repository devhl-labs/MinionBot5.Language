namespace MinionBot.Languages.Italian
{
    public class WarHelp : IWarHelp
    {
        //war
        public string HelpCallTimer => "Imposta il tempo per cui una prenotazione è valida.";
        public string HelpStackCalls => "Quando abilitato, più villaggi possono prenotare una base nemica allo stesso tempo.";
        public string HelpPrivateWars =>
"Indica a Minion Bot che manterrai privato il tuo registro di guerra. Ciò abiliterà i comandi destinati ai registri di guerra privati, ​​come start e report.";
        public string HelpPublicWars => "Indica a Minion Bot che manterrai pubblico il tuo registro di guerra. La tua prenotazione di guerra sarà gestita automaticamente.";
        public string HelpPrint => "Visualizza i villaggi che sono stati prenotati in questa guerra.";
        public string HelpStart => "Questo comando è per i soli clan che mantengono privato il loro registro di guerra. Utilizzalo per avviare una nuova guerra su Minion Bot.";
        public string HelpReport => "Questo comando è per i soli clan che mantengono privato il loro registro di guerra. Utilizzalo per segnalare l'esito di un attacco.";
        public string HelpCall => "Prenota una base nemica.";
        public string HelpDelete =>
"Elimina una prenotazione da una base nemica. Fornendo solo la posizione del difensore si cancellerà la propria prenotazione dalla base, o la prima prenotazione su quella base.";
        public string HelpNoStats =>
"Gli attacchi non saranno conteggiati né per le statistiche né per le classifiche. Ciò ti consente di avere una guerra divertente in cui i risultati non contano. Per eseguire il comando devi essere un cocapo.";
        public string HelpGetRemainingAttacks =>
"Questo mostrerà chi ha attacchi a disposizione per il tuo clan. Se il villaggio ha una prenotazione, mostrerà anche quella.";
        public string HelpGetLastAttacks => "Visualizza gli ultimi attacchi effettuati.";
        public string HelpGetLastDefenses => "Visualizza le ultime difese effettuate.";
        public string HelpGetWars => "Ottieni una lista di tutte le guerre note di un clan.";
        public string HelpMatchup => "Visualizza un confronto clan-clan della guerra in corso.";
        public string HelpDefenses => "Ottieni un riassunto delle difese rimanenti.";
        public string HelpAnnounceWar => "Pubblica l'annuncio quando una guerra è trovata.";
        public string HelpAttacks => "Mostra il numero di attacchi a disposizione per ogni lato della mappa di guerra.";
        public string HelpRoster => "Visualizza un riassunto dei villaggi in guerra.";
        public string HelpLineup => "Visualizza informazioni dettagliate su ogni villaggio nella guerra attuale.";
    }
}