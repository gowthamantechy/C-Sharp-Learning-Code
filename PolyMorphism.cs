using System;


public class Teacher
{
	public virtual void update()
	{
		Console.WriteLine("Updating datebase by Teacher................");
	}
}


public class Student:Teacher
{
	 public override void update()
	{
		Console.WriteLine("Updating datebase by Student.................");

	}
}


public class Superclass
{

	public static void Main(string[] args)
	{
		Teacher obj=new Teacher();

		obj.update();

		Student obj1=new Student();

		obj1.update();
	}
}