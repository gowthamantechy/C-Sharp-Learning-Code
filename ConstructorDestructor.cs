using System;

// Constructor is always First Invoked
//Destructor always finally inovked
public class Fruits
{
	public Fruits()
	{
		Console.WriteLine("Fruits Constuctor Invoked.............");
	}


	~Fruits()
	{
		Console.WriteLine("Fruits Destructor Invoked.............");
	}

}

public class Apple:Fruits
{
	public Apple()
	{
		Console.WriteLine("Apple Constuctor Invoked............");
	}

	~Apple()
	{
		Console.WriteLine("Apple Destructor Invoked..........");
	}
}
public class Testing
{

	public static void Main(string[] args)
	{

		//Fruits obj=new Fruits();

		Apple obj=new Apple();

	}
}