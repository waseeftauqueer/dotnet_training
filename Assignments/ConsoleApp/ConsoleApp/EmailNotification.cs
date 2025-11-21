using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending EMAIL: {message}");
        }
    }

    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending PUSH notification: {message}");
        }
    }

}
