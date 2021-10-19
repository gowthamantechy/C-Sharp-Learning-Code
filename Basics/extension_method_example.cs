using System;

// Extension method must be implemented inside static class

public static class Extended
{
    public static bool IsGreaterThan(this int i, int value)
    {
        return i> value;
     }

     public static bool IsEven(this int i)
     {
         return ((i%2)==0);
     }



     public static void NewMethod(this Program obj)
     {
         Console.WriteLine("Hello, This is new method...");

     }
}


public class Program
{

public static void Main(string[] args)
{
    //can't instantiate the static class
    //Extended ex= new Extended();

    int j=190;
    
    bool result1= j.IsGreaterThan(100);

    bool result2=j.IsEven();

    Console.WriteLine("The result is: "+result1 );

    Console.WriteLine("The is even : "+result2 );

    Program obj=new Program();

    obj.NewMethod();

}

}