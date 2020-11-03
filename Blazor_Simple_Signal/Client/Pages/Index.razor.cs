using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazor_Simple_Signal.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace Blazor_Simple_Signal.Client.Pages
{
    public class IndexBase : ComponentBase
    {
        [Inject] protected NavigationManager navigationManager { get; set; }

        protected HubConnection hubConnection;
        protected User UserChat = new User();
        protected string messageInput = "";
        protected bool stateUser = false;
        protected string newUsuario = "";
        protected bool newUserMessage = false;
        protected bool privatemessage = false;

        protected List<User> ListUsuario = new List<User>();
        protected List<string> messages = new List<string>();
        protected ListMessagesUsers ListMessagesUsers = new ListMessagesUsers();

        protected override async Task OnInitializedAsync() 
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.ToAbsoluteUri("/chatHub"))
                .Build();

            hubConnection.On<MessagesUser>("ReceiveMessageU", (messageUser) =>
            {
                //var encodedMsg = $"{message}";
                //messages.Add(encodedMsg);
                //StateHasChanged();
            });

            hubConnection.On<User, string>("ReceiveSendPrivateMessage", (user, message) =>
            {
                Console.WriteLine("ON :" + user.Id);
                ListMessagesUsers.AddUser(user);
                ListMessagesUsers.FindUser(user, $"{user.Name}: {message}");
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

        //protected Task Send() =>
        //    hubConnection.SendAsync("SendMessage", $"<b>{userInput}</b> : {messageInput}");

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
            StateHasChanged();
        }

        protected async Task RenderMessage() 
        {
            newUserMessage = true;
            await Task.Delay(3000);
            newUserMessage = false;
            StateHasChanged();
        }
    }
}
