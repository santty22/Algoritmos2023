using System;
using System.Collections;


namespace ejercicio_1_practica_parcial
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista= new ArrayList();
			string respuesta;
			
			Console.WriteLine("Ingresa números? (s/n)");
			respuesta=Console.ReadLine();
			while (respuesta=="s")
			{
				Console.WriteLine("Ingrese un número para agregar a la lista:");
				int numero = int.Parse(Console.ReadLine());
				lista.Add(numero);
				Console.WriteLine("Sigue ingresando números? (s/n)");
				respuesta=Console.ReadLine();
			}
			foreach(int num in lista)
			{
				if (num<0)
				{
					Console.WriteLine("La lista posee numeros negativos.");
					break;
				}
			}
			
			Console.ReadKey(true);
		}
	}
}