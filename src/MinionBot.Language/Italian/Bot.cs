namespace MinionBot.Languages.Italian
{
    public class Bot : IBot
    {
        public string SomethingWentWrong { get; } =
"Qualcosa è andato storto, lo farò sapere allo sviluppatore. Puoi unirti al server di supporto per ricevere aiuto. <https://discord.gg/EEYAYGN>";
        public string ChecksFailed { get; } =
"Controlli falliti. Alcuni comandi richiedono che tu o il bot abbiate permessi aggiuntivi. Alcuni comandi devono essere eseguiti in un server. Altri possono essere eseguiti solo se è stato rivendicato un clan.";
        public string CommandIsAlreadyRunning { get; }

        public string CheckTheParametersNoClaims(string commandName) =>
$"Controlla i parametri e tenta nuovamente. Prova prima a rivendicare il clan con `claimclaim #clanTag`. Per informazioni su questo comando esegui `help {commandName}`.";
        public string CheckTheParameters(string commandName) =>
$"Controlla i parametri e tenta nuovamente. Per informazioni su questo comando esegui `help {commandName}`.";

        public string CheckTheParametersNoClaimsMissingPermission(string commandName) =>
"Controlla i parametri e tenta nuovamente. Prova prima a rivendicare il clan con `claimclaim #clanTag`. Per informazioni su questo comando esegui `help commandName` o unisciti al server di supporto. Alcuni comandi richiedono che tu o il bot abbiate permessi aggiuntivi. <https://discord.gg/EEYAYGN>";
        public string CheckTheParametersMissingPermission(string commandName) =>
"Controlla i parametri e tenta nuovamente. Per informazioni su questo comando esegui `help commandName` o unisciti al server di supporto. Alcuni comandi richiedono che tu o il bot abbiate permessi aggiuntivi. <https://discord.gg/EEYAYGN>";

        public string IDontHaveChannelPermission(string permission) =>
$"I don't channel permission for {permission}";
        public string IDontHaveServerPermission(string permission) =>
$"I don't server permission for {permission}";
        public string YouDontHaveChannelPermission(string permission) =>
$"You don't channel permission for {permission}";
        public string YouDontHaveServerPermission(string permission) =>
$"You don't server permission for {permission}";
    }
}
