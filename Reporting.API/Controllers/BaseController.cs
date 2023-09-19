using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Reporting.Domain.Models;

namespace Reporting.API.Controllers
{
    public class BaseController : ControllerBase
    {
        private ProducerConfig _configuration;
        private readonly IConfiguration _config;
        public BaseController(ProducerConfig configuration, IConfiguration config)
        {
            _configuration = configuration;
            _config = config;
        }

        [NonAction]
        public async Task ProduceAsync(ReportingDTO report)
        {
            string serializedData = JsonConvert.SerializeObject(report);

            var topic = _config.GetSection("TopicName").Value;

            using (var producer = new ProducerBuilder<Null, string>(_configuration).Build())
            {
                await producer.ProduceAsync(topic, new Message<Null, string> { Value = serializedData });
                producer.Flush(TimeSpan.FromSeconds(10));
            }

        }

        //public static async Task ProduceAsync()
        //{
        //    var config = new ProducerConfig
        //    {
        //        BootstrapServers = "localhost:7076"
        //    };

        //    using (var producer = new ProducerBuilder<Null, string>(config).Build())
        //    {
        //        try
        //        {
        //            while (true)
        //            {
                      

        //                var email = new
        //                {
        //                    to = 1,
        //                    subject = "Test"
        //                };

        //                var emailMessage = JsonConvert.SerializeObject(email);

        //                var result = await producer.ProduceAsync("testTopic", new Message<Null, string> { Value = emailMessage });
        //                Console.WriteLine($"\nGönderilen: '{result.Value}' Topic: '{result.TopicPartitionOffset}'\n");
        //            }
        //        }
        //        catch (ProduceException<Null, string> ex)
        //        {
        //            Console.WriteLine(ex.Error.Reason);
        //        }
        //    }
        //}
    }
}
