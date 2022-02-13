using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp6._0
{
    public class ExpressionBodiedEx
    {
        public override string ToString() => "Expression Bodied Member features";

        public string Name { get; set; }

        public void Show() => Console.WriteLine(Name);

        public static string Status { get => "Active"; }


        public string GetName() => $"The Name is: {Name}";

        static void Main()
        {
            ExpressionBodiedEx expressionBodiedEx = new ExpressionBodiedEx();

            expressionBodiedEx.Name = "Hacker";

            expressionBodiedEx.Show();

            Console.WriteLine("The Status is:{0}",Status);


            Console.WriteLine($"{expressionBodiedEx.GetName()}");

            Console.WriteLine(expressionBodiedEx);


            Console.ReadKey();
        }

    }
}
