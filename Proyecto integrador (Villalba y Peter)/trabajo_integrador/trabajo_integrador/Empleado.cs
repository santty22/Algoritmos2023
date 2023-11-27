using System;

namespace trabajo_integrador
{
	public class Empleado
	{	
		// Datos Miembro
		protected string nombre;
		protected string dni;
		protected string puesto;
		protected string legajo;
		protected int sueldo;
		protected bool esEncargado;
		
		// Constructor
		public Empleado(string nombre, string dni, string puesto, string legajo, int sueldo)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.puesto = puesto;
			this.legajo = legajo;
			this.sueldo = sueldo;
		}
		
		public Empleado(string nombre, string dni, string legajo, int sueldo, bool esEncargado)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.legajo = legajo;
			this.sueldo = sueldo;
			this.esEncargado = esEncargado;
		}
		
		// Propiedades
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Dni
		{
			set {dni = value;}
			get {return dni;}
		}
		public string Puesto
		{
			set {puesto = value;}
			get {return puesto;}
		}
		public string Legajo
		{
			set {legajo = value;}
			get {return legajo;}
		}
		public int Sueldo
		{
			set {sueldo = value;}
			get {return sueldo;}
		}
		public bool EsEncargado
		{
			set {esEncargado = value;}
			get {return esEncargado;}
		}
	}
}
