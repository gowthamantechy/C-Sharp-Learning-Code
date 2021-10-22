using System;


class Program
{
    delegate int Square(int num);

    delegate int Sum(int num1,int num2);

    public delegate void AnonymousFun();


    public static void Main(string[] args)
    {
        // Lambda Functions
        Square GetSquare=x=>x*x;
        //Lambda Functions
        Sum GetSum=(x1,x2)=>x1+x2;

        int j=GetSquare(5);

        int k=GetSum(10,12);

        Console.WriteLine("Square: "+j);
        Console.WriteLine("Sum is: "+k);

        
        AnonymousFun fun =delegate()
        {
            Console.WriteLine("This is a anonymous function..");
        };


        fun();


    }
}