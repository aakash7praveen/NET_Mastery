using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public class EmailService : INotificationHandler
    {
        public void Send(string To, string From)
        {
            Console.WriteLine($"Sending message from {From} to {To}");
        }
    }
}
