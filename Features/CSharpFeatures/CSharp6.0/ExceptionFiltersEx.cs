using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp6._0
{
    public class ExceptionFiltersEx
    {

        static void Main(string[] args)
        {
            try
            {
                int[] a = new int[5];
                a[10] = 12;
            }
            catch (Exception e) when (e.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                Console.WriteLine(e.Message);

                SomeOtherTask();
            }

            

            Console.ReadKey();  
        }

        static void SomeOtherTask()
        {
            Console.WriteLine("A new task is executing...");
        }

    }
}
