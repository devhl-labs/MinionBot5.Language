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
        string IDontHavePermission(string type, string permission);
        string YouDontHavePermission(string type, string permission);
    }
}
