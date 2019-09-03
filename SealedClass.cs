using System;

// Sealed Class Cannot be Derived by any drived Class or child class
sealed public class Gowtham
{
	public void getvalue()
	{
			Console.WriteLine("Gowtham Class.................");
	}
}

public class Student
{
	public void setvalue()
	{
		Console.WriteLine("Student Class....................");
	}
}

public class Testing
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");

		//Student obj=new Student();

		// obj.setvalue();

		Gowtham obj=new Gowtham();

		obj.getvalue();


	}
}
