using System;

public class Class1
{
	public Class1()
	{
		int inti = 0;
		for (inti = 90; inti >= 65; inti--)
		{
			Console.WriteLine("Letra: " + Convert.ToString((char)inti));
		}
	}
}
