using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace EmanueliMonteiroChat.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string name, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", name, message);
        }

        public async Task TypingMessage(string name, string message)
        {
            await Clients.Group.SendAsync("ReceiveMessage", name, message);
        }


    }
}

