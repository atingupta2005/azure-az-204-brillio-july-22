using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Queuetrigger_blobinput
{
    public static class ProcessMessage
    {
        [FunctionName("SendtoBlob")]
        public static void Run([QueueTrigger("appqueue", Connection = "storage-connection")]string myQueueItem,
            [Blob("trigger/{queueTrigger}", FileAccess.Read,Connection = "storage-connection")] Stream _blob,
            ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            StreamReader _reader = new StreamReader(_blob);
            log.LogInformation(_reader.ReadToEnd());
        }
    }
}
