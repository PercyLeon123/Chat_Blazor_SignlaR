using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_Simple_Signal.Client.Helpers;
using Blazor_Simple_Signal.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace Blazor_Simple_Signal.Client.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] protected NavigationManager navigationManager { get; set; }
        [Inject] public Comun SingletonComun { get; set; }

        protected HubConnection hubConnection;
        protected User UserChat = new User();
        protected string messageInput = "";
        protected bool stateUser = false;
        protected string newUsuario = "";
        protected bool newUserMessage = false;
        protected bool privatemessage = false;
        protected string bg = "";

        protected List<User> ListUsuario = new List<User>();
        protected List<string> messages = new List<string>();
        protected ListMessagesUsers ListMessagesUsers = new ListMessagesUsers();

        protected override async Task OnInitializedAsync() 
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.ToAbsoluteUri("/chatHub"))
                .Build();

            hubConnection.On<UserMessage>("ReceiveSendMessage", (userMessage) =>
            {
                ListMessagesUsers.AddUser(userMessage.User);
                ListMessagesUsers.FindUser(userMessage.User, $"{userMessage.User.Name}: {userMessage.Message}");
                StateHasChanged();
            });

            hubConnection.On<User, string>("ReceiveSendPrivateMessage", (user, message) =>
            {

                ListMessagesUsers.AddUser(user);
                ListMessagesUsers.FindUser(user, $"{user.Name}: {message}");
                Aviso();
                StateHasChanged();
            });

            hubConnection.On<string>("ReceiveSendLogIn", (user) =>
            {
                RenderMessage();
                newUsuario = user;
                StateHasChanged();
            });

            hubConnection.On<List<User>>("ListUser", (listUser) =>
            {
                ListUsuario = listUser;
                StateHasChanged();
            });

        }

        protected async Task SendLogIn() 
        {
            await hubConnection.StartAsync();
            await hubConnection.SendAsync("SendLogIn", UserChat.Name);
        }

        public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

        protected async Task SendPrivateMessage(UserMessage userMessage) 
        {
            ListMessagesUsers.FindUser(userMessage.User, userMessage.Message);
            await hubConnection.SendAsync("SendPrivateMessage", userMessage, UserChat);
        }

        protected void CreateChatUser(User user) 
        {
            ListMessagesUsers.AddUser(user);
            ListMessagesUsers.List_MenssagesUsers.Find(x => x.User.Id == user.Id).Estado = true;
            StateHasChanged();
        }

        protected async Task RenderMessage() 
        {
            newUserMessage = true;
            await Task.Delay(3000);
            newUserMessage = false;
            StateHasChanged();
        }
        private async Task Aviso()
        {
            bg = "bg-danger";
            StateHasChanged();
            await Task.Delay(2000);
            bg = "";
            StateHasChanged();
        }
    }
}
