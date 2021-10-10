namespace MinionBot.Languages.Italian
{
    public class PatreonHelp : IPatreonHelp
    {
        //patreon
        public string HelpDownloadAttacks => "Scarica un documento contenente i tuoi attacchi.";
        public string HelpWarChannel =>
"Questo comando rinominerà un canale per rispecchiare il numero di stelle su una base nemica. Devi disporre del permesso di gestire il canale.";
        public string HelpSponsorServer => "Sponsorizza il presente server.";
        public string HelpUnsponsorServer => "Smetti di sponsorizzare un server. Puoi ottenere l'ID del server da `mysponsorships`.";
        public string HelpMySponsorShip => "Visualizza tutti i server che stai sponsorizzando.";
        public string HelpFreshEmote => "I server sponsorizzati possono usare questo comando per controllare quale emoji è visualizzata per un attacco o una difesa tris fresh.";
        public string HelpFreshAttack => "I server sponsorizzati possono usare questo comando per controllare quale emoji è visualizzata per un attacco tris fresh.";
        public string HelpFreshDefense => "I server sponsorizzati possono usare questo comando per controllare quale emoji è visualizzata per una difesa tris fresh.";
        public string HelpHideAttacks =>
@"Questo nasconderà qualsiasi attacco che hai rivendicato. Devi essere un Master Patron per usare questo comando. I tuoi attacchi sono rivendicati quando il villaggio è rivendicato mentre si verifica l'attacco o tramite il comando claimattacks.";
        public string HelpPatreon => "Mostra il tuo sostegno per Minion Bot! Ottieni un ruolo nel server di supporto e alcuni vantaggi aggiuntivi.";
    }
}