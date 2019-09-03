/*
Creational Design Pattern

1. Factory
2. Abstract Factory
3. Builder
4. Prototype
5. Singleton

Structural Design Pattern

1. Adaptor
2. Bridge
3. Composite
4. Decorator
5. Facade
6. Flyweight
7. Proxy

Behavioural Design Pattern

1.Chain of Responsibility
2. Command
3. Interpreter
4. Iterator
5. Mediator
6. Memento
7. Observer
8. State
9. Strategy
10. Visitor
11. Template Method

*/


//Singleton Design Pattern


using System;
using System.Collections.Generic;
using System.Threading;

namespace SingletonExamples
{


class Testing
{
   public static void Main(string[] args)
   {
      Console.WriteLine("Hello world");

      LoadBalancer l1=LoadBalancer.GetInstance();
      LoadBalancer l2=LoadBalancer.GetInstance();
      LoadBalancer l3=LoadBalancer.GetInstance();


      if(l1==l2&&l2==l3&&l3==l1)
      {
         Console.WriteLine("Same Instances");
         Console.WriteLine(l1);
      }

      LoadBalancer test=LoadBalancer.GetInstance();

      for(int i=0;i<15;i++)
      {
         string server=test.Server;
         Console.WriteLine("Dispatch request to:"+server);
      }


      Console.ReadKey();
   }
}




class LoadBalancer
{

   public static LoadBalancer _instance=null;
   public Random _random=new Random();
   public static  object syncLock=new object();

   public List<string> _server=new List<string>();


   protected LoadBalancer()
   {
      _server.Add("Server A");
      _server.Add("Server B");
      _server.Add("Server C");
      _server.Add("Server D");

   }

   public static LoadBalancer GetInstance()
   {

      if(_instance==null)
      {
         lock(syncLock)
         {
            if(_instance==null)
            {
               _instance=new LoadBalancer();
              
            }
         }

      }
      
      return _instance;
   

   }

   public string Server
   {
      get{
         int r=_random.Next(_server.Count);

         return _server[r].ToString();
      }
   }

}

}