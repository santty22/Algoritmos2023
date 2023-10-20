/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 03/10/2023
 * Hora: 04:15 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace trabajo_integrador
{
	public class Encargado : Empleado
	{
		// Datos Miembro.
		
		private int plusSueldo;
		
		// Constructores.
		
		public Encargado(string nombre, string dni, bool esencargado, string legajo, int sueldo, int plusSueldo) : base(nombre,dni,esencargado,legajo,sueldo)
		{
			this.plusSueldo = plusSueldo;
		}
		/*public Encargado(string nombre, string dni, string legajo, int sueldo, int plusSueldo) : base(nombre,dni,legajo,sueldo)
		{
			this.plusSueldo = plusSueldo;
		}*/
		
		// Propiedades.
		
		public int PlusSueldo
		{
			set {plusSueldo = value;}
			get {return plusSueldo;}
		}
		
		// Metodos
		
		public void AgregarPlus(Encargado encargado)
		{
			Sueldo = Sueldo + PlusSueldo;
		}
		
	}
}
