using Azure.Identity;
using Azure.Storage.Blobs;
using System;

namespace blobapplication
{
    class Program
    {


        private static string blob_url = "https://saatin.blob.core.windows.net/data/data.json";
        private static string local_blob = "C:\\data\\data.json";
        

        private static string tenantid = "1aa4911b-3deb-4060-8959-2ed6ec653dad";
        private static string clientid = "c11e0803-64cb-4937-a0c3-0f8161b879de";
        private static string clientsecret = "7XM3a2j.t7c~HFzcR_~8D.0-u.wf8xWKs8";
        static void Main(string[] args)
        {
            ClientSecretCredential _client_credential = new ClientSecretCredential(tenantid, clientid, clientsecret);

            Uri blob_uri = new Uri(blob_url);

            BlobClient _blob_client = new BlobClient(blob_uri, _client_credential);

            _blob_client.DownloadTo(local_blob);            

            Console.WriteLine("Blob downloaded");
            Console.ReadKey();
        }

    }
}
