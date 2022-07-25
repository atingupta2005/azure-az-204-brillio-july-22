using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.Collections.Generic;

namespace blobservice
{
    class Program
    {
        private static string _container_name = "demo";
        private static string _connection_string = "DefaultEndpointsProtocol=https;AccountName=saatin;AccountKey=CfbGjDha0VmJmFualL8ZBbf/CuAAxTIHtderBPmjNi2OVJMSJTp+EFq8NY4/j0TPBbV33gvrD4xgPDkc+JvNOQ==;EndpointSuffix=core.windows.net";
        private static string _blob_name = "Program.cs";
        private static string _location = "C:\\tmp\\Program.cs";
        static void Main(string[] args)
        {
            //GetMetadata();
            SetMetadata();
        }

        public static void GetMetadata()
        {
            BlobServiceClient _service_client = new BlobServiceClient(_connection_string);

            BlobContainerClient _container_client = _service_client.GetBlobContainerClient(_container_name);

            BlobClient _blob_client = _container_client.GetBlobClient(_blob_name);

            BlobProperties _properties = _blob_client.GetProperties();

            IDictionary<string, string> _metadata = _properties.Metadata;

            foreach (var item in _metadata)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.ReadKey();
        }

        public static void SetMetadata()
        {
            BlobServiceClient _service_client = new BlobServiceClient(_connection_string);

            BlobContainerClient _container_client = _service_client.GetBlobContainerClient(_container_name);

            BlobClient _blob_client = _container_client.GetBlobClient(_blob_name);

            BlobProperties _properties = _blob_client.GetProperties();

            IDictionary<string, string> _metadata = _properties.Metadata;

            _metadata.Add("Tier", "1");

            _blob_client.SetMetadata(_metadata);

            Console.WriteLine("Metadata appended");
        }
    }
}
