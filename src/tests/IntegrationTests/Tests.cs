namespace LMNT.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LmntClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LMNT_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LMNT_API_KEY environment variable is not found.");

        var client = new LmntClient(apiKey);
        
        return client;
    }
}
