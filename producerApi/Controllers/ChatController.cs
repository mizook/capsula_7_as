using MassTransit;
using Microsoft.AspNetCore.Mvc;
using Shared.Messages;

[ApiController]
[Route("[controller]")]
public class ChatController : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint;

    public ChatController(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost]
    public async Task<IActionResult> SendMessage([FromBody] ChatMessage chatMessage)
    {
        await _publishEndpoint.Publish(chatMessage);
        return Ok("Mensaje de chat enviado");
    }
}
