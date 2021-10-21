using System;


/*
Action delegate: it holds function parameter that can take parameter but it doesn't return a value

func delegate: holds a function parameter that can take parameter but it does return value

*/

// class CustomerPresentation
// {
//     public void Update()
//     {
//         CustomerFacade customerFacade =new CustomerFacade();
//         customerFacade.UpdateData(NotifyCallback);
//     }

//     private void NotifyCallback()
//     {
//         Console.WriteLine("Callback: update data operation completed..");
//     }

// }

// class CustomerFacade
// {
//     public delegate void NotifyPresentation();
//     public void UpdateData(NotifyPresentation notifyPresentation)
//     {
//         notifyPresentation();
//     }
// }





// class CustomerPresentation
// {
//     public void Update()
//     {
//         CustomerFacade customerFacade =new CustomerFacade();
//         customerFacade.UpdateData(NotifyCallback);
//     }

//     private void NotifyCallback(string name)
//     {
//         Console.WriteLine("Callback: update data operation completed..:"+name);
//     }

// }

// class CustomerFacade
// {
//     //public delegate void NotifyPresentation();
//     public void UpdateData(Action<string> notifyPresentation)
//     {
//         notifyPresentation("Message from facade");
//     }
// }





// class CustomerPresentation
// {
//     public void Update()
//     {
//         CustomerFacade customerFacade =new CustomerFacade();
//         customerFacade.UpdateData(NotifyCallback);
//     }

//     private string NotifyCallback(bool isUpdateSuccess)
//     {
//         //Console.WriteLine("Callback: update data operation completed..:"+name);

//         if(isUpdateSuccess)
//         {
//             Console.WriteLine("Update was successfull..");

//         }
//         else
//         {
//             Console.WriteLine("Update failed...");
//         }

//         return "A Message from Notification Callback method...";
//     }

// }

// class CustomerFacade
// {
//     public delegate string NotifyPresentationReturnString(bool status);

//     public void UpdateData(NotifyPresentationReturnString notifyPresentationReturnString)
//     {
//         var returnValue=notifyPresentationReturnString(false);

//         Console.WriteLine("Customer Facade: "+returnValue);
//     }


//     // public void UpdateData(Action<string> notifyPresentation)
//     // {
//     //     notifyPresentation("Message from facade");
//     // }
// }







class CustomerPresentation
{
    public void Update()
    {
        CustomerFacade customerFacade =new CustomerFacade();
        customerFacade.UpdateData(NotifyCallback);
    }

    private string NotifyCallback(bool isUpdateSuccess)
    {
        //Console.WriteLine("Callback: update data operation completed..:"+name);

        if(isUpdateSuccess)
        {
            Console.WriteLine("Update was successfull..");

        }
        else
        {
            Console.WriteLine("Update failed...");
        }

        return "A Message from Notification Callback method...";
    }

}

class CustomerFacade
{
    //public delegate string NotifyPresentationReturnString(bool status);

    public void UpdateData(Func<bool,string> notifyPresentationReturnString)
    {
        var returnValue=notifyPresentationReturnString(true);

        Console.WriteLine("Customer Facade: "+returnValue);
    }


    // public void UpdateData(Action<string> notifyPresentation)
    // {
    //     notifyPresentation("Message from facade");
    // }
}







class Program
{
    public static void Main(string[] args)
    {

        CustomerPresentation customerPresentation  =new CustomerPresentation();

        customerPresentation.Update();
        Console.ReadKey();
    }

}