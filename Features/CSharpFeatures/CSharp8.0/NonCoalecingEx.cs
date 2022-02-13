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
            List<int> numbers = null;
            int? i = null;
             
            //numbers ??= new List<int>();
            //numbers.Add(i ??= 17);
            //numbers.Add(i ??= 20);

            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
        
    }
}
