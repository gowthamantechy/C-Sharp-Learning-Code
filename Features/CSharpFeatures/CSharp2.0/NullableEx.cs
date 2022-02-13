using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Nullable;
using static System.Console;

namespace CSharpFeatures.CSharp2._0
{
    public class NullableEx
    {

        static void Main(string[] args)
        {
            
            Nullable<int> a = 10;
            Nullable<char> c = 'S';
            Nullable<bool> b = false;
            Nullable<double> d = 10.10;
            

            WriteLine("The value of a is:{0}", a);

            a = null;

            if(a.HasValue)
            {
                WriteLine(a.Value);
            }
            else
            {
                WriteLine("It contains null value");
            }

            ReadKey();
        }


    }
}
