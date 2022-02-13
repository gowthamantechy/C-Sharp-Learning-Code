using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpFeatures.CSharp2._0
{
    public class IteratorsEx
    {

        public static IEnumerable<string> GetNames()
        {
            List<string> names = new List<string>();

            names.Add("Venki");
            names.Add("Benki");
            names.Add("Sanki");

            foreach (var item in names)
            {
                yield return item;
            }

           
        }


        static void Main()
        {


            IEnumerable<string> elements = GetNames();

            foreach (var element in elements)
            {
                WriteLine(element);
            }

            

            ReadKey();
        }
    }
}
