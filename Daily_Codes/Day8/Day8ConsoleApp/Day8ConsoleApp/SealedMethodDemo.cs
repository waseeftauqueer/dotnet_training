using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    public class Vehicle
    {
        public virtual void Start()
        {
            Console.WriteLine("Run for pre-run checks");
        }
    }
    public class Car : Vehicle
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Car: start with key");
        }
    }

    public class ElectricCar : Car
    {
        public sealed override void Start()
        {
            base.Start();
            Console.WriteLine("Electric Car : start with button");
        }
    }
    internal class SealedMethodDemo
    {

    }
}
