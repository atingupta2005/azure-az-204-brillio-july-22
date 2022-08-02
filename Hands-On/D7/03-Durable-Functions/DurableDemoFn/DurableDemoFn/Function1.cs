using System.Collections.Generic;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DurableDemoFn
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<List<string>> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context)
        {
            var outputs = new List<string>();

            String out1 = await context.CallActivityAsync<string>("ATM", "2000");

            outputs.Add(out1);

            if (out1 == "withdrawn")
            {
                String out2 = await context.CallActivityAsync<string>("BuyGrocery", "Laptop");
                outputs.Add(out2);
                outputs.Add(await context.CallActivityAsync<string>("DepositMoney", "Citybank"));
            }

            return outputs;
        }

        [FunctionName("ATM")]
        public static string GetCash([ActivityTrigger] string amount, ILogger log)
        {
            bool done = withdraw_cash(amount);

            if (done)
            {
                log.LogInformation($"Withdrawn cash {amount}.");
                return $"withdrawn";
            }
            else
            {
                log.LogInformation($"Not Withdrawn cash {amount}.");
                return $"not withdrawn";
            }

        }

        public static bool withdraw_cash(string amount)
        {
            Random rnd = new Random();
            int myNum = rnd.Next(0, 2);
            bool done = (myNum == 1);

            return done;
        }


        [FunctionName("BuyGrocery")]
        public static string GetItems([ActivityTrigger] string name, ILogger log)
        {
            log.LogInformation($"Buying {name}.");
            return $"Baught {name}!";
        }


        [FunctionName("DepositMoney")]
        public static string SaveCash([ActivityTrigger] string name, ILogger log)
        {
            log.LogInformation($"Depositing money in {name}.");
            return $"Deposited money in {name}!";
        }




        [FunctionName("Function1_HttpStart")]
        public static async Task<HttpResponseMessage> HttpStart(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestMessage req,
            [DurableClient] IDurableOrchestrationClient starter,
            ILogger log)
        {
            // Function input comes from the request content.
            string instanceId = await starter.StartNewAsync("Function1", null);

            log.LogInformation($"Started orchestration with ID = '{instanceId}'.");

            return starter.CreateCheckStatusResponse(req, instanceId);
        }
    }
}