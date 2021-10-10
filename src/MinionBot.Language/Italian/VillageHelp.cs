namespace MinionBot.Languages.Italian
{
    public class VillageHelp : IVillageHelp
    {
        public string HelpAlias => "Assegna un soprannome a un villaggio. Tienilo breve e facile da digitare.";

        public string HelpBanVillage => "Banna un villaggio dal tuo clan.";

        public string HelpUnBanVillage => "Revoca a un villaggio il ban dal tuo clan.";

        public string HelpClaim =>
@"Indica al bot chi possiede il villaggio.
Utilizza una @menzioneDiscord per aiutare i tuoi compagni di clan a rivendicare i loro villaggi.
Se stai riscontrando problemi utilizzando il nome del villaggio, prova a utilizzare il tag del villaggio.";

        public string HelpDeleteAlias =>
@"Rimuovi un vecchio alias.
Utile soprattutto dopo aver cambiato il nome di un villaggio nel gioco.
Gli alias devono essere univoci, quindi devi fornire solo il nome dell'alias.";

        public string HelpGetAlias => "Visualizza tutti i soprannomi di un villaggio.";

        public string HelpGetBans => "Visualizza tutti i ban per il tuo clan o per un villaggio.";

        public string HelpGetClaims => "Fornisce una panoramica di quali villaggi sono rivendicati.";

        public string HelpGetUnclaimed => "Visualizza tutti i villaggi che non sono rivendicati.";

        public string HelpMembers => "Visualizza tutti i membri che attualmente sono nel tuo clan.";

        public string HelpLookup => "Cerca varie informazioni su un villaggio.";

        public string HelpMyBase => "Visualizza informazioni su una base.";

        public string HelpPrefer =>
@"Minion Bot proverà a usare l'alias preferito rispetto ad altri alias.
Puoi avere solo un alias preferito alla volta.
Gli alias devono essere univoci, quindi devi fornire solo il nome dell'alias.";

        public string HelpSearch =>
@"Usalo per vedere quali villaggi sono nel tuo clan.
Usalo anche per ottenere rapidamente i tag dei villaggi dei tuoi compagni di clan.
Fornisci una stringa di ricerca per restringere i risultati.";

        public string HelpUnclaim => "Scollega un villaggio da un utente Discord.";

        public string HelpUpdateMembers => "Aggiorna i ruoli e i livelli degli eroi per tutti i villaggi nel tuo clan.";

        public string HelpClaimAttacks =>
@"Questo rivendicherà tutti gli attacchi non reclamati in precedenza.
Include attacchi e difese fatti prima che tu rivendicassi il villaggio.
**Non può essere annullato.**";
        public string HelpSuperTroops => "Guarda quali villaggi hanno sbloccato le super truppe.";
    }
}