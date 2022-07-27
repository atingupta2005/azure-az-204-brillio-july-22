using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;

namespace ServiceBus_Queue_Send
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://atinappnamespace1000.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=d4dQJWz9JMGRGpmafGZlmOQITouxTXqmMe4g98hPjGs=;EntityPath=newqueue";
        private static string queue_name= "newqueue";
        static void Main(string[] args)
        {

            Order _order = new Order() { OrderID = "O1", Quantity = 10, UnitPrice = 9.99m };
                            
            ServiceBusClient _client = new ServiceBusClient(connection_string);
            ServiceBusSender _sender = _client.CreateSender(queue_name);

            ServiceBusMessage _message = new ServiceBusMessage(_order.ToString());
            _message.MessageId = "1";
            _sender.SendMessageAsync(_message).GetAwaiter().GetResult();
                           
            Console.WriteLine("Message sent");
            Console.ReadKey();
        }
    }
}
