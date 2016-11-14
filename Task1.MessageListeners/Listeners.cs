using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Logic;

namespace Task1.MessageListeners
{
    public sealed class Mobile
    {
        public Mobile(MessageSender msgSender)
        {
            msgSender.NewMessage += MobileNewMessage;
        }

        private void MobileNewMessage(object sender, NewMessageEventArgs e)
        {
            Console.WriteLine("Mobile phone: new message!");
            Console.WriteLine("Message: {0}", e.Message);
        }
    }

    public sealed class Tablet
    {
        public Tablet(MessageSender msgSender)
        {
            msgSender.NewMessage += TabletNewMessage;
        }

        private void TabletNewMessage(object sender, NewMessageEventArgs e)
        {
            Console.WriteLine("Tablet: new message!");
            Console.WriteLine("Message: {0}", e.Message);
        }
    }
}
