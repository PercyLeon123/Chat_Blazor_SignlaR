using Blazor_Simple_Signal.Server.Services;
using Blazor_Simple_Signal.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor_Simple_Signal.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        [HttpPost]
        public string Post(UserMessage userMessage)
        {
            ChatHub ChatHub = new ChatHub();

            ChatHub.SendMessage(userMessage);
            return "ok";
        }
    }
}
