using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ConsumerConfig
        {
            BootstrapServers = "localhost:7076", 
            GroupId = "dotnet-consumer",
            AutoOffsetReset = AutoOffsetReset.Earliest,
        };

        using var consumer = new ConsumerBuilder<string, string>(config).Build();
        
        var topic = "test"; 

        consumer.Subscribe(topic);

        Console.WriteLine("Consumer listening...");

        while (true)
        {
            try
            {
                var consumeResult = consumer.Consume();

                if (consumeResult != null)
                {
                    Console.WriteLine($"Received message: Key: {consumeResult.Message.Key}, Value: {consumeResult.Message.Value}");
                }
            }
            catch (ConsumeException ex)
            {
                Console.WriteLine($"Error: {ex.Error.Reason}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
