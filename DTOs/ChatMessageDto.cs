namespace DTOs
{
    public class ChatMessageDto
    {
        public string SenderName { get; set; } = string.Empty;

        public string Text { get; set; } = string.Empty;

        public DateTimeOffset SentAt { get; set; }
    }
}
