﻿namespace MinionBot.Languages.Russian
{
    public class ManagementHelp : IManagementHelp
    {
        public string HelpWarPreference => "Посмотреть деревни готовые к войне.";
        public string HelpUnclaimClan =>
@"Вы можете удалить клан со своео сервера.
Чтобы его вернуть необходимо снова добавить 'mb' в описание.";

        public string HelpDefaultClan =>
@"Просит Minion Bot сказать, в каком канале привязка клана еще не запускалась.
Вы можете запустить эту команду после привязки клана через команду claimclan.
Первый клан, привязанный на вашем сервере автоматически будет кланом по умолчанию.";

        public string HelpMyClans => "Посмотреть все кланы, привязанные на вашем сервере.";

        public string HelpMyServer => "Вывести информацию о вашем сервере.";

        public string HelpMyClan => "Используйте эту команду чтобы посмотреть какой клан привязан в этом канале.";

        public string HelpMyRoles => "Посмотреть роли, кто может настраивать этого бота.";

        public string HelpMyChannel => "Посмотреть информацию о настройках канала.";

        public string HelpMyChannels => "Посмотреть информацию о настройках всех каналов.";

        public string HelpDeleteRoles => "Удалить все роли, что насоздавал бот.";

        public string HelpAddRoles =>
@"Эта команда создаст специальные роли на сервере.
Роли будут присвоены автоматически.
Вы можете переименовать или удалять роли, что будут созданы.";

        public string HelpRestrict => "После этой команды Minion Bot будет игнорировать команды в этом канале. Рекомендуется использовать разрешения дискорда вместо этого.";

        public string HelpPostHits => "Какой канал будет использован для сигналов о проведенных атаках. У вас должно быть разрешение на управление каналом.";

        public string HelpPostDonations => "Какой канал будет использован для сигналов о донатах в игре. У вас должно быть разрешение на управление каналом.";

        public string HelpPostGreetings => "Какой канал будет использован для сигналов о том кто зашел и вышел из клана. У вас должно быть разрешение на управление каналом.";

        public string HelpEndWarning => "Переключает упоминания ролей hasHits о том что война окончена. Если у вас нет ролей hasHits ничего не произойдет.";

        public string HelpStartWarning => "Переключает упоминания ролей hasHits о том что война началась. Если у вас нет ролей hasHits ничего не произойдет.";

        public string HelpSetLanguage => "Сменить язык. Посетите [github.com](https://github.com/devhl-labs/MinionBot5.Language) чтобы посмотреть какие языки поддерживаются.";

        public string HelpSetPrefix =>
@"По-умолчанию Minion Bot не имеет префикса. 
Назначьте любой по вашему выбору по этой команде.
Один раз назначенный префикс будет использоватся для всех команд.
Если ваш префикс !, для для команды help она будет выглядеть как !help.
Используйте deleteprefix чтобы это отменить.";

        public string HelpDeletePrefix => "Команда удаляет префиксы.";

        public string HelpClaimClan =>
@"Запустите эту команду для того, чтобы привязать кланы в разные каналы.
Вы должны добавить буквы 'mb' в конце описания клана в игре чтобы эта команда заработала.";
    }
}