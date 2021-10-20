using System;
///Tips

public abstract class Customer
{
    public Customer()
    {
        Print();
    }

    public abstract void Print();
}


public class SavingCustomer:Customer
{
    public override void Print()
    {
        Console.WriteLine("Saving customer was invoked......");
    }

}


public class CorporateCustomer:Customer
{
    public override void Print()
    {
        Console.WriteLine("Corporate customer was invoked......");
    }
}

class Program
{

    public static void Main(string[] args)
    {
        SavingCustomer sc =new SavingCustomer();
        CorporateCustomer cc=new CorporateCustomer();

    }
}