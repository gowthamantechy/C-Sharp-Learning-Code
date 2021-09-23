using System;
using System.Collections.Generic;


class DuplicatesCounter
{
    public static string value1="aabcadmmlnll";

    public static int count=0;
    
    public static Dictionary<char, int> result = new Dictionary<char, int>();

    public static void Main(string[] args)
    {

        foreach(char val in value1)
        {
            count=0;

            System.Console.WriteLine(val);

            foreach(char val1 in value1)
            {
                if (val == val1)
                {
                    count+=1;
                }
            }
            if(!result.ContainsKey(val))
            {
                result.Add(val,count);
            }
        }
         
        foreach(KeyValuePair<char, int> kvp in result)
        {
            System.Console.Write("{0}:{1}",kvp.Key,kvp.Value);
        }
        
        System.Console.WriteLine();
       System.Console.WriteLine("The result is: "+result);
    }
    
    
}

