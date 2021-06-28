using System;
using Confluent.Kafka;

namespace Microservices_Kafka
{
    class Program
    {
        static void Main(string[] args)
        {
            const string server = "127.0.0.1:9092";
            const string topicName = "kafka-test";

            var adminClient = new Confluent.Kafka.AdminClientBuilder(
                new AdminClientConfig
                {
                    BootstrapServers = server,
                    SecurityProtocol = SecurityProtocol.Plaintext
                }
                ).Build();

            var metaData = adminClient.GetMetadata(TimeSpan.FromMinutes(1));
            
            Console.WriteLine("Hello World!");
        }
    }
}