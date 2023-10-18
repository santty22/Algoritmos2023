using System;
using System.Collections;
using System.Collections.Generic;

namespace ejercicio_1_practica_parcial
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArrayList lista= new ArrayList();
			int pos,cont;
			string respuesta;
			
			Console.WriteLine("Ingresa números? (s/n)");
			respuesta=Console.ReadLine();
			while (respuesta=="s")
			{
				Console.WriteLine("Ingrese un número para agregar a la lista:");
				lista.Add(int.Parse(Console.Readline()));
				Console.WriteLine("Sigue ingresando números? (s/n)");
				respuesta=Console.ReadLine();
			}
			bool positivo = VerificarPositivos(lista);
			Console.WriteLine(positivo);
			
			Console.ReadKey(true);
		}
		public static bool VerificarPositivos(ArrayList lista, int index = 0)
		{
			if (index==lista.Count)
			{
				return true;
			}
			if (lista[index] <=0)
			{
				return false;
			}
			return VerificarPositivos(lista, index+1);
		}
	}
}