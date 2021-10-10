namespace MinionBot.Languages.Italian
{
    public class StatsHelp : IStatsHelp
    {
        public string HelpLeagueStats => "Visualizza le statistiche per le guerre di lega di questa settimana.";
        public string HelpBotLeader =>
@"Ottieni i migliori attaccanti o difensori dell'intero bot.
Otterrai i migliori hit rate per tutti i villaggi, indipendentemente dal clan.
War Type può essere farm, arranged, competitive o SCCWL.
Fresh Type può essere fresh o cleanup.";
        public string HelpClanLeagueLeader =>
@"Questo mostrerà quale clan ha il miglior hit rate in una lega.
Per impostazione predefinita Season sarà la stagione attuale.
Per comprendere tutte le stagioni, inserisci 0.
Fresh Type può essere fresh o cleanup.";
        public string HelpClanStats =>
@"Ottieni statistiche dall'intera cronologia degli attacchi di un clan.
Appariranno come le statistiche di un villaggio, ma mostreranno l'intero clan.
Questo ti permette di inserire il tag di un altro clan per confrontare i clan.
Per impostazione predefinita Season sarà la stagione attuale.
Per comprendere tutte le stagioni, inserisci 0.
War Type può essere farm, arranged, competitive o SCCWL.";
        public string HelpLeagueLeader => "Questo comando è stato ritirato.";
        //"Questo mostrerà la lega con il miglior hit rate. Fresh Type può essere fresh o cleanup."
        public string HelpStats =>
@"Visualizza le statistiche per la guerra attuale, un villaggio o un utente Discord.
Il parametro numberOfMonths limiterà gli attacchi agli ultimi X mesi.
Per impostazione predefinita Season sarà la stagione attuale.
Per comprendere tutte le stagioni, inserisci 0.
War Type può essere farm, arranged, competitive o SCCWL.
Fresh Type può essere fresh o cleanup.
Il parametro clan escluderà gli attacchi che i tuoi compagni hanno fatto mentre erano in altri clan.
Gli ID di una guerra possono essere trovati usando il comando getwars.";
        public string HelpCwlStats => "Questo mostrerà le guerre attuali per tutti i clan nella tua attuale lega SC CWL.";
        public string HelpVillageLeader =>
@"Questo mostrerà la tua posizione nel clan.
Il parametro numberOfMonths limiterà gli attacchi agli ultimi X mesi.
Per impostazione predefinita Season sarà la stagione attuale.
Per comprendere tutte le stagioni, inserisci 0.
War Type può essere farm, arranged, competitive o SCCWL.
Fresh Type può essere fresh o cleanup.
Il parametro clan escluderà gli attacchi che i tuoi compagni hanno fatto mentre erano in altri clan.";
        public string HelpVillageLeagueLeader =>
@"Questo mostrerà i migliori attaccanti e difensori in una lega.
Per impostazione predefinita Season sarà la stagione attuale.
Per comprendere tutte le stagioni, inserisci 0.
Fresh Type può essere fresh o cleanup.";
    }
}