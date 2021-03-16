using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Simulate_queue
{
    public class Program
    {
        static void Main(string[] args)
        {
            string storageAccountConnectionString = "<<Enter your connectionstring>>";

            string queueName = "<<Entry your queue name here>>"; 

            int messageCount = 100;

            var storageAccount = CloudStorageAccount.Parse(storageAccountConnectionString);

            var queueClient = storageAccount.CreateCloudQueueClient();

            var queueReference = queueClient.GetQueueReference(queueName);

            queueReference.CreateIfNotExistsAsync();

            for(int i=0; i < messageCount ;i++)
            {
                queueReference.AddMessageAsync(new CloudQueueMessage($"my test message {i}"));
            }

            System.Console.WriteLine("Message sent sucessfully");
            
        }
    }
}
