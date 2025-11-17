using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8ConsoleApp
{
    public abstract class ShippingCalculator
    {
        public virtual string Provider => "General Shipping Amount";
        public abstract decimal Calculate(decimal weight, string zone);
    }

    public class StandardShipping : ShippingCalculator
    {
        public override string Provider => "Standard Shipping Amount";
        public override decimal Calculate(decimal weight, string zone)
        {
            return 
        }
    }
    public class ExpressShipping : ShippingCalculator
    {
        public override string Provider => "Express Shipping Amount";
        public override decimal Calculate(decimal weight, string zone)
        {
            return
        }
    }
    public class InternationalShipping: ShippingCalculator
    {
        public override string Provider => "Iternational Shipping Amount";
        public override decimal Calculate(decimal weight, string zone)
        {
            return
        }
    }
}
