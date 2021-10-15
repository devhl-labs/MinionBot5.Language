﻿namespace MinionBot.Languages.Russian
{
    public class PatreonHelp : IPatreonHelp
    {
        //patreon
        public string HelpDownloadAttacks => "Скачать фаил с вашими атаками.";
        public string HelpWarChannel =>
"Эта команда переименует каналы чтобы обозначить количество звезд на вражеских базах. У вас должно быть разрешение на управление каналом.";
        public string HelpSponsorServer => "Спонсировать текущий сервер.";
        public string HelpUnsponsorServer => "Больше не спонсировать текущий сервер. Вы можете посмотреть ID сервера по команде `mysponsorships`.";
        public string HelpMySponsorShip => "Посмотреть все сервера, которые вы спонсируете.";
        public string HelpFreshEmote => "Спонсируемые сервера могут использовать эту команду какие эмодзи будут выводится когда база закрыта с 1го раза на 3 звезды или не выдержала защиту.";
        public string HelpFreshAttack => "Спонсируемые сервера могут использовать эту команду какие эмодзи будут выводится когда база закрыта с 1го раза на 3 звезды.";
        public string HelpFreshDefense => "Спонсируемые сервера могут использовать эту команду какие эмодзи будут выводится когда база не выдержала защиту с 1го раза на 3 звезды";
        public string HelpHideAttacks =>
@"Эта команда скрывает те атаки, что вы укаже. Для использования вы должны быть master patron. Ваши атаки подтверждаются заявкой на деревню во время атаки или командой заявки на атаку.";
        public string HelpPatreon => "Покажите свою любовь к Minion Bot! Получите роль на сервере поддержки и несколько дополнительных фишек.";
    }
}