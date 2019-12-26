using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.DIP.RIGHT
{
    interface IMessage
    {
        void SendMessage();
    }

    class Email:IMessage
    {
        public string ToAddress { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public void SendMessage()
        {
            //Send email
        }
    }

    class SMS:IMessage
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public void SendMessage()
        {
            //Send sms
        }
    }

    class Notification
    {
        private readonly IEnumerable<IMessage> _messages;
        public Notification(IEnumerable<IMessage> messages)
        {
            _messages = messages;
        }

        public void Send()
        {
            foreach (var message in _messages)
            {
                message.SendMessage();
            }
        }
    }
}
