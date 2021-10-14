namespace MinionBot.Languages.Italian
{
    public class HelpMenu : IHelpMenu
    {
        public string InviteBot => "Sto per aggiungere il bot al tuo server.";
        public string InviteBotDescription => 
@"Non vedi il tuo server? Non hai i permessi di gestire il server.

Se li hai, prova a riavviare Discord.";
        public string BotNotResponding => "Il bot non sta rispondendo?";
        public string BotNotRespondingDescription =>
@"Assicurati che il bot sia presente nella lista di membri del canale nel quale vuoi che funzioni.

Se non è presente, aggiungi il ruolo Minion Bot al tuo canale e assegnagli il permesso di visualizzare i messaggi.

È nella lista di membri ma continua a non rispondere?

Controlla il ruolo nelle Impostazioni del Server.
Assegna `Visualizzare i canali`, `Inviare i messaggi`, `Incorporare i link`, `Leggere la cronologia dei messaggi`, `Usare emoji esterne`, `Aggiungere reazioni`
Continua a non rispondere?  Controlla la categoria del canale interessato e assicurati che abbia i ruoli richiesti.

Se continua ancora a non rispondere, prova ad eseguire i comandi `deleteprefix` e `restrict false`.

Clicca il bottone Ottieni Supporto qui sotto per ulteriori indicazioni.";

        public string IDontUnderstandTheCommands => "Non capisco il comando.";
        public string IDontUnderstandTheCommandsDescription => 
"Per ottenere più informazioni su un comando, esegui `help nomeComando` dove nomeComando è il comando per il quale cerchi aiuto.";
        public string HowDoIClaimMyClan => "Come posso rivendicare il mio clan?";
        public string HowDoIClaimMyClanDescription =>
@"Modifica la descrizione del tuo clan in gioco in modo che finisca con `mb`.
Aspetta un paio di minuti.
Esegui `claimclan #clanTag` dove #clanTag è il tag del TUO clan.
RIMUOVI `mb` dalla descrizione del clan in modo che nessun'altro possa rivendicare il tuo clan.

Il mio registro di guerra deve essere pubblico?  Se vuoi che i tuoi attacchi siano pubblicati, SI!

Posso rivendicare più clan? SI! Ti basta eseguire il comando claimclan in canali diversi.";

        public string WhatDoTheSymbolsMean => "Cosa significano i simboli?";
        public string HelpSettingUpMyServer => "Ho bisogno di aiuto per impostare il mio server.";
        public string HelpSettingUpMyServerDescription => "[Prova questo modello](https://discord.new/mEgxbhkM55vW) o cerca su YouTube.";
        public string WhatAreTheCommands => "Quindi, quali sono i comandi?";
        public string WhatAreTheCommandsDescription =>
@"Esegui `commands` per visualizzare la lista completa.

VISUALIZZA LA GUERRA
`▹  p       fornisce la lista di basi non ancora trissate`
`▹  stats   visualizza le statistiche della guerra attuale`
`▹  gra     visualizza gli attacchi a disposizione del nostro team`
`▹  gla     visualizza gli ultimi 10 attacchi in guerra`

PRENOTA UNA BASE
`▹  c 5                 prenota la base #5 a tuo nome`
`▹  c 5 #tagVillaggio   prenota la base #5 a nome di un villaggio`

CANCELLA LA PRENOTAZIONE
`▹  d 5      cancella la tua prenotazione o la prima prenotazione sulla base #5`
`▹  d 5 2    cancella la seconda prenotazione sulla base #5`

RIVENDICA UN VILLAGGIO
`▹  claim #tagVillaggio`
`▹  claim #tagVillaggio @menzioneDiscord`

ALIAS
`▹  alias #tagVillaggio ilTuoAliasQui`
`▹  prefer ilTuoAliasQui`
`▹  deletealias ilTuoAliasQui`
`Un alias è semplicemente un soprannome. Tienilo breve e facile da digitare.`
`Crea soprannomi per errori di ortografia comuni.`

`I tag dei villaggi spesso possono essere sostituiti da un alias o una @menzioneDiscord.`";

        public string InviteMe => "Invitami";
        public string GetHelp => "Ottieni Supporto";
    }
}
