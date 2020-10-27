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
        protected string id = "";
        protected string userInput = "";
        protected string messageInput = "";
        protected string idU = "";
        protected bool stateUser = false;
        protected string newUsuario = "";
        protected bool newUserMessage = false;

        protected List<User> ListUsuario = new List<User>();
        protected List<string> messages = new List<string>();

        protected override async Task OnInitializedAsync() 
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.ToAbsoluteUri("/chatHub"))
                .Build();

            hubConnection.On<string>("ReceiveMessage", (message) =>
            {
                var encodedMsg = $"{message}";
                messages.Add(encodedMsg);
                StateHasChanged();
            });

            hubConnection.On<string>("LogInMessage", (user) =>
            {
                RenderMessage();
                newUsuario = user;
                StateHasChanged();
            });

            hubConnection.On<string>("LogIn", (user) =>
            {
                stateUser = true;
                StateHasChanged();
            });

            hubConnection.On<List<User>>("ListUser", (listUser) =>
            {
                ListUsuario = listUser;
                StateHasChanged();
            });

        }

        protected Task Send() =>
            hubConnection.SendAsync("SendMessage", $"<b>{userInput}</b> : {messageInput}");

        protected async Task SendLogIn() 
        {
            await hubConnection.StartAsync();
            await hubConnection.SendAsync("LogInMessage", userInput);
            await hubConnection.SendAsync("LogIn", userInput);
        }

        public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

        protected Task Send2() =>
            hubConnection.SendAsync("PrivateSendMessage", userInput, messageInput, idU);

        protected async Task RenderMessage() 
        {
            newUserMessage = true;
            await Task.Delay(3000);
            newUserMessage = false;
            StateHasChanged();
        }
    }
}
