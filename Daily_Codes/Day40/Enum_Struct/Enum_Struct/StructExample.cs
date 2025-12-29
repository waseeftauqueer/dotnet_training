using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Struct
{
    public interface IShape
    {
        double GetArea();
    }


    public struct Rectangle : IShape
    {
        public double Breadth { get; set; }
        public double Length { get; set; }

        public Rectangle(double l, double b)
        {
            Length = l;
            Breadth = b;
        }

        public double GetArea()
        {
            return Length * Breadth;
        }
    }

    internal class StructExample
    {

    }
}
