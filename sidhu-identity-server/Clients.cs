﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4.Models;

namespace sidhu_identity_server
{
    internal class Clients
    {
	    public static IEnumerable<Client> Get()
	    {
		    return new List<Client>
		    {
			    new Client
			    {
				    ClientId = "oauthClient",
				    ClientName = "Example Client Credentials Client Application",
				    AllowedGrantTypes = GrantTypes.ClientCredentials,
				    ClientSecrets = new List<Secret>
				    {
					    new Secret("superSecretPassword".Sha256())
				    },
				    AllowedScopes = new List<string> {"customAPI.read"}
			    }
		    };
	    }
    }
}