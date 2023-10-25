/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 24/10/2023
 * Hora: 01:34
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Practica_opybusq
{
	class Program
	{
		public static void Main(string[] args)
		{
			int [] coleccion = {12,3,8,6,2,9,10,-3,0,5};
			Console.WriteLine("Ordenamiento por Intercambio:");
			OrdenPorIntercambio(ref coleccion);
			Console.WriteLine("Ordenamiento por Selección:");
			OrdenPorSeleccion(ref coleccion);
			Console.WriteLine("Ordenamiento por Burbuja:");
			OrdenPorBurbuja(ref coleccion);
			
			int [] elementos = {3,6,3,5,8,6,3,1,8,5,0};
			Console.ReadKey(true);
		}
		public static void OrdenPorIntercambio(ref int [] datos)
		{
			int n= datos.Length;
			for(int i=0; i<=(n-1); i++)
			{
				for(int j=i+1; j<n; j++)
				{
					if(datos[i] > datos[j])
					{
						int swap = datos[i];
						datos[i] = datos[j];
						datos[j] = swap;
						
					}
					
				}
				Console.WriteLine(datos[i]);
			}
		}
		public static void OrdenPorSeleccion(ref int [] datos)
		{
			int n= datos.Length;
			for(int i=0; i<=(n-1); i++)
			{
				int menor = i;
				for(int j=i+1; j<n; j++)
				{
					if(datos[j] < datos[menor])
					{
						menor = j;
					}
				}
				if(menor != i)
				{
					int swap = datos[i];
					datos[i] = datos[menor];
					datos[menor] = swap;
				}
				Console.WriteLine(datos[i]);
			}
		}
		public static void OrdenPorBurbuja(ref int [] datos)
		{
			int n = datos.Length;
			int i = 0;
			int cont = 1;
			while((i<(n-1)) && (cont!=0))
			{
				cont=0;
				for(int j=0; j<(n-1-i); j++)
				{
					if(datos[j] > datos[j+1])
					{
						cont++;
						int swap = datos[j];
						datos[j] = datos[j+1];
						datos[j+1] = swap;
						
					}
					Console.WriteLine(datos[j]);
				}
				
			}
		}
		
	}
}