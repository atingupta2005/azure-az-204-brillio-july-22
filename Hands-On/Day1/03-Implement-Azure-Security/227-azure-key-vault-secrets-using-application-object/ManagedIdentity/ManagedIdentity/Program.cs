using Azure.Core;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text.Json;

namespace ManagedIdentity
{
    class Program
    {

        private static string tenantid = "1aa4911b-3deb-4060-8959-2ed6ec653dad";
        private static string clientid = "c11e0803-64cb-4937-a0c3-0f8161b879de";
        private static string clientsecret = "7XM3a2j.t7c~HFzcR_~8D.0-u.wf8xWKs8";

        private static string keyvault_url = "https://appkvatinjune21.vault.azure.net/";
        private static string secret_name = "dbpassword";
        static void Main(string[] args)
        {

            ClientSecretCredential _client_secret = new ClientSecretCredential(tenantid,clientid,clientsecret);

            SecretClient _secret_client = new SecretClient(new Uri(keyvault_url), _client_secret);

            var secret= _secret_client.GetSecret(secret_name);

            Console.WriteLine($"The value of the secret is {secret.Value.Value}");

            Console.ReadKey();

        }
    }
}
