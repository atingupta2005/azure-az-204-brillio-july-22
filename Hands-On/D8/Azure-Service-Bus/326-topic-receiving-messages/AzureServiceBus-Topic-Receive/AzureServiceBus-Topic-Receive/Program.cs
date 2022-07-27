using Azure.Messaging.ServiceBus;
using System;

namespace AzureServiceBus_Topic_Receive
{
    class Program
    {
        private static string connection_string = "Endpoint=sb://atinappnamespace1000.servicebus.windows.net/;SharedAccessKeyName=all;SharedAccessKey=ck0U0Zvj/nHqTMSVIKvOF1KBhnm1Hnlcc8IjNGGmp0g=;EntityPath=apptopic";
        private static string topic_name = "apptopic";
        private static string subscription_name = "SubscriptionA";
        static void Main(string[] args)
        {
            ServiceBusClient _client = new ServiceBusClient(connection_string);
            ServiceBusReceiver _receiver = _client.CreateReceiver(topic_name, subscription_name, new ServiceBusReceiverOptions() { ReceiveMode = ServiceBusReceiveMode.ReceiveAndDelete });

            var _messages = _receiver.ReceiveMessagesAsync(100);

            foreach (var _message in _messages.Result)
            {
                Console.WriteLine($"The Sequence number is {_message.SequenceNumber}");
                Console.WriteLine(_message.Body);

            }
            Console.ReadKey();
        }
    }
}
