using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace QueueHelper
{
    public class Program
    {
        static void Main(string[] args)
        {
            string storageAccountConnectionString = "<<Enter your storage account connectionstring>>";

            string queueName = "<<Enter your queue name>>"; 

            string messageCount = "10";

            // var storageAccount = CloudStorageAccount.Parse(storageAccountConnectionString);

            // var queueClient = storageAccount.CreateCloudQueueClient();

            // var queueReference = queueClient.GetQueueReference(queueName);

            // queueReference.CreateIfNotExistsAsync();

            for(int i=0; i < Convert.ToInt16(messageCount); i++)
            {
                // queueReference.AddMessageAsync(new CloudQueueMessage($"my test message {i}"));
                System.Console.WriteLine("test");
            }

            System.Console.WriteLine($"{messageCount} message added to requested queue");
            
        }
    }
}
