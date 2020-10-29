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
        [Parameter] public MessagesUser MessagesUser { get; set; }
        [Parameter] public EventCallback<GroupMessage> SendMessagePrivate { get; set; }

        protected GroupMessage GroupMessage = new GroupMessage();
        protected override void OnInitialized()
        {
            GroupMessage.Group = MessagesUser.Group;
            base.OnInitialized();
        }



    }
}
