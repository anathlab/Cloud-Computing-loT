using Shared;
using System;

namespace App.ClientOne
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "localhost";
            string queue = QueueNames.HELLO_WORLD;

            Console.WriteLine("Welcome in ClientOne application. To quit press any key.");

            var rabbitMQManager = new RabbitMQManager(host);

            using (var connection = rabbitMQManager.Factory.CreateConnection())
            using(var channel = connection.CreateModel())
            {
                rabbitMQManager.SubscribeQueue(channel, queue, (message) =>
                {
                    Console.WriteLine($">>> Received message: '{message}' <<<");
                });

                Console.ReadKey();
            }
          
        }
    }
}
