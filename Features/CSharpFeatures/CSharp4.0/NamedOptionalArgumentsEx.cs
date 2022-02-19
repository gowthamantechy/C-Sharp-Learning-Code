using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp4._0
{
    public class NamedOptionalArgumentsEx
    {

        static void GetFullName(string lastName, string firstName = "Dravid")
        {
            Console.WriteLine($"The Full Name is {firstName} {lastName}");
        }

        static void Main(string[] args)
        {

             GetFullName(firstName: "Viral", lastName: "kohili");
             GetFullName("Kambir");
             GetFullName(lastName: "Rahul");

             Console.ReadKey();
        }
    }
}
