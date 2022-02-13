using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp6._0
{
    public class StringInterpolationEx
    {
        static double Add(double a, double b)
        {
            double c = a + b;

            return c;

        }

        static void Main()
        {
            double a = 10, b = 15;


            Console.WriteLine($"The Addition of {a} and {b} is: {StringInterpolationEx.Add(a, b)}");


            Console.ReadKey();
        }

    }
}
