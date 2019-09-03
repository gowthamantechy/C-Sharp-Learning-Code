using System;



class Singleton
{

   //Early Instantiation
   private static Singleton instance=new Singleton();

   private Singleton(){}

   public static Singleton GetInstance
   {
      get
      {
         return instance;
      }
   }



}

class SingletonLate
{

   //Late Instantiation
   private static SingletonLate instance=null;

   private SingletonLate(){}

   public static SingletonLate GetInstance
   {
      get{
         if(instance==null)
         {
            instance=new SingletonLate();
            return instance;
         }
         else{
            return instance;
         }
      }
   }
}



class SingletonLock
{
   private static SingletonLock instance=null;

   private string name{get;set;}
   private string ip{get;set;}


   private SingletonLock(){
      name="Gowthaman";
      ip="127.0.0.1";
   }
   private static object LockThis=new object();

   public static SingletonLock GetInstance
   {
      get{
         lock(LockThis)
         {
            if(instance==null)
            {
               instance=new SingletonLock();
               return instance;
            }
            else
            {
               return instance;
            }
          }
      }
   }
   public void show()
   {
      Console.WriteLine("name {0} and ip is {1}",name,ip);
   }
  
}


class Testing
{
   public static void Main(string[] args)
   {

      Console.WriteLine(Singleton.GetInstance);
      Console.WriteLine(Singleton.GetInstance);


      Console.WriteLine("=====================================");

      Console.WriteLine(SingletonLate.GetInstance);
      Console.WriteLine(SingletonLate.GetInstance);

      Console.WriteLine("=====================================");

      Console.WriteLine(SingletonLock.GetInstance);
      Console.WriteLine(SingletonLock.GetInstance);

      Console.WriteLine("=======================================");


      SingletonLock.GetInstance.show();
      SingletonLock.GetInstance.show();

   }

}

