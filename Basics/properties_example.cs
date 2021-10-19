using System;



class Program
{

    private int ID;

    public int id 
    {
        get
        {
            return ID;
        }
        set
        {
            this.ID=value;
        }
        }

    public void display()
    {
        Console.WriteLine("The value of id is: "+ this.ID);
    }

    public static void Main(string[] args)
    {
        Program obj=new Program();

        obj.id=12;
        
        obj.display();

    }

}