using System;

public class Class1
{
	public Class1()
	{
		int numero, suma;
		suma = 0;
		Console.Write("Ingrese un numero: ");
		numero = int.Parse(Console.ReadLine());
		while (numero > 0)
		{
			suma = suma + numero;
			Console.Write("Ingrese un numero: ");
			numero = int.Parse(Console.ReadLine());

		}
		Console.WriteLine("La suma de los numeros ingresados es: {0}", suma);

	}
}
