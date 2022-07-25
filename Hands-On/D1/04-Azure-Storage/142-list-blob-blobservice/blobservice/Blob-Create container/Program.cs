using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;

namespace Blob_Create_container
{
    class Program
    {
        // Ensure to change the connection string and the container name
        private static string blob_connection_string = "DefaultEndpointsProtocol=https;AccountName=saatin;AccountKey=CfbGjDha0VmJmFualL8ZBbf/CuAAxTIHtderBPmjNi2OVJMSJTp+EFq8NY4/j0TPBbV33gvrD4xgPDkc+JvNOQ==;EndpointSuffix=core.windows.net";
        private static string container_name = "demo";
          static void Main(string[] args)
        {

            BlobServiceClient _client = new BlobServiceClient(blob_connection_string);

            BlobContainerClient _container_client = _client.GetBlobContainerClient(container_name);

            foreach(BlobItem item in _container_client.GetBlobs())
            {
                Console.WriteLine(item.Name);                
            }
            
            Console.ReadKey();
        }
    }
}
