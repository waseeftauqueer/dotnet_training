using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter notification type (email,sms,push): ");
            string type = Console.ReadLine();

            INotification notification = NotificationFactory.GetNotification(type);

            notification.Send(" this is n notification!");

            Console.WriteLine("notification sent successfully");
        }
    }

}
