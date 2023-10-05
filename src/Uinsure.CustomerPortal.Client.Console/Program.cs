using Microsoft.Extensions.Configuration;
using Uinsure.CustomerPortal.Client.Api;
using Uinsure.CustomerPortal.Client.Model;
using Uinsure.CustomerPortal.Client.Client;

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .AddJsonFile("appsettings.local.json", optional: true, reloadOnChange: true)
    .Build();

var testApp = new TestApp(configuration);

await testApp.Run();

public class TestApp
{
    private readonly string _apiBasePath;

    public TestApp(IConfiguration configuration)
    {
        _apiBasePath = configuration["CustomerPortalApiBasePath"] ?? "https://localhost:7041/";
    }

    public async Task Run()
    {
        var findRequest = new FindPoliciesRequest
        {
            Surname = "Smith",
        };

        var apiClient = new PoliciesQueryApi(new Configuration
        {
            BasePath = _apiBasePath,
        });
        var results = await apiClient.ApiAdminPoliciesFindPostAsync(findRequest);
    }
}