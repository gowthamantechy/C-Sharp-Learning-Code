using System;

// Extension method must be implemented inside static class

public static class Extended
{
    public static bool IsGreaterThan(this int i, int value)
    {
        return i> value;
     }
}


class Program
{

public static void Main(string[] args)
{
    //can't instantiate the static class
    //Extended ex= new Extended();

    int j=199;
    
    bool result= j.IsGreaterThan(100);

    Console.WriteLine("The result is: "+result );


}

}