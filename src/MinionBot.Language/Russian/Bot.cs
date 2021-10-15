namespace MinionBot.Languages.Russian
{
    public class Bot : IBot
    {
        public string SomethingWentWrong { get; } =
"Что-то произошло, я сообщу разработчику. Так же вы можете присоединиться к серверу поддержки и попросить о помощи. <https://discord.gg/EEYAYGN>";
        public string ChecksFailed { get; } =
"Проверка не прошла. Часть команд треуют от вас или бота дополнительных параметров. Часть команда должна быть запущена на сервере, часть только если клан присоединен.";
        public string CheckTheParametersNoClaims(string commandName) =>
$"Проверьте параметы и попробуйте еще раз. Попробуйте сначала присоединить клан командой `claimclaim #clanTag` Для помощи используйте команду `help {commandName}`";
        public string CheckTheParameters(string commandName) =>
$"Проверьте параметы и попробуйте еще раз. Для помощи используйе команду `help {commandName}`";
        public string CheckTheParametersNoClaimsMissingPermission(string commandName) =>
"Проверьте параметы и попробуйте еще раз. Попробуйте сначала присоединить клан командой `claimclaim #clanTag` Для помощи используйте команду `help название_команды` или зайдите на сервер поддержки. Часть команды требует для вас или бота дополнительных разрешений. <https://discord.gg/EEYAYGN>";
        public string CheckTheParametersMissingPermission(string commandName) =>
"Проверьте параметы и попробуйте еще раз. Для помощи используйе команду `help название_команды` или зайдите на сервер поддержки. Часть команды требует для вас или бота дополнительных разрешений. <https://discord.gg/EEYAYGN>";
        public string CommandIsAlreadyRunning =>
"Эта команда уже запущена.";
        public string IDontHaveChannelPermission(string permission) =>
$"У меня нет разрешения для этого канала {permission}";
        public string IDontHaveServerPermission(string permission) =>
$"У меня нет разрешения для этого сервера {permission}";
        public string YouDontHaveChannelPermission(string permission) =>
$"У вас нет разрешения для этого канала {permission}";
        public string YouDontHaveServerPermission(string permission) =>
$"У вас нет разрешения для этого сервера {permission}";
    }
}
