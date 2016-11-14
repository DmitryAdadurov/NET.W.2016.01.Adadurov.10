using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Logic
{
    public sealed class NewMessageEventArgs : EventArgs
    {
        private readonly string _message;

        public NewMessageEventArgs(string message)
        {
            _message = message;
        }

        public string Message { get { return _message; } }
    }

    public class MessageSender
    {
        public event EventHandler<NewMessageEventArgs> NewMessage = delegate { };

        protected virtual void OnNewMessage(NewMessageEventArgs e)
        {
            EventHandler<NewMessageEventArgs> temp = NewMessage;
            temp.Invoke(this, e);
        }

        public void SendMessage(string message, int sendAfter)
        {
            if (sendAfter > 0)
            {
                Thread.Sleep(sendAfter);
            }
            OnNewMessage(new NewMessageEventArgs(message));
        }
    }
}
