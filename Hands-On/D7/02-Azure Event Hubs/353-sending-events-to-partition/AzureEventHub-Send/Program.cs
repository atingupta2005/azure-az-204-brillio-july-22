using Azure.Messaging.EventHubs.Producer;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzureEventHub_Send
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://appnamespace1000atin.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=6lhIQdDTMVWHRVqm6zMcWGIYgKie9QeZFhL0M3Iw98w=;EntityPath=apphub";
        static void Main(string[] args)
        {
            // 353 - sending - events - partition - 0

            EventHubProducerClient _client = new EventHubProducerClient(connection_string);
            
            var batchOptions = new CreateBatchOptions
            {
                PartitionId = "0"
            };


            for (int i=1; i<=100000; i++)
            {

                EventDataBatch _batch = _client.CreateBatchAsync(batchOptions).GetAwaiter().GetResult();

                List<Order> _orders = new List<Order>()
                {
                    new Order() {OrderID=$"P0-O{i}1",Quantity=10,UnitPrice=9.99m,DiscountCategory="Tier 1" },
                    new Order() {OrderID=$"P0-O{i}2",Quantity=15,UnitPrice=10.99m,DiscountCategory="Tier 2" },
                    new Order() {OrderID=$"P0-O{i}3",Quantity=20,UnitPrice=11.99m,DiscountCategory="Tier 3" },
                    new Order() {OrderID=$"P0-O{i}4",Quantity=25,UnitPrice=12.99m,DiscountCategory="Tier 4" },
                    new Order() {OrderID=$"P0-O{i}5",Quantity=30,UnitPrice=13.99m,DiscountCategory="Tier 5" }
                };

                foreach (Order _order in _orders)
                    _batch.TryAdd(new Azure.Messaging.EventHubs.EventData(Encoding.UTF8.GetBytes(_order.ToString())));

                _client.SendAsync(_batch).GetAwaiter().GetResult();
                Console.WriteLine($"Batch {i} of events sent");

            }

        }
    }
}
