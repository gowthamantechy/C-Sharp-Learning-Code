using System;



class Program
{

public int Sum(int a, int b, int c)
{
    return a+b+c+10;
}

public int Sum(int a, int b)
{
    return a+b+5;
}
public static void Main(string[] args)
{
    Program P=new Program();

    Console.WriteLine(P.Sum(12,3));
    Console.WriteLine(P.Sum(2,3,4));
}
}