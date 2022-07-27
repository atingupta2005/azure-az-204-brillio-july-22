﻿using Azure.Messaging.ServiceBus;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ServiceBus_Queue_Receive
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://atinappnamespace1000.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=CEdXZgkSGyBWWonlfs78wD6ruGOazl7sa5QGkeWSQYk=;EntityPath=appqueue";
        private static string queue_name = "appqueue";
        static async Task Main(string[] args)
        {
            ServiceBusClient _client = new ServiceBusClient(connection_string);

            

            ServiceBusReceiver _receiver = _client.CreateReceiver(queue_name,new ServiceBusReceiverOptions() {ReceiveMode= ServiceBusReceiveMode.ReceiveAndDelete });

            

            var _messages =  _receiver.ReceiveMessagesAsync(2);

            foreach (var _message in _messages.Result)
            {
                Console.WriteLine($"The Sequence number is {_message.SequenceNumber}");
                Console.WriteLine(_message.Body);
                
            }

        }
    }
}
