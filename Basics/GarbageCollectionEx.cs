using System;


public class DisposableTest : IDisposable  
    {  
        private bool isDisposed = false;  
  
        public void Print(string message)  
        {  
            Console.WriteLine("Hello " + message);  
        }  
  
        ~DisposableTest()  
        {  
            Console.WriteLine("Destructor/Finalize of DisposableTest");  
            Dispose(false);  
        }  
        public void Dispose()  
        {  
            Dispose(true);  
            GC.SuppressFinalize(this);  
        }  
        protected void Dispose(bool dispose)  
        {  
            if (!isDisposed)  
            {  
                if (dispose)  
                {  
                     Console.WriteLine("Clean Up: Managed Resources"); 
                }
                else
                {
                    Console.WriteLine("Clean Up: UnManaged Resources"); 
                }  
                
                isDisposed = true;  
            }  
        }  
    }  


class Program
{
    public static void Main()
    {

        Console.WriteLine("Garbage collectore finalize and dispose example");


        // DisposableTest obj = new DisposableTest();  
        //     Console.WriteLine("DisposableTest object is created..");  
        //     obj.Print("Good Morning..");  
        //     obj = null;  
        //     Console.WriteLine("Assigned null..  Object is destructing..");  



        //  DisposableTest obj = new DisposableTest();  
        //     Console.WriteLine("DisposableTest object is created..");  
        //     obj.Print("Good Morning..");  
        //     obj.Dispose();  
        //     obj = null;  
        //     Console.WriteLine("Assigned null..  Object is destructing..");  


        using (DisposableTest obj = new DisposableTest())  
        {  
            Console.WriteLine("DisposableTest object is created..");  
            obj.Print("Good Morning..");  
        }  
        Console.WriteLine("Assigned null..  Object is destructing..");  

        Console.ReadLine();
    }

}