using IdentityServer4.Models;
using System.Collections;
using System.Collections.Generic;

namespace IdentityServer
{
    public class config
    {
        public static IEnumerable<ApiResource> getApiResource()
        {
            return new List<ApiResource>
            {
                new ApiResource("api","api")
            };
        }
        public static IEnumerable<Client> GetClient()
        {
            return new List<Client>()
                {
                new Client
                {
                    ClientId = "client",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {new Secret("secret".Sha256())},
                    AllowedScopes = {"api" }
                } };
        }
    }
}