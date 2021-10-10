namespace MinionBot.Languages.Italian
{
    public class ManagementHelp : IManagementHelp
    {
        public string HelpWarPreference => "Visualizza i villaggi pronti per la guerra.";
        public string HelpUnclaimClan =>
"Scollega un clan dal tuo server." +
"Per aggiungerlo di nuovo, dovrai inserire nuovamente \"mb\" alla descrizione.";

        public string HelpDefaultClan =>
@"Indica a Minion Bot quale clan usare nei canali in cui claimclan non è mai stato eseguito.
Puoi utilizzarlo dopo aver eseguito un claimclan.
Il primo clan che rivendichi in un server è automaticamente il clan predefinito.";

        public string HelpMyClans => "Visualizza tutti i clan che il tuo server ha rivendicato.";

        public string HelpMyServer => "Ottieni informazioni riguardo al tuo server.";

        public string HelpMyClan => "Utilizza questo comando per visualizzare quale tag del clan Minion Bot sta utilizzando in un dato canale.";

        public string HelpMyRoles => "Ottieni i ruoli che sono gestiti da questo bot.";

        public string HelpMyChannel => "Ottieni informazioni sulle impostazioni del tuo canale.";

        public string HelpMyChannels => "Ottieni informazioni su tutte le impostazioni dei tuoi canali.";

        public string HelpDeleteRoles => "Questo eliminerà tutti i ruoli che sono stati creati da questo bot.";

        public string HelpAddRoles =>
@"Questo creerà ruoli predefiniti in questo server.
Questi ruoli saranno assegnati automaticamente.
È possibile rinominare o eliminare i ruoli creati da questo comando.";

        public string HelpRestrict => "Questo farà sì che Minion Bot ignori i comandi in un canale. Si consiglia di utilizzare i permessi Discord invece di questo comando.";

        public string HelpPostHits => "Decidi in quale canale saranno pubblicati gli attacchi. Devi disporre del permesso di gestire il canale.";

        public string HelpPostDonations => "Decidi in quale canale saranno pubblicate le donazioni. Devi disporre del permesso di gestire il canale.";

        public string HelpPostGreetings => "Decidi in quale canale saranno pubblicati i movimenti. Devi disporre del permesso di gestire il canale.";

        public string HelpEndWarning => "Attiva/disattiva le menzioni hasHits per l'avviso di fine guerra. Se non hai il ruolo hasHits, non succederà nulla.";

        public string HelpStartWarning => "Attiva/disattiva le menzioni hasHits per l'avviso di inizio guerra. Se non hai il ruolo hasHits, non succederà nulla.";

        public string HelpSetLanguage => "Cambia la lingua. Visita [github.com](https://github.com/devhl-labs/MinionBot5.Language) per visualizzare le lingue supportate.";

        public string HelpSetPrefix =>
@"Per impostazione predefinita Minion Bot non ha un prefisso.
Assegnane uno a tua scelta con questo comando.
Una volta assegnato, i comandi richiederanno il prefisso per essere eseguiti.
Se il tuo prefisso è !, il comando help sarà simile a !help.
Usa deleteprefix per annullare questa operazione.";

        public string HelpDeletePrefix => "Questo comando eliminerà il tuo prefisso.";

        public string HelpClaimClan =>
@"Esegui questo comando per ogni clan che vuoi rivendicare in un canale diverso.
Devi inserire le lettere 'mb' dopo la descrizione del clan affinché funzioni.";
    }
}