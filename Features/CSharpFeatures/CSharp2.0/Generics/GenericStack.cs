using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp2._0.Generics
{
    public class GenericStack
    {
        public static void Main(string[] args)
        {

            Stack<string> names=new Stack<string>();

            names.Push("Edwin");
            names.Push("Peter");
            names.Push("Jhon");


            foreach (var item in names)
            {
                Console.WriteLine($"{item} {item.Length}");
            }


            Console.WriteLine($"peek value : {names.Peek()}");

            Console.WriteLine($"poped value : {names.Pop()}");


            Console.WriteLine($"After pop,peek value : {names.Peek()}");



            Console.ReadKey();
        }
    }
}
