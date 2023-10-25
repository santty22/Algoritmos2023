/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 22/10/2023
 * Hora: 00:54
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Program
{
	class Program
	{
		public static void Main(string[] args)
		{
			string viv="Siempre Verde";
			Vivero ss = new Vivero(viv);
			
			try
			{
				MenuPrincipal();
			int opcion;
			opcion=int.Parse(Console.ReadLine());
			while(opcion!=0)
			{
				if(opcion==1)
				{
					Console.WriteLine("Desea agregar una planta nueva? s/n");
					char decision;
					decision = char.Parse(Console.ReadLine());
					while(decision=='s')
					{
						Console.WriteLine("Nombre de la planta:");
						string nombre=Console.ReadLine();
						Console.WriteLine("Nombre de la Especie:");
						string nomEsp=Console.ReadLine();
						Console.WriteLine("Precio de la planta:");
						double precio=double.Parse(Console.ReadLine());
						Console.WriteLine("Epoca de siembra:");
						string epocaSiembra=Console.ReadLine();
						Planta nuevaPlanta = new Planta(nombre,nomEsp,precio,epocaSiembra);
						ss.AgregarPlanta(nuevaPlanta);
						bool existelaespecie=ss.ExisteEspecie(nuevaPlanta);
						if(existelaespecie)
						{
							Console.WriteLine("La especie no existe, por lo tanto debe ser definida.");
							Console.WriteLine("El nombre de la especie será {0}, a continuación defina su tipo(interior/exterior)",nuevaPlanta.NomEsp);
							string tipo=Console.ReadLine();
							string nombreespecie= nuevaPlanta.NomEsp;
							Especie nuevaEspecie = new Especie(nombreespecie,tipo);
						}
						Console.WriteLine("Desea agregar otra planta? s/n");
						decision = char.Parse(Console.ReadLine());
					}
					
				}
				else if(opcion==2)
				{
					Console.WriteLine("Desea agregar una especie nueva? s/n");
					char decision;
					decision = char.Parse(Console.ReadLine());
					while(decision=='s')
					{
						Console.WriteLine("Nombre de la especie:");
						string nombre=Console.ReadLine();
						Console.WriteLine("Tipo de la especie (interior/exterior):");
						string tipo=Console.ReadLine();
						Especie nuevaEspecie = new Especie(nombre, tipo);
						Console.WriteLine("Desea agregar otra especie nueva? s/n");
						decision = char.Parse(Console.ReadLine());
					}
				}
				else if(opcion==3)
				{
					Console.WriteLine("Desea vender una planta? s/n");
					char dec=char.Parse(Console.ReadLine());
					while(dec=='s')
					{
						Console.WriteLine("Indique el nombre de la planta a vender:");
						string nombre=Console.ReadLine();
						ss.VenderPlanta(nombre);
						Console.WriteLine("Desea vender otra planta? s/n");
						dec=char.Parse(Console.ReadLine());
					}
				}
				else if(opcion==4)
				{
					ss.ListaInterior();
				}
				MenuPrincipal();
				opcion=int.Parse(Console.ReadLine());
			}
			}
			catch(Exception)
			{
				Console.WriteLine("Ha ocurrido un error, se volverá a iniciar el menú.");
				MenuPrincipal();
				int opcion;
				opcion=int.Parse(Console.ReadLine());
			}
			
			
			
			Console.ReadKey(true);
		}
		public static void MenuPrincipal()
		{
			Console.WriteLine("-------------------------------------");
			Console.WriteLine("Menú principal - Vivero Siempre Verde");
			Console.WriteLine("1) Agregar Planta.");
			Console.WriteLine("2) Agregar Especie.");
			Console.WriteLine("3) Vender Planta.");
			Console.WriteLine("4) Mostrar lista de plantas de interior");
			Console.WriteLine("-------------------------------------");
		}
	}
}