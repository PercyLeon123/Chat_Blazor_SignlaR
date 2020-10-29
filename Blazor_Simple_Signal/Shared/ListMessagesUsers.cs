using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blazor_Simple_Signal.Shared
{
    public class ListMessagesUsers
    {
        public List<MessagesUser> List_MenssagesUsers { get; set; } = new List<MessagesUser>();

        public void AddUser(string group) 
        {
            if (List_MenssagesUsers.Where(x => x.Group == group).ToList().Count == 0) 
            {
                MessagesUser MessagesUser = new MessagesUser(){ Group = group, ListMessages = new List<string>() };
                List_MenssagesUsers.Add(MessagesUser);
            }
        }
        public void FindUser(string group, string message)
        {
            List_MenssagesUsers.Find(x => x.Group == group).ListMessages.Add(message);
        }
    }
}
