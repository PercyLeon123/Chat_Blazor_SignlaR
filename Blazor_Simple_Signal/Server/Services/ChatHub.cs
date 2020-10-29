using Blazor_Simple_Signal.Shared;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor_Simple_Signal.Server.Services
{
    public class ChatHub : Hub
    {
        public string UserName;

        public async Task SendMessage( string message) 
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }

        public async Task LogInMessage(string user) 
        {
            ConnectedUser.ListUser.Add(new User { Id = Context.ConnectionId, Name = user });
            await Clients.All.SendAsync("ListUser", ConnectedUser.ListUser);
            await Clients.All.SendAsync("LogInMessage", user);
        }

        public async Task ReceivePrivateMessage(string user, GroupMessage groupMessage) 
        {
            await Clients.Group(groupMessage.Group).SendAsync("ReceivePrivateMessage", groupMessage.Group, $"{user} : {groupMessage.Message}");
        }

        public override async Task OnConnectedAsync() 
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ReceiveMessage", "Welcome, Hello World");
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

        /* Grupos */

        public async Task CreateGroup(string groupName, User user)
        {
            await Groups.AddToGroupAsync(Context.ConnectionId, groupName+user.Name);
            await Groups.AddToGroupAsync(user.Id, groupName + user.Name);
            await Clients.Group(groupName + user.Name).SendAsync("CreateGroup", groupName + user.Name, true);
        }

        //public async Task LeaveRoomAsync(string groupName)
        //{
        //    await Groups.RemoveFromGroupAsync(Context.ConnectionId, groupName);
        //}

        public async Task MessageGroup(string groupName, string message)
        {
            await Clients.Group(groupName).SendAsync("OnMessage", message);
        }
    }
}
