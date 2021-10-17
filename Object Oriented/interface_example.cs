using System;


/* just like classes interfaces contains properties,methods,delegates or events

but, only delcaration not implementaions.

interface members are public by default, don't allow explicit access specifiers

interfaces can't contain fields.

interfaces can't be instantiated.

we can't create an instance of an interface, 
but an interface reference variable can point to a derived class object.





  */


interface ICustomer1
{
    // only declaration is possible in interface not implementaion.
    void Print1();
}


interface ICustomer2
{
    void Print2();
}



public class Customer:ICustomer1,ICustomer2
{
    // Two methods of interfaces must be implemented in derived classes.
    public void Print1()
    {
        Console.WriteLine("Print 1 method of icustomer1");
    }

    public void Print2()
    {
        Console.WriteLine("Print2 method of icustomer 2");
    }

}


class Program
{


    public static void Main(string[] args)
    {
        // can't be instantiated of an interface... but interface reference variable can
        //point to derived class object

        //ICustomer2 cust=new ICustomer2();

        //ICustomer2 cust=new Customer();

        ICustomer1 cust=new Customer();

        cust.Print1();
        //cust.Print2();
        //cust.Print1();

        // Customer c=new Customer();
        // c.Print1();
        // c.Print2();

    }
}