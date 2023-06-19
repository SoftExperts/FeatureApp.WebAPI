using DTOs;
using Microsoft.AspNetCore.SignalR;

namespace Services.Chat
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string text)
        {
            var message = new ChatMessageDto
            {
                SenderName = name,
                Text = text,
                SentAt = DateTimeOffset.UtcNow
            };

            // Broadcast to all clients
            await Clients.All.SendAsync(
                "ReceiveMessages",
                message.SenderName,
                message.SentAt,
                message.Text);

        }
    }
}
