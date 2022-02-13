using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp7._0
{
    public class TupleEx
    {


        static void Main()
        {

            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.

            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.




            var left = (a: 5, b: 10);

            var right = (a: 20, b: 25);

            Console.WriteLine(left==right);

            var p = new Person("Mary", "Jeba");

            var (first, last) = p;

            Console.WriteLine($"first name {first} length {first.Length} ,last name {last} lenght {last.Length}");

            Console.ReadKey();
        }
    }

        public class Person
        {
            public string FirstName { get; }
            public string LastName { get; }

            public Person(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }
            public void Deconstruct(out string firstName, out string lastName)
            {
                firstName = FirstName;
                lastName = LastName;
            }
        }
}
