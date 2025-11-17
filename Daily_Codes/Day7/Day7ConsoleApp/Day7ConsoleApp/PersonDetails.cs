using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7ConsoleApp
{
    internal sealed class PersonDetails
    {
        public string Email { get; set; }
        public string LockerNumber { get; set; }
        public string GenericPassword { get; set; }

        public void GetPersonDetails()
        {
            Email = Console.ReadLine();
            LockerNumber = Console.ReadLine();
            GenericPassword = Console.ReadLine();

            Console.WriteLine(Email);
            Console.WriteLine(LockerNumber);
            Console.WriteLine(GenericPassword);
        }
    }

    // This will cause compile time error as PersonDetails is sealed , public class EmployeeDetails : PersonDetails { }
}
