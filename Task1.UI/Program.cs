using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Logic;
using Task1.MessageListeners;

namespace Task1.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var msgSender = new MessageSender();
            var phone = new Mobile(msgSender);
            var tablet = new Tablet(msgSender);

            Console.WriteLine("Message body: ");
            string msg = Console.ReadLine();

            string timeText;
            int time;

            do
            {
                Console.WriteLine("Send after (ms): ");
                timeText = Console.ReadLine();
            } while (!int.TryParse(timeText, out time));

            msgSender.SendMessage(msg, time);

            Console.ReadKey();
        }
    }
}
