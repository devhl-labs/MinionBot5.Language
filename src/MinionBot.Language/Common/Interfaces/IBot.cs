namespace MinionBot.Languages
{
    public interface IBot
    {
        string SomethingWentWrong { get; }
        string ChecksFailed { get; }
        string CheckTheParametersNoClaims(string commandName);
        string CheckTheParameters(string commandName);
        string CheckTheParametersNoClaimsMissingPermission(string commandName);
        string CheckTheParametersMissingPermission(string commandName);
        string CommandIsAlreadyRunning { get; }
        string IDontHaveChannelPermission(string permission);
        string IDontHaveServerPermission(string permission);
        string YouDontHaveChannelPermission(string permission);
        string YouDontHaveServerPermission(string permission);
    }
}
