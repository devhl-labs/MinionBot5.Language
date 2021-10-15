namespace MinionBot.Languages.Russian
{
    public class LeagueHelp : ILeagueHelp
    {
        public string HelpOrgClanBan => "Забанить клан в организации.";
        public string HelpUnOrgClanBan => "Убрать бан клана в организации";
        public string HelpLeaugeViewer => "Добавить или убрать роль просмотра лиговых каналов.";
        public string HelpEditWar => "Редактировать результаты войны. Отразится только в команде scoreboard, но не в команде stats.";
        public string HelpDivisions => "Посмотреть дивизионы заданной лиги.";
        public string HelpScoreboard => "Посмотреть турнирную таблицу лиги.";
        public string HelpValidate => "Проверить заданный клан, нет ли среди участников забаненых в лигах.";
        public string HelpCreateOrg => "Создать организацию.";
        public string HelpChange => "Развернуть чтобы посмотреть больше.";
        public string HelpChangeOrg => "Изменить организацию.";
        public string HelpChangeClan => "Заменить клан.";
        public string HelpChangeLeague => "Сменить лигу.";
        public string HelpCreateLeague => "Создать лигу.";
        public string HelpInspect => "Посмотреть информацию об объекте.";
        public string HelpRequestLeague =>
@"Если текущая война принадлежит лиге, запустите эту команду чтобы поменить ее как лиговую.
Ваш запрос будет отправлен на сервер поддержки и представитель лиги рассмотрит ее на предмет утверждения.";
        public string HelpGetOrgBans => "Посмотреть все баны организации.";
        public string HelpLeagueRep => "Посмотреть всех представителей лиги или назначить нового представителя.";
        public string HelpAddClan => "Добавить клан в лигу.";
        public string HelpRemoveClan => "Убрать клан из лиги.";
        public string HelpShell => "Добавить клан к одному из представителей.";
        public string HelpUnshell => "Убрать клан, обратно к своему представителю.";
        public string HelpImport => "Импортировать список кланов из сайта warmatch по сылке.";
        public string HelpAddWar => "Добавить войну в лигу. Если нужно изменить результаты звезд и процентов, сделайте это позже";
        public string HelpRemoveWar => "Удалить войну из лиги.";
        public string HelpOrgBan =>
"Забанить деревню в организации. В дальнейшем если эта деревня присоединится или будет заиграна в одном из лиговых кланов, вы об этом узнаете.";
        public string HelpOrgUnban => "Удалить бан деревни в организации.";
        public string HelpChangeWinner => "Назначить пообедителя лиговой войны. Это будет заметно только в турнироной таблице, не в статистике отдельной войны.";
        public string HelpChangeStars => "Изменить количество звезд лиговой воны. Это будет заметно только в турнироной таблице, не в статистике отдельной войны.";
        public string HelpChangePercent => "Изменить проценты лиговой войныЭто будет заметно только в турнироной таблице, не в статистике отдельной войны.";
        public string HelpLeagueWinner => "Назначить победителя лиги.";
        public string HelpShowPrivateWars => "Посмотреть все кланы лиги на пердмет закрытого хода войны.";
        public string HelpLog => "Вручную ввести атаку. Вы получите позицию на карте из команды roster.";
        public string HelpUndo => "Удалить вручную введенную атаку";
        public string HelpSetMatch =>
"Назначить день войны между двумя кланами. Дата и время UTC. Когда 2 клана сыграют в этот день (или в ближайшие 7 дней) они будут автоматически утверждены. Используйтe `deletematch` чтобы это отменить.";
        public string HelpDeleteMatch => "Удалить один из назначенных матчей";
        public string HelpRemoveAllClans => "Удалить все кланы из лиги.";
        public string HelpRemoveAllWars => "Удалить все войны из лиги.";
    }
}