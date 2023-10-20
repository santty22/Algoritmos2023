/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 05:59 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	public class Servicios
	{	// Datos Miembro.
		
		private string codigo;
		private string tipo;
		private string descripcion;
		private int cantidad;
		private int costoUnitario;
		
		// Constructores.
		
		// Constructor con cantidad solicitada
		public Servicios(string codigo, string tipo, string descripcion, int costoUnitario, int cantidad)
		{
			this.codigo = codigo;
			this.tipo = tipo;
			this.descripcion = descripcion;
			this.costoUnitario = costoUnitario;
			this.cantidad = cantidad;
		}
		
		// Constructor sin cantidad solicitada
		public Servicios(string codigo, string tipo, string descripcion, int costoUnitario)
		{
			this.codigo = codigo;
			this.tipo = tipo;
			this.descripcion = descripcion;
			this.costoUnitario = costoUnitario;
		}
		
		// Propiedades.
		
		public string Codigo
		{
			set {codigo = value;}
			get {return codigo;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		public string Descripcion
		{
			set {descripcion = value;}
			get {return descripcion;}
		}
		public int Cantidad
		{
			set {cantidad = value;}
			get {return cantidad;}
		}
		public int CostoUnitario
		{
			set {costoUnitario = value;}
			get {return costoUnitario;}
		}
	}
}
