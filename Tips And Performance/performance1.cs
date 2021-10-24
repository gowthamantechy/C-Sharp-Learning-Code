using System;
using System.Text;
using System.Threading;
using System.Diagnostics;



class Program
{

    public static void Main(string[] args)
    {
        string name="hello";
        StringBuilder sb =new StringBuilder();

        Stopwatch sw  =new Stopwatch();

        sw.Start();

        for (int i=0;i<1000;i++)
        {
            name=name+"hello";
        }

        sw.Stop();

        Console.WriteLine("String Time Elapsed Ticks: "+sw.ElapsedTicks);

        sw.Restart();

        for (int i = 0; i < 1000; i++)
        {
            sb.Append("hello");
        }

        sw.Stop();

    
        Console.WriteLine("String Builder Time Elapsed Ticks: "+sw.ElapsedTicks);

        Console.ReadKey();


    }

}