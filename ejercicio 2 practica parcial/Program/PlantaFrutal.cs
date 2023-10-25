/*
 * Creado por SharpDevelop.
 * Usuario: Santy
 * Fecha: 22/10/2023
 * Hora: 03:07
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Program
{
	public class PlantaFrutal : Planta
	{
		private string fruta;
		
		public PlantaFrutal(string nombre, string nomEsp, double precio, string epocaSiembra, string fruta) : base(nombre, nomEsp, precio, epocaSiembra)
		{
			this.fruta=fruta;
		}
		
		public string Fruta
		{
			set{fruta = value;}
			get{return fruta;}
		}
		
	}
}
