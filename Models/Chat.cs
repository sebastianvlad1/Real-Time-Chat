using System.Collections.Generic;

namespace ChatApp.Models
{
    public class Chat {

        public Chat(){
            Messages = new List<Message>();
            ChatUsers = new List<ChatUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<ChatUser> ChatUsers { get; set; }
        public ChatType Type { get; set; }
    }
}