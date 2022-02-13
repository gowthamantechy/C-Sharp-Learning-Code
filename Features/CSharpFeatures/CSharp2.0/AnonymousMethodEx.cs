using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpFeatures.CSharp2._0
{
    public class AnonymousMethodEx
    {

        static void ConsolePrint(string name)
        {
            Console.WriteLine(name);
        }
        static void Main()
        {
            Func<int, int, int,int, int> sum = delegate (int a, int b, int c, int d) { return a + b + c + d; };
            WriteLine(sum(3, 4 , 4 , 5));  // output: 7


            Action greet = delegate { Console.WriteLine("Hello! c# Programming"); };
            greet();

            Action<int, double> introduce = delegate(int i,double j) { Console.WriteLine($"parameters are {i} and {j}"); };
            introduce(42, 2.7);


            Action<string> Printer = ConsolePrint;

            //Action<string> Printer = new Action<string>(ConsolePrint);

            Printer("Welcome to the World!!");

            ReadKey();
        }
    }
}
