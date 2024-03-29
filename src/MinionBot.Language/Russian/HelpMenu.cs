﻿namespace MinionBot.Languages.Russian
{
    public class HelpMenu : IHelpMenu
    {
        public string InviteBot => "Добавить бота к вашему серверу";
        public string InviteBotDescription => 
@"Не видите ваш сервер? У вас нет прав администратора на вашем сервере.

Если права все же есть, то попробуйте перезапустить Discord.";
        public string BotNotResponding => "Бот не отвечает?";
        public string BotNotRespondingDescription =>
@"Убедитесь, что бот отображается в списке посетителей канала, в котором он находится.

Если его там нет, добавьте Minion Bot соответствующую роль или дайте ему разрешение читать канал.

В списке посетителей, но все врано не отвечает?

Проверьте роли в настройках сервера.
Дайте `Читать текстовые каналы и смотреть голосовые каналы`, `Посылать сообщения`, `Вставлять ссылки`, `Читать историю сообщений`, `Использовать внешние эмодзи`, `Добавлять реакции`
Все еще не отвечает? Проверьте категории каналов и убедитесь, что у него есть необходимые роли.

Если и после этого не отвечает, попробуйте команду `deleteprefix` и `restrict false`.

Нажмите кнопку Получить помощь ниже для дополнительной поддержки.";

        public string IDontUnderstandTheCommands => "Я не понимаю команду";
        public string IDontUnderstandTheCommandsDescription => 
"Для получения дополнительной информации о команде запустите `help название_команды` где название_команды та команда что вас интересует.";
        public string HowDoIClaimMyClan => "Как мне привязать клан?";
        public string HowDoIClaimMyClanDescription =>
@"Добавьте в концовку описания клана в игре 2 буквы `mb`
Подождите пару минут.
Запустите команду `/clans claims create #clanTag` где #clanTag ваш тэг клана.
Уберите `mb` из описания чтобы никто больше не мог привязать ваш клан.

Мой ход войны должен быть публичным? Если вы хотите видеть ход атак, да!

Могу ли я привязать несколько кланов? Да! Просто запустите `/clans claims create` в разных каналах.";

        public string WhatDoTheSymbolsMean => "Что означают символы?";
        public string HelpSettingUpMyServer => "Мне нужна помощь в настройке моего сервера.";
        public string HelpSettingUpMyServerDescription => "[Попробуйте этот шаблон](https://discord.new/mEgxbhkM55vW) или поищите в YouTube инструкцию.";
        public string WhatAreTheCommands => "Так что это за команды?";
        public string WhatAreTheCommandsDescription =>
@"Напишите `commands` для вывода полного списка команд.

Просмотр войны
`▹  p       вывод списка баз, не закрытых баз на 3 звезды`
`▹  stats   показывает статистику текущей войны`
`▹  gra     показывает оставшиеся атаки вашего клана`
`▹  gla     показывает 10 последних атак`

Бронь базы
`▹  c 5               забронировать базу #5 для вас`
`▹  c 5 #villageTag   забронировать базу #5 для другого игрока`

Удалить бронь
`▹  d 5      удалить вашу бронь или первую бронь с базы #5`
`▹  d 5 2    удалить вторую бронь с базы #5`

Закрепить за собой деревню
`▹  claim #villageTag`
`▹  claim #villageTag @владелец_в_дискорд`

Псевдоним
`▹  alias #villageTag Псевдоним`
`▹  prefer Псевдоним`
`▹  deletealias Псевдоним`
`Псевдоним это просто кличка или временное имя. Делайте его проще.`
`Делайте их вместо трудно произносимых или нелепых ников.`

`Тег деревни можно заменить псевдонимом или @владельцем.`";

        public string InviteMe => "Пригласи меня";
        public string GetHelp => "Получи помощь";
    }
}
