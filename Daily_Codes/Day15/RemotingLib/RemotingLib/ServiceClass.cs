using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 

namespace RemotingLib
{
        public class ServiceClass : MarshalByRefObject, IMyinter
        {
            public string Show(string name)
            {
                Console.WriteLine($"Message Recevied from the client is {name}");
                return $"Hello {name} How Are You!!";
            }
        }

}
