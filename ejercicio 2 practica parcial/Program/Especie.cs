/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 22/10/2023
 * Hora: 03:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Program
{
	public class Especie
	{
		protected string nombre;
		protected string tipo;
		
		public Especie(string nombre, string tipo)
		{
			this.nombre=nombre;
			this.tipo=tipo;
		}
		
		//Propiedades
		public string Nombre
		{
			set {nombre = value;}
			get {return nombre;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		
		//Metodos
		
	}
}
