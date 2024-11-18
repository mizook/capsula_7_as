namespace Shared.Messages;

public class ChatMessage
{
    public string? Sender { get; set; }
    public string? Text { get; set; }
    public DateTime SentAt { get; set; } = DateTime.UtcNow;
}