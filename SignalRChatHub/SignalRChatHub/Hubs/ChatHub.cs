using Microsoft.AspNetCore.SignalR;

namespace SignalRChatHub.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            Clients.All.SendAsync("RecieveMessage",user,message);
        }
    }
}
