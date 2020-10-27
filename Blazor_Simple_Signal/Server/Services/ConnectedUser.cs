using Blazor_Simple_Signal.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Blazor_Simple_Signal.Server.Services
{
    public static class ConnectedUser
    {
        public static List<User> ListUser  { get; set; } = new List<User>();
    }
}
