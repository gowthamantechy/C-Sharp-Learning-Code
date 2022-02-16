using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp4._0
{

    public class Student
    {
        // Creating dynamic property  
        public dynamic Name { get; set; }
        // Creating a dynamic method  
        public dynamic ShowMSG(string msg)
        {
            return msg;
        }
    }

    public class DynamicBindingEx
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Micheal";
            Console.WriteLine(student.Name);
            // Storing result in dynamic object  
            dynamic msg = student.ShowMSG("Welcome to Dynamic Binding");
            Console.WriteLine(msg);

            Console.ReadKey();
        }
    }
}
