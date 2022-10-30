
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeChatApp
{
    public class Message
    {
        public string? SenderName { get; set; }
        public string? Text { get; set; }
        public DateTime SendedTime { get; set; }

    }
}