using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_Simple_Signal.Server.Services
{
    public class ChatHub : Hub
    {
        public string UserName;
        public async Task SendeMessage(string user, string message) 
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message, Context.ConnectionId);
            
        }

        public override async Task OnConnectedAsync() 
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", "Welcome", "Hello World", Context.ConnectionId);
            ConnectedUser.ListUser.Add(new User { Id = Context.ConnectionId, Name = "" });
            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception e) 
        {
            await Clients.All.SendAsync("ReceiveMessage", ""); // Falta
            await base.OnDisconnectedAsync(e);
        }

        public async Task PrivateSendMessage(string user, string message, string idUser)
        {
            await Clients.Client(idUser).SendAsync("ReceiveMessage", user, message, ConnectedUser.ListUser.Count.ToString());

        }
    }
}
