using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;

namespace AzureStorageBlob
{
    class Program
    {
        private static string storage_connection_string = "DefaultEndpointsProtocol=https;AccountName=saatin;AccountKey=CfbGjDha0VmJmFualL8ZBbf/CuAAxTIHtderBPmjNi2OVJMSJTp+EFq8NY4/j0TPBbV33gvrD4xgPDkc+JvNOQ==;EndpointSuffix=core.windows.net";
        private static string container_name = "data";
        private static string download_path = "C:\\tmp\\Program.cs";
        private static string blob_name = "Program.cs";
        static void Main(string[] args)
        {
            BlobServiceClient _blobServiceClient = new BlobServiceClient(storage_connection_string);

            BlobContainerClient _containerClient = _blobServiceClient.GetBlobContainerClient(container_name);

            BlobClient _blobclient = _containerClient.GetBlobClient(blob_name);

            _blobclient.DownloadTo(download_path);
            
            Console.WriteLine("File download complete");
            Console.ReadKey();
        }
    }
}
