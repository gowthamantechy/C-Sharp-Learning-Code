using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp2._0
{
    partial class Customer
    {
        private int amount;
        public int Amount { get => amount; set => amount = value; }
        // Withdraw function  
        public void withdraw(int w_amount)
        {
            amount -= w_amount;
            Console.WriteLine(w_amount + " is withdrawn");
            Console.WriteLine("Available balance is: " + amount);


        }
    }
}
