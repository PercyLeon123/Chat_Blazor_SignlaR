using Blazor_Simple_Signal.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Simple_Signal.Client.Shared
{
    public class ChatUserPrivateBase : ComponentBase
    {
        /* Observacion este componente guarda datos del destinatario */
        [Parameter] public MessagesUser MessagesUser { get; set; }
        [Parameter] public EventCallback<UserMessage> SendMessagePrivate { get; set; }

        protected UserMessage UserMessage = new UserMessage();

        protected override void OnInitialized()
        {
            UserMessage.User = MessagesUser.User;
            base.OnInitialized();
        }

        protected void SendMessage() 
        {
            SendMessagePrivate.InvokeAsync(UserMessage);
            UserMessage.Message = "";
        }

    }
}
