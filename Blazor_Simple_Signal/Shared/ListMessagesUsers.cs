using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blazor_Simple_Signal.Shared
{
    public class ListMessagesUsers
    {
        public List<MessagesUser> List_MenssagesUsers { get; set; } = new List<MessagesUser>();

        public void AddUser(User user) 
        {
            if (List_MenssagesUsers.Where(x => x.User.Id == user.Id).ToList().Count == 0) 
            {
                MessagesUser MessagesUser = new MessagesUser(){ User = user, Estado = true, ListMessages = new List<string>() };
                List_MenssagesUsers.Add(MessagesUser);
            }
        }

        public void FindUser(User user, string message)
        {
            List_MenssagesUsers.Find(x => x.User.Id == user.Id).ListMessages.Add(message);
        }
    }
}
