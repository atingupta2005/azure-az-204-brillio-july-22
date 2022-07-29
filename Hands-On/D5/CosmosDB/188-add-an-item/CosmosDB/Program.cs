using Microsoft.Azure.Cosmos;
using System;

namespace CosmosDB
{
    class Program
    {
        private static readonly string _connection_string = "AccountEndpoint=https://atincosmosjune21.documents.azure.com:443/;AccountKey=wEkLvnwbw3QowkTwd18xnXAtm2kXecEQCpbTW1XYFWN1V3n5hOGlOplX93oab9hYS01wuwEu2n2GYEZtfEO8gg==;";
        private static readonly string _database_name = "appdb";
        private static readonly string _container_name = "course";
        
        static void Main(string[] args)
        {

            CosmosClient _client = new CosmosClient(_connection_string);

            Course _course = new Course()
            {
                id = "1",
                courseid = "C00010",
                coursename = "AZ-204",
                rating = 4.5m
            };

            Container _container=_client.GetContainer(_database_name, _container_name);

            _container.CreateItemAsync<Course>(_course, new PartitionKey(_course.courseid)).GetAwaiter().GetResult();

            Console.WriteLine("Item is created");
            Console.ReadKey();
        }
    }
}
