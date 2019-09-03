using System;
using System.Collections.Generic;

public class Gowthaman
{
	public static void Main(string[] args)
	{
		var names1 =new List<string>();
		var names2= new List<string>(){"Banana Tree","Coconut Tree","Apple Tree"};

		names1.Add("Gowthaman");
		names1.Add("Anbarasan");
		names1.Add("Amuthan");


				
		Console.WriteLine("====================Names========================");

		foreach(var name in names1)
		{
			Console.WriteLine(name);
		}
		

		Console.WriteLine("====================Trees=========================")		;
		
		foreach(var names in names2)
		{
			Console.WriteLine(names);
		}
		

	}
}