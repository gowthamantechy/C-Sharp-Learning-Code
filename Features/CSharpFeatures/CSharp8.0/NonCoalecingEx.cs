using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpFeatures.CSharp8._0
{
    public class NonCoalecingEx
    {
              
        public static void Main()
        {

            string str1 = null;

            string str2 = null;

            string str3 = null;

            string str4 = "Hello, World";

            string final = str1 ?? str2 ?? str3 ?? str4;

            Console.WriteLine($"The final is : {final}");



            /* List<int> numbers = null;
             int? i = null;

             //numbers ??= new List<int>();
             //numbers.Add(i ??= 17);
             //numbers.Add(i ??= 20);

             Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
             Console.WriteLine(i);  // output: 17*/

            Console.ReadKey();

        }
        
    }
}
