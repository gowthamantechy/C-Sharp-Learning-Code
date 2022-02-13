using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
using static System.Console;


namespace CSharpFeatures.CSharp6._0
{
    public class StaticDirectiveEx
    {
        static double Find_Area_Circle(double r)
        {
            return PI * r * r;
        }

        static void Main()
        {
            double radius = 5;

           WriteLine($"The Area of Circle of Radius {radius} is: {StaticDirectiveEx.Find_Area_Circle(radius)}");

           ReadKey();
        }
    }
}
