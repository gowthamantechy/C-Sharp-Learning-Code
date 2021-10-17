using System;


/* just like classes interfaces contains properties,methods,delegates or events

but, only delcaration not implementaions.

interface members are public by default, don't allow explicit access specifiers

interfaces can't contain fields.

interfaces can't be instantiated.

we can't create an instance of an interface, 
but an interface reference variable can point to a derived class object.
---------Difference between Abstact class and interaces------------

1. abstract class can have implementation for some of its members, but
interface can't have implementation for any of its members

2. interfaces can't have fields where as an abstract class can have fields

3.An interface can inherit from another interface only and can't inherit from
abstract class, where as an abstract class can inherit from another abstract class or
another interface.

4. A class can inherit from multiple interfaces at the same time ,
where as a class can't inherit from multiple classes at the same time.

5. an abstract classes can have modifiers whereas interface members can't have access 
modifiers.

--------------------------------------------------------------











  */


interface ICustomer1
{
    // only declaration is possible in interface not implementaion.
    void Print1();
}


interface ICustomer2:ICustomer1
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

        ICustomer2 cust=new Customer();

        //ICustomer1 cust=new Customer();

        cust.Print1();
        cust.Print2();
        //cust.Print1();

        // Customer c=new Customer();
        // c.Print1();
        // c.Print2();

    }
}