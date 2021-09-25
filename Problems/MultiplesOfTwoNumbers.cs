using System;


class Mulitiples
{

    public static void Main(string[] args)
    {
        int result=0;

        result=CalculateMultiples(20);

        Console.WriteLine("The sum of multiples of 3 and 5 is:"+result);
    }

    public static int CalculateMultiples(int limit)
    {
        int sum=0;

        for(int i=1;i<=limit;i++)
        {
            if(i%3==0 ||i%5==0)
            {
                sum+=i;
            }
        }

        return sum;
    }


}