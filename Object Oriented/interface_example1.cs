using System;


/*  To avoid the tightly coupled design, interface is used, */

public interface IPayment
{
    void MakePayment();
}


// public class CreditCardPayment
// {
//   public void MakePayment()
//   {
//       Console.WriteLine("Credit card payment was activated....");
//   }

// }


public class CreditCardPayment:IPayment
{
  public void MakePayment()
  {
      Console.WriteLine("Credit card payment was activated....");
  }

}

// public class DebitCardPayment
// {
//     public void MakePayment()
//     {
//         Console.WriteLine("Debit card payment was activated....");
//     }

// }

public class DebitCardPayment:IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Debit card payment was activated....");
    }

}


// public class GooglePay
// {
//     public void MakePayment()
//     {
//         Console.WriteLine("Google payment mode was activated");
//     }

// }


public class GooglePay:IPayment
{
    public void MakePayment()
    {
        Console.WriteLine("Google payment mode was activated");
    }

}

// public class PaymentManager
// {

//     private readonly CreditCardPayment creditcard;
//     private readonly DebitCardPayment debitcard;
//     private readonly GooglePay googlepay;

//     public PaymentManager(CreditCardPayment creditcard,DebitCardPayment debitcard,GooglePay googlepay)
//     {
//         this.creditcard =creditcard;
//         this.debitcard=debitcard;
//         this.googlepay=googlepay;
//     }


//     public void ManagePayment()
//     {
//         creditcard.MakePayment();
//         debitcard.MakePayment();
//         googlepay.MakePayment();

//     }

// }


public class PaymentManager
{

    public readonly IPayment paymentMode;

    public PaymentManager(IPayment paymentMode)
    {
        this.paymentMode=paymentMode;
    }


    public void ManagePayment()
    {
        paymentMode.MakePayment();

    }

}

public enum Mode
{
        CreditCard,
        DebitCard,
        GooglePayment,
    
}

public class PaymentFactory
{
    public static IPayment create(Mode mode)
    {
        if( mode == Mode.CreditCard )
        {
            return new CreditCardPayment();
        }
        else if(mode ==Mode.DebitCard)
        {
            return new DebitCardPayment();
        }
        else
        {
            return new GooglePay();
        }
    }

}



// class Program
// {



//     public static void Main(string[] args)
//     {
//         CreditCardPayment creditcardPayment =new CreditCardPayment();
//         DebitCardPayment debitcardPayment=new DebitCardPayment();
//         GooglePay googlePayment=new GooglePay();


//         PaymentManager paymentManager=new PaymentManager(creditcardPayment,debitcardPayment,googlePayment);
//         paymentManager.ManagePayment();

//         Console.ReadKey();


//     }
// }





class Program
{



    public static void Main(string[] args)
    {
       
        var creditcard=PaymentFactory.create(Mode.DebitCard);

        PaymentManager paymentManager=new PaymentManager(creditcard);
        paymentManager.ManagePayment();

        Console.ReadKey();


    }
}