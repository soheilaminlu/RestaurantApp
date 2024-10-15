using Confluent.Kafka;
using System.Runtime.CompilerServices;

namespace WaiterAPP.Logging
{
    public static partial class KafkaLoggs
    {
        [LoggerMessage(EventId = 1, Level = LogLevel.Error, Message = "Failed to consume Message {exception}")]
        public static partial void LogFailedToConsume(this ILogger logger, ConsumeException exception);

        [LoggerMessage(EventId = 2, Level = LogLevel.Error, Message = "Failed to Produce Message {exception}")]
        public static partial void LogFailedToProduce(this ILogger logger, ProduceException exception);


        [LoggerMessage(EventId = 3, Level = LogLevel.Error, Message = "init")]


        [LoggerMessage(EventId = 4, Level = LogLevel.Error, Message = "init")]


        [LoggerMessage(EventId = 5, Level = LogLevel.Error, Message = "init")]


        [LoggerMessage(EventId = 6, Level = LogLevel.Error, Message = "init")]


        [LoggerMessage(EventId = 7, Level = LogLevel.Information, Message = "Consumer Subscribe to topic {topic}")]
        public static partial void LogSubscribeToTopic(this ILogger logger, string topic);

        [LoggerMessage(EventId = 8, Level = LogLevel.Information , Message = "init")]

    }
}
