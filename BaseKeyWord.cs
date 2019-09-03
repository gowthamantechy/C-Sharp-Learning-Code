using System;


//Base KeyWord is used to call the method or fields from the base class
public class Vegitables
{
	public Vegitables()
	{
		Console.WriteLine("Base Class Constructor............");
	}
	public virtual void getvalue()
	{
		Console.WriteLine("Vegitables Class ..................");
	}

}

public class Brinjal:Vegitables
{
	//base is used here in implicitly accessing the Base Class Method
	public Brinjal()
	{
		Console.WriteLine("Derived Class Constructor..............");
	}

	public override void getvalue()
	{
		//Explicitly get the method from the base class
		base.getvalue();
		Console.WriteLine("Brinjal Class........................");
	}

}

public class Testing
{
	public Testing()
	{
		Console.WriteLine("SuperClass Constructor.................");
	}

	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");

		Vegitables obj=new Brinjal();

		obj.getvalue();

	}
}

