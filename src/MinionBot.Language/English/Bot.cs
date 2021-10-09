namespace MinionBot.Languages.English
{
    public class Bot : IBot
    {
        public string SomethingWentWrong { get; } =
"Something went wrong, I'll let the developer know. You can also join the support server for help. <https://discord.gg/EEYAYGN>";
        public string ChecksFailed { get; } =
"Checks failed. Some commands require you or the bot to have extra permissions. Some commands must be ran in a server. Some may only be ran if a clan is claimed.";
        public string CheckTheParametersNoClaims(string commandName) =>
$"Check the parameters and try again. Try claiming a clan first with `claimclaim #clanTag` For help with this command run `help {commandName}`";
        public string CheckTheParameters(string commandName) =>
$"Check the parameters and try again. For help with this command run `help {commandName}`";
        public string CheckTheParametersNoClaimsMissingPermission(string commandName) =>
"Check the parameters and try again. Try claiming a clan first with `claimclaim #clanTag` For help try `help commandName` or join the support server. Some commands require you or the bot to have extra permissions. <https://discord.gg/EEYAYGN>";
        public string CheckTheParametersMissingPermission(string commandName) =>
"Check the parameters and try again. For help try `help commandName` or join the support server. Some commands require you or the bot to have extra permissions. <https://discord.gg/EEYAYGN>";
        public string CommandIsAlreadyRunning =>
"This command is already running.";

    }
}
