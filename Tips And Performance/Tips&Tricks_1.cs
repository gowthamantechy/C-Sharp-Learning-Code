using System;
using System.Threading;
using System.Diagnostics;




class Program
{
    public static void Main(string[] args)
    {

        int Amount=50000;

        Stopwatch sw = new Stopwatch();  

        sw.Start();

        Thread.Sleep(5000);

        sw.Stop();

        

        Console.WriteLine("Time Elapsed: "+sw.Elapsed);

        Console.WriteLine("The Amount is: {0:C} ",Amount);

        Console.WriteLine("Time Elapsed in ticks: "+sw.ElapsedTicks);


    }
}