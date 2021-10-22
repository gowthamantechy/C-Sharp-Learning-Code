using System;
using System.Reflection;  


class Program
{

    public static void Main(string[] args)
    {
        int a=10;
        string name="Welcome to C# Programming";
        //int[] b= new int{1,2,3,4,5};
        bool status=true;
        

        Type type1=a.GetType();
        Type type2=name.GetType();
        //Type type3=b.GetType();
        Type type4=status.GetType();

        Console.WriteLine(type1);
        Console.WriteLine(type2);
        //Console.WriteLine(type3);
        Console.WriteLine(type4);


        Type t = typeof(System.String);  
        Console.WriteLine(t.Assembly);   

        Console.WriteLine(t.FullName);  
        Console.WriteLine(t.BaseType);  
        Console.WriteLine(t.IsClass);  
        Console.WriteLine(t.IsEnum);  
        Console.WriteLine(t.IsInterface);  



        Console.WriteLine("Constructors of {0} type...", t);  
        ConstructorInfo[] ci1 = t.GetConstructors(BindingFlags.Public | BindingFlags.Instance);  
        foreach (ConstructorInfo c in ci1)  
        {  
            Console.WriteLine(c);  
        }  

        Console.WriteLine("Fields of {0} type...", t);  
        FieldInfo[] ci2 = t.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.NonPublic);  
        foreach (FieldInfo f in ci2)  
        {  
            Console.WriteLine(f);  
        }  

        Console.WriteLine("Methods of {0} type...", t);  
        MethodInfo[] ci3 = t.GetMethods(BindingFlags.Public | BindingFlags.Instance);  
        foreach (MethodInfo m in ci3)  
        {  
            Console.WriteLine(m);  
        }  

    }

}