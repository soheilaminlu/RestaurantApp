using Confluent.Kafka;
using WaiterAPP.Logging;

namespace WaiterAPP.Kafka
{
    public class ConfigKafka
    {
      private readonly ILogger<ConfigKafka> _logger;

        public Task<string> ConsumeAsync(string topic)
        {
            using (var consumer = CreateConsumer())
            {
                consumer.Subscribe(topic);
                KafkaLoggs.LogSubscribeToTopic(_logger , topic);
                try
                {
                    var consumeResult = consumer.Consume(TimeSpan.FromSeconds(10));
                    if (consumeResult != null)
                    {
                        return consumeResult.Message.Value;
                    }
                }
                catch (ConsumeException ex)
                {
                    KafkaLoggs.LogFailedToConsume(_logger , ex);
                }
            }
        }

        public async Task<string> ProduceAsync(string topic , string key , string value)
        {
            try
            {
                using (var producer = CreateProducer())
                {
                    var message = new Message<string, string>()
                    {
                        Key = key,
                        Value = value
                    };
                   var deliverResult = await producer.ProduceAsync(topic, message);
                    return deliverResult.Message.Value;
                }

            } catch (ProduceException ex) 
            {
                KafkaLoggs.LogFailedToProduce(_logger, ex);
            }
           
        }

        private IConsumer<string , string> CreateConsumer()
        {
            var config = new ConsumerConfig()
            {
                BootstrapServers = "localhost:9092",
                GroupId = "WaitersGroup",
                EnableAutoCommit = true,
                AutoOffsetReset = AutoOffsetReset.Earliest
            };
            return new ConsumerBuilder<string , string>(config).Build();
        }
        private IProducer<string , string> CreateProducer()
        {
            var config = new ProducerConfig()
            {
                BootstrapServers = "localhost:9092",
                Acks = Acks.All
            };
            return new ProducerBuilder<string , string>(config).Build();
        }
    }
}
