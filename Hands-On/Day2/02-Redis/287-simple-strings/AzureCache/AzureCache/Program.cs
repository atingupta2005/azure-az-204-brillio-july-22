using StackExchange.Redis;
using System;

namespace AzureCache
{
    class Program
    {
        private static Lazy<ConnectionMultiplexer> cache_connection = CreateConnection();
        public static ConnectionMultiplexer Connection
        {
            get
            {
                return cache_connection.Value;
            }
        }
        static void Main(string[] args)
        {
            IDatabase cache = Connection.GetDatabase();

            //cache.StringSet("Course Name", "AZ-204 - Develoing Azure solutions");


            //cache.KeyExpire("Course Name", new TimeSpan(0, 0, 30));
            if (cache.KeyExists("Course Name"))
            Console.WriteLine(cache.StringGet("Course Name"));
            else
                Console.WriteLine("Key does not exist");
            Console.ReadKey();

        }

        private static Lazy<ConnectionMultiplexer> CreateConnection()
        {
            string cache_connectionstring = "redisatinjune21.redis.cache.windows.net:6380,password=fkfvPRV4q+dc2PcYTI+yTq6lZjE+X89wizuq4l4xPuQ=,ssl=True,abortConnect=False";
            return new Lazy<ConnectionMultiplexer>(() =>
            {                
                return ConnectionMultiplexer.Connect(cache_connectionstring);
            });
        }
    }
}
