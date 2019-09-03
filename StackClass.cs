using System;
using System.Collections.Generic;



class Testing
{
	public static void Main(string[] args)
	{
		Stack<string> names=new Stack<string>();

		names.Push("Black");
		names.Push("Red");
		names.Push("White");
		names.Push("Yellow");
		names.Push("Green");

		foreach(string name in names)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine("===============================================");

		Console.WriteLine("Peek Element:"+names.Peek());
		
		Console.WriteLine("Pop:"+names.Pop());

		Console.WriteLine("Now Peek Element:"+names.Peek());


		Console.WriteLine("===============================================");


		Stack<int> names1=new Stack<int>();

		names1.Push(1);
		names1.Push(3);
		names1.Push(6);
		names1.Push(7);
		names1.Push(9);

		foreach(int name in names1)
		{
			Console.WriteLine(name);
		}

		Console.WriteLine("===============================================");

		Console.WriteLine("Peek Element:"+names1.Peek());
		
		Console.WriteLine("Pop:"+names1.Pop());

		Console.WriteLine("Now Peek Element:"+names1.Peek());

	}
}