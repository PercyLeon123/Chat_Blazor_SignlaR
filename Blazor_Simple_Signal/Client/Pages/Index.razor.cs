using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        protected List<string> ListUsuario = new List<string>();
        protected List<string> messages = new List<string>();

        protected override async Task OnInitializedAsync() 
        {
            hubConnection = new HubConnectionBuilder()
                .WithUrl(navigationManager.ToAbsoluteUri("/chatHub"))
                .Build();

            hubConnection.On<string, string, string>("ReceiveMessage", (user, message, listA) =>
            {
                var encodedMsg = $"{user} : {message}";

                messages.Add(encodedMsg);
                ListUsuario.Add(listA);
    
                StateHasChanged();
            });

            await hubConnection.StartAsync();            
        }

        protected Task Send() =>
            hubConnection.SendAsync("SendeMessage", userInput, messageInput);

        public bool IsConnected => hubConnection.State == HubConnectionState.Connected;

        protected Task Send2() =>
            hubConnection.SendAsync("PrivateSendMessage", userInput, messageInput, idU);

    }
}
