/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 04:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;


namespace trabajo_integrador
{
	public class Eventos
	{
		
		// Datos Miembro
		
		private string nombreCliente;
		private string dniCliente;
		private string fecha; //CONSULTAR
		private string hora;
		private string tipo;
		private int precioEvento;
		private Empleado encargado;
		private ArrayList serviciosContratados;
		
		// Constructor
		
		public Eventos(string nombreCliente, string dniCliente, string fecha, string hora, string tipo, Empleado encargado, int precioEvento, ArrayList serviciosContratados)
		{
			this.nombreCliente = nombreCliente;
			this.dniCliente = dniCliente;
			this.fecha = fecha;
			this.hora = hora;
			this.tipo = tipo;
			this.encargado = encargado;
			this.precioEvento = precioEvento;
			this.serviciosContratados = new ArrayList();
		}
		
		// Propiedades.
		
		public string NombreCliente
		{
			set {nombreCliente = value;}
			get {return nombreCliente;}
		}
		public string DniCliente
		{
			set {dniCliente = value;}
			get {return dniCliente;}
		}
		public string Fecha
		{
			set {fecha = value;}
			get {return fecha;}
		}
		public string Hora
		{
			set {hora = value;}
			get {return hora;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		public int PrecioEvento
		{
			set {precioEvento = value;}
			get {return precioEvento;}
			
		}
		public Empleado Encargado
		{
			set {encargado = value;}
			get {return encargado;}
		}
		public ArrayList ServiciosContratados
		{
			get {return serviciosContratados;}
		}
		
		// Metodos
		public void AgregarServicio(Servicios servicio)
		{
			serviciosContratados.Add(servicio);
			Console.WriteLine("Servicio cargado correctamente.");
		}
		
		public void EliminarServicio(string codigo)
		{
			bool estado = false;
			foreach(Servicios serviciosCargados in serviciosContratados)
			{
				if(serviciosCargados.Codigo == codigo)
				{
					estado = true;
					serviciosContratados.Remove(serviciosCargados);
					break;
				}
			}
			if (estado)
			{
				Console.WriteLine("Servicio eliminado correctamente.");
			}
			else
			{
				Console.WriteLine("No se ha encontrado el servicio.");
			}
		}
	}
}
