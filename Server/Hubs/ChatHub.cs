using Microsoft.AspNetCore.SignalR;
using System.Linq;
using TestDLL;

namespace BlazorWebAssemblySignalRApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        private Users users;
        public ChatHub() 
        {
            users= new Users();
            users.Add("aaa", "aaa@gmail.com");
            users.Add("bbb", "bbb@gmail.com");
        }

        public async Task SendMessage(string user, string message)
        {
            var usr = users[user]?.ToString();
            await Clients.All.SendAsync("ReceiveMessage", usr, message);
        }
    }
}
