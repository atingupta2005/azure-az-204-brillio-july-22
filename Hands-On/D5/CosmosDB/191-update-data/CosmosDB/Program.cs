using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CosmosDB
{
    class Program
    {
        private static readonly string _connection_string = "AccountEndpoint=https://atincosmosjune21.documents.azure.com:443/;AccountKey=wEkLvnwbw3QowkTwd18xnXAtm2kXecEQCpbTW1XYFWN1V3n5hOGlOplX93oab9hYS01wuwEu2n2GYEZtfEO8gg==;";
        private static readonly string _database_name = "appdb";
        private static readonly string _container_name = "course";
        
        static void Main(string[] args)
        {

            CosmosClient _client = new CosmosClient(_connection_string,new CosmosClientOptions() { AllowBulkExecution=true});

            Container _container=_client.GetContainer(_database_name, _container_name);

            string _id = "2";
            string _partition_key = "Course0002";

            ItemResponse<Course> _response= _container.ReadItemAsync<Course>(_id, new PartitionKey(_partition_key)).GetAwaiter().GetResult();

            Course _course = _response.Resource;

            _course.rating = 4.8m;

            _container.ReplaceItemAsync<Course>(_course, _id, new PartitionKey(_partition_key)).GetAwaiter().GetResult();

            Console.WriteLine("Item has been updated");

            Console.ReadKey();
        }
    }
}
