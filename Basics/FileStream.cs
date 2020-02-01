using System;
using System.IO;

public class FileStreamExample
{
	public static void Main(string[] args)
	{

	
		FileStream f=new FileStream("C:\\Users\\Admin\\Desktop\\C# Learning Code\\example.txt",FileMode.OpenOrCreate);

		for(int i=65;i<=90;i++)
		{
			f.WriteByte((byte)i);
		}

		f.Close();
	}
	
}