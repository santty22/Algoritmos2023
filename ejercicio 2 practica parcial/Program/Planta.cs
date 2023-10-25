/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 22/10/2023
 * Hora: 01:03
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Program
{
	public class Planta
	{
		//Atributos
		private string nombre;
		private string nomEsp;
		private double precio;
		private string epocaSiembra;
		
		//Constructores
		public Planta(string nombre, string nomEsp, double precio, string epocaSiembra)
		{
			this.nombre=nombre;
			this.nomEsp=nomEsp;
			this.precio=precio;
			this.epocaSiembra=epocaSiembra;
		}
		
		//Propiedades
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string NomEsp
		{
			set {nomEsp = value;}
			get {return nomEsp;}
		}
		public double Precio
		{
			set {precio = value;}
			get {return precio;}
		}
		public string EpocaSiembra
		{
			set {epocaSiembra = value;}
			get {return epocaSiembra;}
		}
		
		//Métodos
		
	}
}
