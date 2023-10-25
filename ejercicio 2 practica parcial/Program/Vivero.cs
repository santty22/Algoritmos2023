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
	public class Vivero
	{
		//Atributos
		private string nombre;
		private ArrayList listaPlantas;
		private ArrayList listaEspecies;
		
		//Constructores
		public Vivero(string nombre)
		{
			this.nombre=nombre;
			listaPlantas=new ArrayList();
			listaEspecies=new ArrayList();
		}
		//Propiedades
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public ArrayList ListaPlantas
		{
			get {return listaPlantas;}
		}
		public ArrayList ListaEspecies
		{
			get {return listaEspecies;}
		}
		
		//Metodos
		public void cambiaEpoca(string nomPlanta, string nuevaEpoca)
		{
			foreach(Planta nombreplanta in listaPlantas)
			{
				bool estado = false;
				if (nombreplanta.Nombre == nomPlanta)
				{
					estado = true;
					nombreplanta.EpocaSiembra=nuevaEpoca;
				}
				if(estado)
				{
					Console.WriteLine("Epoca de la planta cambiada correctamente.");
				}
				else
				{
					Console.WriteLine("No se ha podido cambiar la epoca de siembra.");
				}
			}
		}
		public void ListaInterior()
		{
			string interior="interior";
			Console.WriteLine("Lista de plantas de interior.");
			foreach(Especie tipointerior in listaEspecies)
			{
				if(tipointerior.Tipo==interior)
				{
					Console.WriteLine("Plantas de interior de la especie {0}",tipointerior.Nombre);
					foreach(Planta nombreEsp in listaPlantas)
					{
						if(nombreEsp.NomEsp==tipointerior.Nombre)
						{
							Console.WriteLine("Planta: {0}. Precio: {1}",nombreEsp.Nombre, nombreEsp.Precio);
						}
					}
				}
			}
		}
		public void ListaExterior()
		{
			string exterior="exterior";
			Console.WriteLine("Lista de plantas de exterior:");
			foreach(Especie tipoexterior in listaEspecies)
			{
				if(tipoexterior.Tipo==exterior)
				{
					Console.WriteLine("Plantas de exterior de la especie {0}",tipoexterior.Nombre);
					foreach(Planta nombreEsp in listaPlantas)
					{
						if(nombreEsp.NomEsp==tipoexterior.Nombre)
						{
							Console.WriteLine("Planta: {0}. Precio: {1}",nombreEsp.Nombre, nombreEsp.Precio);
						}
					}
				}
			}
		}
		public void AgregarPlanta(Planta planta)
		{
			listaPlantas.Add(planta);
			Console.WriteLine("Planta agregada correctamente.");
		}
		public void AgregarEspecie(Especie especie)
		{
			listaEspecies.Add(especie);
			Console.WriteLine("Especie agregada correctamente.");
		}
		public bool ExisteEspecie(Planta planta)
		{
			bool existe=false;
			foreach(Especie esp in listaEspecies)
			{
				if(esp.Nombre==planta.NomEsp)
				{
					existe=true;
					return existe;
				}
			}
			return existe;
		}
		public void VenderPlanta(string planta)
		{
			bool esta=false;
			foreach(Planta plant in listaPlantas)
			{
				if(plant.Nombre==planta)
				{
					esta=true;
					Console.WriteLine("El costo de la planta es de {0}",plant.Precio);
					Console.WriteLine("Confirmar la venta: s/n");
					char vender= char.Parse(Console.ReadLine());
					if(vender=='s')
					{
						listaPlantas.Remove(plant);
						Console.WriteLine("Planta vendida correctamente.");
						break;
					}
				}
			}
			if(esta==false)
			{
				Console.WriteLine("No se encontró la planta solicitada.");
				throw new PlantaNoExisteException();
			}
		}
	}
}
