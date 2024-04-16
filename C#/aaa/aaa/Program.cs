using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 3.hodina_2 samostatna prace
{
    class Program
    {
        static void Main(string[] args)
        {
           class ComplexNumber
            {
            public double Real;
            public double Imaginary;

            public ComplexNumber(double real, double imaginary)
            {
                Real = real;
                Imaginary = imaginary;
            }

            public ComplexNumber add(ComplexNumber other)
            {
                return new ComplexNumber(Real + other.Real, Imaginary + other.Imaginary);
            }

            public ComplexNumber substract(ComplexNumber other)
            {
                return new ComplexNumber(Real - other.Real, Imaginary - other.Imaginary);
            }

            public ComplexNumber multiply(ComplexNumber other)
        {
            return new ComplexNumber(Real * other.Real - Imaginary * other.Imaginary, Imaginary * other.Real + Real * other.Imaginary)
        }
            }
        }
    }
}
