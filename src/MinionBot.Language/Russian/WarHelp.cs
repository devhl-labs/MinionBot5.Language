namespace MinionBot.Languages.Russian
{
    public class WarHelp : IWarHelp
    {
        //war
        public string HelpCallTimer => "Поставить время таймера для брони.";
        public string HelpStackCalls => "Если активно, то несколько деревень могут бронировать базу в одно время.";
        public string HelpPrivateWars =>
"Скажет Minion Bot о том, что вы держите Ход Войны закрытым. Это включит команды, предназначенные для закрытых Ходов Войны, такие как запуск и отчет..";
        public string HelpPublicWars => "Скажет Minion Bot что вы должны держать Ход Войны открытым. Бронирование будет работать автоматически.";
        public string HelpPrint => "Посмотреть забронированные деревни в текущей войне.";
        public string HelpStart => "Эта команда только для кланов, которые держат Ход Войны закрытым. Используйте для старта новой войны в Minion Bot.";
        public string HelpReport => "Эта команда только для кланов, которые держат Ход Войны закрытым. Используйте чтобы сообщить о результате атаки.";
        public string HelpCall => "Забронировать базу соперника.";
        public string HelpDelete =>
"Удалить бронь базы соперника. Укажите позицию защитника для удаления вашей брони или первой брони на эту базу.";
        public string HelpNoStats =>
"Атаки не записываются в статистику после запуска этой команды. Используется для тренировок. Может запускаться только солидером";
        public string HelpGetRemainingAttacks =>
"Покажет чьи атаки остались. Если Деревни были забронирован, то покажет какие.";
        public string HelpGetLastAttacks => "Показать последние атаки.";
        public string HelpGetLastDefenses => "Показать последние защиты.";
        public string HelpGetWars => "Показать список всех известных войн вашего клана.";
        public string HelpMatchup => "Показать соответствие баз вас и ваших соперников текущей войны.";
        public string HelpDefenses => "Показать сколько незакрытых баз в защите осталось.";
        public string HelpAnnounceWar => "Показать объявление о найденной войне.";
        public string HelpAttacks => "Показать количество оставшихся атак с обоих сторон.";
        public string HelpRoster => "Показать полный список деревень в войне с обоих сторон.";
        public string HelpLineup => "Посмотреть детальную информацию о каждой деревне в текущей войне.";
    }
}