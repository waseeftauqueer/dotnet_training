using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.Instance.WriteLog("Application started");
            Logger.Instance.WriteLog("User logged in");
            Logger.Instance.WriteLog("Application ended");
        }
    }
}
