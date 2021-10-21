using System;

/*

//publisher class
class EmployeeSeparator
{

    // declaring custom delegates in publisher class
    public delegate void EmployeeSeparatedEventHandler();
    //declaring events of delegates
    public event EmployeeSeparatedEventHandler EmployeeSeparated;

    public void Separate()
    {
        if(EmployeeSeparated != null)
        {
            //invoking the events in publisher class
            // When this event is invoked/fired  notification is sent to subscriber classes
             EmployeeSeparated();
        }
       
    }
}

// Subscriber class
class Finance
{
    // publisher class declaration in subscriber class
    private readonly EmployeeSeparator employeeSeparator;

    public Finance(EmployeeSeparator employeeSeparator)
    {
        this.employeeSeparator=employeeSeparator;

        //subscribing publisher class in subscriber class
        employeeSeparator.EmployeeSeparated+= EmployeeSeparatedEventHandler;
    }

    //call back method or event handler method or notification system of publisher class
    public void EmployeeSeparatedEventHandler()
    {
        Console.WriteLine("Finance Department");
    }
}

// Subscriber class
class IT
{
    // publisher class declaration in subscriber class
    private readonly EmployeeSeparator employeeSeparator;

    public IT(EmployeeSeparator employeeSeparator)
    {
        this.employeeSeparator=employeeSeparator;

        //subscribing publisher class in subscriber class
        employeeSeparator.EmployeeSeparated+= EmployeeSeparatedEventHandler;
    }

    //call back method or event handler method or notification system of publisher class
    public void EmployeeSeparatedEventHandler()
    {
        Console.WriteLine("IT Department");
    }
}




class Program
{
    public static void Main(string[] args)
    {
        EmployeeSeparator employeeSeparator =new EmployeeSeparator();

        //Hooks between publisher and subscriber
        Finance finance= new Finance(employeeSeparator);

        //Hooks between publisher and subscriber
        IT it =new IT(employeeSeparator);

        employeeSeparator.Separate();
    }
}

*/



class EmployeeEventArgs:EventArgs
{
    public int EmpId {get;set;}
    public string Name {get;set;}
}


//publisher class
class EmployeeSeparator
{

    // declaring custom delegates in publisher class
    //public delegate void EmployeeSeparatedEventHandler();
    //declaring events of delegates
    public event EventHandler<EmployeeEventArgs> EmployeeSeparated;

    public void Separate()
    {

        EmployeeEventArgs employeeEventArgs=new EmployeeEventArgs{ EmpId=101, Name="Venket" };

        if(EmployeeSeparated != null)
        {

            //invoking the events in publisher class
            // When this event is invoked/fired  notification is sent to subscriber classes
            //EmployeeSeparated(this,EventArgs.Empty);

            EmployeeSeparated(this,employeeEventArgs);

        }
       
    }
}

// Subscriber class
class Finance
{
    // publisher class declaration in subscriber class
    private readonly EmployeeSeparator employeeSeparator;

    public Finance(EmployeeSeparator employeeSeparator)
    {
        this.employeeSeparator=employeeSeparator;

        //subscribing publisher class in subscriber class
        employeeSeparator.EmployeeSeparated+= EmployeeSeparatedEventHandler;
    }

    //call back method or event handler method or notification system of publisher class
    public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
    {
        Console.WriteLine("Finance Department employee seperated "+" Name :"+e.Name);
    }
}

// Subscriber class
class IT
{
    // publisher class declaration in subscriber class
    private readonly EmployeeSeparator employeeSeparator;

    public IT(EmployeeSeparator employeeSeparator)
    {
        this.employeeSeparator=employeeSeparator;

        //subscribing publisher class in subscriber class
        employeeSeparator.EmployeeSeparated+= EmployeeSeparatedEventHandler;
    }

    //call back method or event handler method or notification system of publisher class
    public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
    {
        Console.WriteLine("IT Department employee separated "+" Name :"+e.Name);
    }
}




class Program
{
    public static void Main(string[] args)
    {
        EmployeeSeparator employeeSeparator =new EmployeeSeparator();

        //Hooks between publisher and subscriber
        Finance finance= new Finance(employeeSeparator);

        //Hooks between publisher and subscriber
        IT it =new IT(employeeSeparator);

        employeeSeparator.Separate();
    }
}