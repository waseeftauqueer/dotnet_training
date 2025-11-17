using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9ConsoleApp
{
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }
        public string LastOperator = "";
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public static Complex operator +(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
            result.LastOperator = "+ Addition";
            return result;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
            result.LastOperator = "- Subtraction";
            return result;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex result = new Complex(a.Real * b.Real, a.Imaginary * b.Imaginary);
            result.LastOperator = "* Multiplication";
            return result;
        }
        public static bool operator ==(Complex a, Complex b)
        {
            return (a.Real == b.Real && a.Imaginary == b.Imaginary);
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return $"Operation : {LastOperator} -> Result = {Real} + {Imaginary}";
        }
        public override bool Equals(object obj) 
        {
            if (obj is Complex other)
            {
                return this.Real == other.Real && this.Imaginary == other.Imaginary;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return Real.GetHashCode() ^Imaginary.GetHashCode();
        }
    }
    internal class OperatorOverloading
    {
        // Operator Overloading
    }
}
