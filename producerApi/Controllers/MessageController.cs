using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Shared.Messages;

[ApiController]
[Route("[controller]")]
public class MessageController : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint;

    public MessageController(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] TextMessage message)
    {
        Console.WriteLine($"Mensaje enviado: {message.Text}");
        await _publishEndpoint.Publish(message);
        return Ok("Mensaje enviado");
    }
}
