using IdentityServer4.Models;

namespace DummyAuthentication;

public class IdentityConfiguration
{
    public static IEnumerable<IdentityResource> IdentityResources { get; set; }
    public static IEnumerable<ApiScope> ApiScopes { get; set; }
    public static IEnumerable<ApiResource> ApiResources { get; set; }
    public static IEnumerable<Client> Clients { get; set; }
}
