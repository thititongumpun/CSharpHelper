using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace Worker.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Payload pl = new Payload();
            
            Console.WriteLine("Sleeping to wait for Rabbit");
            Task.Delay(1000).Wait();
            Console.WriteLine("Posting messages to webApi");
            for(int i = 0; i < 200; i++)
            { 
                BatchPostMessage(pl).Wait();
            }

            Task.Delay(1000).Wait();

            Console.WriteLine("Consuming Queue Now....");            
            // ConnectionFactory factory = new ConnectionFactory() { HostName = "rabbitmq", Port = 5672 };
            ConnectionFactory factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://user:password@localhost:5672")
            };
            factory.UserName = "user";
            factory.Password = "password";
            IConnection conn = factory.CreateConnection();
            IModel channel = conn.CreateModel();
            channel.QueueDeclare(queue: "hello",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

            var consumer = new EventingBasicConsumer(channel);
            consumer.Received += (model, ea) =>
            {
                var body = ea.Body.ToArray(); 
                var message = Encoding.UTF8.GetString(body);
                Console.WriteLine(" [x] Received from Rabbit: {0}", message);
            };
            channel.BasicConsume(queue: "hello",
                                    autoAck: true,
                                    consumer: consumer);

            Console.ReadLine();
        }

        public static async Task PostMessage(string postData)
        {
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            using var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            using var client = new HttpClient(httpClientHandler);
            var result = await client.PostAsync("http://localhost:5000/api/test", content);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine($"Server return : {resultContent}");
        }

        public static async Task BatchPostMessage(dynamic postData)
        {
            var json = JsonSerializer.Serialize(postData);
            var content = new StringContent(json, UnicodeEncoding.UTF8, "application/json");

            using var httpClientHandler = new HttpClientHandler();
            httpClientHandler.ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => { return true; };

            using var client = new HttpClient(httpClientHandler);
            var result = await client.PostAsync("http://localhost:5000/api/test", content);
            string resultContent = await result.Content.ReadAsStringAsync();
            Console.WriteLine($"Server return : {resultContent}");
        }

        public class Payload
        {
            public string payload { get; init;} = "haha";
        }
    }
}
