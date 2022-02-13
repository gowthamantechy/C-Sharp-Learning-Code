using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures.CSharp2._0
{
    
        partial class Customer
        {
            // Deposit function  
            public void depositAmount(int d_amount)
            {
                amount += d_amount;
                Console.WriteLine(d_amount + " amount is deposited");
                Console.WriteLine("Available balance is: " + amount);
            }
        }


    class BankAccount
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Amount = 2000;
            Console.WriteLine("Current balance is: " + customer.Amount);
            customer.depositAmount(1000);
            // Accessing seperate file function  
            customer.withdraw(500);


            Console.ReadKey();
        }
    }
}
