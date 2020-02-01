using System;

//Partial KeyWord is very usefull when we writing the sameclass in multiple files.
//It Sepeartes a Class in Multiple files, At the time of compilation it combines everything.

public partial class Technology
{

	public string name="Computer Hardware and Software";


	public void getData()
	{
		Console.WriteLine("Technology Class part1...............");
	}


}

public partial class Technology
{
	public void printData()
	{
		Console.WriteLine("Technology class part2..............");
	}
}


public class Testing
{
	public static void Main(string[] args)
	{
		Technology obj=new Technology();

		obj.getData();

		obj.printData();
	}
}