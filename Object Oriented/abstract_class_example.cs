using System;

// we can design two ways to solve the code maintanability, 
// by creating a non abstract or base concrete class or abstract class


/* abstract classes are used for mainly code maintainability..

1.  abstract classes cannot be initiated...
2. abstract classes can have methods and abstract methods.
abstract methods must be overrided in derived classes.
3. similar codes are grouped together in abstract class,
if we want to affect the same behaviour in many classes,
we can just change in the abstract class. it will affect in all classes.

-----

we could create an abstract class when we want to move the common functionality of one or more related class
into base class and when , we don't want the base class to be instantiated..




*/
public abstract class BaseEmployee
{
     public int ID{get;set;}
    public string first_name {get;set;}
    public string last_name{get;set;}


     public string GetFullName()
    {
        return this.first_name + " "+this.last_name;
    }


    public abstract decimal GetMonthlySalary();
}

public class FullTimeEmployee:BaseEmployee
{

    // public int ID{get;set;}
    // public string first_name {get;set;}
    // public string last_name{get;set;}
    public decimal anual_salary {get;set;}

//  public string GetFullName()
//     {
//         return this.first_name + " "+this.last_name;
//     }

    public override decimal GetMonthlySalary()
    {
        return this.anual_salary/12;
    }

}

public class ContractEmployee:BaseEmployee
{
    // public int ID{get;set;}
    // public string first_name {get;set;}
    // public string last_name{get;set;}
    public decimal total_hours {get;set;}
    public decimal months {get;set;}

    // public string GetFullName()
    // {
    //     return this.first_name + " "+this.last_name;
    // }

      public override decimal GetMonthlySalary()
    {
        return this.total_hours*this.months;
    }

}

class Program
{
    public static void Main(string[] args)
    {
        //Console.WriteLine("Hello World");

        //abstract class initialisation is prevented during compile time.
        //BaseEmployee be =new BaseEmployee();

        FullTimeEmployee fte =new FullTimeEmployee()
        {
           ID=101,
            first_name="Arun",
           last_name="May",
            anual_salary=10000
        };

        ContractEmployee cte=new ContractEmployee()
        {
           ID=102,
          first_name="Vel",
         last_name="murugan",
           total_hours=40,
          months=12
        };


        Console.WriteLine(cte.GetFullName());
        Console.WriteLine(cte.GetMonthlySalary());


        Console.WriteLine(fte.GetFullName());
        Console.WriteLine(fte.GetMonthlySalary());

    }
}