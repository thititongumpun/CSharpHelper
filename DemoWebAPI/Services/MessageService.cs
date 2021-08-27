using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DemoWebAPI.Controllers.TestController;

namespace DemoWebAPI.Services
{
    public interface IMessageService
    {
        bool Enqueue(Payload msg);
    }
    public class MessageService : IMessageService
    {
        ConnectionFactory _factory;
        IConnection _conn;
        IModel _channel;
        public MessageService()
        {
            Console.WriteLine($"Connecting rabbitMQ...");

            // _factory = new ConnectionFactory() { HostName = "rabbitmq", Port = 5672 };
            _factory = new ConnectionFactory()
            {
                Uri = new Uri("amqp://user:password@localhost:5672")
            };
            _factory.UserName = "user";
            _factory.Password = "password";
            _conn = _factory.CreateConnection();
            _channel = _conn.CreateModel();
            _channel.QueueDeclare(queue: "hello",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);
        }

        public bool Enqueue(Payload msg)
        {
            var body = Encoding.UTF8.GetBytes($"server processed {msg.payload}");
            _channel.BasicPublish(exchange: "",
                                routingKey: "hello",
                                basicProperties: null,
                                body: body);
            Console.WriteLine(" [x] Published {0} to RabbitMQ", msg.payload);
            return true;
        }
    }
}
