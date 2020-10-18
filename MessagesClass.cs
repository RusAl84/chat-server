using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chat_server
{
    [Serializable]
    public class message
    {
        public message(string username, string text, DateTime timestamp)
        {
            this.username = username;
            this.text = text;
            this.timestamp = timestamp;
        }
        public message()
        {
            this.username = "Server";
            this.text = "Server is running";
            this.timestamp = DateTime.UtcNow;
        }
        public message(string username, string text)
        {
            this.username = username;
            this.text = text;
            this.timestamp = DateTime.UtcNow;
        }
        public string username { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }
    }
    [Serializable]
    public class MessagesClass
    {
        public  List<message> messages = new List<message>();

        public MessagesClass(List<message> messages)
        {
            messages.Clear();
            message ms = new message();
            messages.Add(ms);
        }

        public MessagesClass()
        {
            messages.Clear();
            message ms = new message();
            messages.Add(ms);
        }

        public void Add(string username, string text)
        {
            message msg = new message(username, text);
            messages.Add(msg);
            Console.WriteLine($"Сообщение: {text}  номер {messages.Count}");
        }

        public void Add(message msg)
        {
            msg.timestamp = DateTime.UtcNow;
            messages.Add(msg);
            Console.WriteLine($"Сообщений:  {messages.Count}");
        }

    }
}
