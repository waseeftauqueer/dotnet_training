using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    using System;
    using System.IO;

    public class Logger
    {
        private static readonly Lazy<Logger> instance =
            new Lazy<Logger>(() => new Logger());

        public static Logger Instance => instance.Value;

        private Logger() { }

        public void WriteLog(string message)
        {
            string logMessage = $"{DateTime.Now}: {message}";
            File.AppendAllText("log.txt", logMessage + Environment.NewLine);
            Console.WriteLine("Logged: " + logMessage);
        }
    }

}
