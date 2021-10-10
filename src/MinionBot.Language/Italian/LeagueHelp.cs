namespace MinionBot.Languages.Italian
{
    public class LeagueHelp : ILeagueHelp
    {
        public string HelpOrgClanBan => "Banna un clan da un'organizzazione.";
        public string HelpUnOrgClanBan => "Rimuovi il ban a un clan da un'organizzazione.";
        public string HelpLeaugeViewer => "Aggiunge o rimuove un ruolo per vedere i canali delle leghe.";
        public string HelpEditWar => "Modifica il risultato di una guerra. Apparirà nel tabellone, ma non nel comando stats.";
        public string HelpDivisions => "Visualizza le divisioni di una determinata lega.";
        public string HelpScoreboard => "Visualizza il tabellone di una lega.";
        public string HelpValidate => "Controlla un determinato clan per vedere se qualche membro è bannato da qualche lega competitiva.";
        public string HelpCreateOrg => "Crea un'organizzazione.";
        public string HelpChange => "Aggiungi un parametro per saperne di più.";
        public string HelpChangeOrg => "Modifica un'organizzazione.";
        public string HelpChangeClan => "Modifica un clan registrato.";
        public string HelpChangeLeague => "Modifica una lega.";
        public string HelpCreateLeague => "Crea una lega.";
        public string HelpInspect => "Visualizza informazioni su un oggetto.";
        public string HelpRequestLeague =>
@"Se la guerra attuale è una guerra di lega, esegui questo comando per richiedere di contrassegnarla come tale.
La tua richiesta sarà inviata al server di supporto.
Un rappresentante della lega dovrà approvarla.";
        public string HelpGetOrgBans => "Visualizza tutti i ban per un'organizzazione.";
        public string HelpLeagueRep => "Visualizza tutti i rappresentanti della lega o assegna la rappresentanza a un membro.";
        public string HelpAddClan => "Aggiungi clan a una lega.";
        public string HelpRemoveClan => "Rimuovi clan da una lega.";
        public string HelpShell => "Aggiungi un clan registrato sotto a uno partecipante.";
        public string HelpUnshell => "Rimuovi un clan registrato dal rispettivo partecipante.";
        public string HelpImport => "Importa i tag dei clan da un url war match.";
        public string HelpAddWar => "Aggiungi una guerra alla lega. Se specifichi i tag dei clan potresti voler aggiornare le stelle e la percentuale successivamente.";
        public string HelpRemoveWar => "Rimuovi una guerra dalla lega.";
        public string HelpOrgBan =>
"Banna villaggi da un'organizzazione. Riceverai una notifica se il villaggio si unisce a un clan registrato o partecipa a una guerra con un clan registrato.";
        public string HelpOrgUnban => "Revoca i ban ai villaggi dalla tua organizzazione.";
        public string HelpChangeWinner => "Cambia il vincitore di una guerra di lega. Apparirà nel tabellone, ma non nel comando stats.";
        public string HelpChangeStars => "Cambia le stelle di una guerra di lega. Apparirà nel tabellone, ma non nel comando stats.";
        public string HelpChangePercent => "Cambia la percentuale di una guerra di lega. Apparirà nel tabellone, ma non nel comando stats.";
        public string HelpLeagueWinner => "Dichiara il vincitore della lega.";
        public string HelpShowPrivateWars => "Visualizza tutti i clan in questa lega per i quali il registro di guerra è privato.";
        public string HelpLog => "Inserisci manualmente un attacco. Puoi ottenere le posizioni in mappa dal comando roster.";
        public string HelpUndo => "Cancella un attacco aggiunto manualmente.";
        public string HelpSetMatch =>
"Programma una data di incontro per due clan partecipanti. La data è in UTC. Quando i due clan si incontrano in questo giorno (o nei successivi sette giorni), il match verrà automaticamente approvato. Usa `deletematch` per annullare questa operazione.";
        public string HelpDeleteMatch => "Rimuovi uno o più match programmati.";
        public string HelpRemoveAllClans => "Rimuovi tutti i clan dalla lega.";
        public string HelpRemoveAllWars => "Rimuovi tutte le guerre dalla lega.";
    }
}