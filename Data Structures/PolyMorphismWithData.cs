using System;

public class Teacher
{
		public string name="Nandhini";
}

public class Student: Teacher
{
		public string name="Vasu";
}


public class Testing
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Hello World");

		Teacher obj=new Student();

		Console.WriteLine(obj.name);

		obj=new Teacher();

		Console.WriteLine(obj.name);

	}
}