using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace CSharpFeatures.CSharp1._0
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public class ClassEx
    {
        public string FirstName { get; set; } = "Gowthaman";

        public string LastName { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

    }


    public class Program
    {
        static void Main()
        {
            ClassEx ex=new ClassEx();

           

            WriteLine("initialized properties", ex.FirstName);

            WriteLine("Enter the First Name");
            ex.FirstName = ReadLine();

            WriteLine("Enter the Last Name");
            ex.LastName= ReadLine();

            WriteLine($" The Full Name is : {ex.FirstName} {ex.LastName}");


            WriteLine(ex);

            ReadKey();
        }
    }
}
