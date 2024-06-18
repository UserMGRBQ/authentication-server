using IdentityServer4.Models;

namespace DummyAuthentication;

public class IdentityConfiguration
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new ApiScope[]
        {
            new ApiScope("dummy-scope")
        };

    public static IEnumerable<ApiResource> ApiResources =>
        new ApiResource[]
        {
            new ApiResource("dummy-resource")
            {
                Scopes = new List<string>{ "dummy-scope" }
            }
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new Client()
            {
                ClientId = "dummy-consumer",
                ClientName = "Random Consumer",
                AllowedGrantTypes = GrantTypes.ClientCredentials,
                ClientSecrets = { new Secret("d7mm1-5ecre7".Sha256()) },
                AllowedScopes = { "dummy-scope" },
                AccessTokenLifetime = 1200
            }
        };
}
