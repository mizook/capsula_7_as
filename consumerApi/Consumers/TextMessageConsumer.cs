using MassTransit;
using Shared.Messages;

namespace ConsumerApi.Consumers;

public class TextMessageConsumer : IConsumer<TextMessage>
{
    public Task Consume(ConsumeContext<TextMessage> context)
    {
        Console.WriteLine($"Mensaje recibido: {context.Message.Text}");
        return Task.CompletedTask;
    }
}
