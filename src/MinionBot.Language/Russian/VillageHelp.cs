﻿namespace MinionBot.Languages.Russian
{
    public class VillageHelp : IVillageHelp
    {
        public string HelpAlias => "Дает деревне псевдоним. Делайте его короче и легче для написания.";

        public string HelpBanVillage => "Забанить деревню в вашем клане.";

        public string HelpUnBanVillage => "Разбанить деревню в вашем клане.";

        public string HelpClaim =>
@"Скажет боту кто владелец деревни.
Используйте @discordMention для помощи вашим сокланам для привязки их деревень.
Если у вас есть проблема с поиском имени деревни, используйте тэг.";

        public string HelpDeleteAlias =>
@"Используйте это для удаления старого псевдонима.
Особенно полезно если вы переименовали деревню в игре.
Псевдоним должен быть уникален, поэтому вам нужно указать этой команде только псевдоним.";

        public string HelpGetAlias => "Посмотреть все псевдонимы деревень.";

        public string HelpGetBans => "Посмотреть все баны клана или деревень.";

        public string HelpGetClaims => "Покажет полный список деревень и к кому они привязаны.";

        public string HelpGetUnclaimed => "Покажет список непривязанных деревень.";

        public string HelpMembers => "Покажет всех участников клана.";

        public string HelpLookup => "Различная информация о деревне.";

        public string HelpMyBase => "Покажет информацию о базе.";

        public string HelpPrefer =>
@"Minion Bot попробует использовать приоритетные псевдонимы поверх старых.
Вы можете назначить только один псевдоним.
Псевдоним должен быть уникален, вы должны только его указать.";

        public string HelpSearch =>
@"Используйте чтобы посмотреть кто у вас в клане.
Так же используйте чтобы быстро посмотреть тэги всех деревень.
Можно использовать строку поиск для скорости.";

        public string HelpUnclaim => "Отвязать деревню от пользователя дискорд.";

        public string HelpUpdateMembers => "Обновить роли и уровни герое для всех деревень клана.";

        public string HelpClaimAttacks =>
@"Привяжет все ранее отвязанные атаки.
Включая атаки и защиты, сделанные до привязки деревни.
**Это не может быть отменено.**";
        public string HelpSuperTroops => "Посмотреть всех открытых супер-войнов в клане.";
    }
}