namespace Gretel.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static GretelClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("GRETEL_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("GRETEL_API_KEY environment variable is not found.");

        var client = new GretelClient(apiKey);
        
        return client;
    }
}
