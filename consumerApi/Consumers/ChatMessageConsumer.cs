using MassTransit;
using Shared.Messages;

namespace ConsumerApi.Consumers;

public class ChatMessageConsumer : IConsumer<ChatMessage>
{
    public Task Consume(ConsumeContext<ChatMessage> context)
    {
        var message = context.Message;
        Console.WriteLine($"[{message.SentAt:HH:mm:ss}] {message.Sender}: {message.Text}");
        return Task.CompletedTask;
    }
}
