 /*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 31/10/2023
 * Hora: 20:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto_final
{
	public class Jefe : Obrero
	{
		//Atributos
		
		private int grupoacargo;
		
		//Constructores
		
		public Jefe(string nomyap, int dni, int legajo, double sueldo, bool esJefe, int grupoacargo) : base(nomyap, dni, legajo, sueldo, esJefe)
		{
			this.grupoacargo=grupoacargo;
		}
		
		//Metodos
		
		public double SueldoConBonificacion()
    	{
        	return Sueldo * 1.15;
    	}
		
		/*public ArrayList bajar_jefe(int legajo ,ArrayList grupodeJefe)
		{
			foreach(jefe obrero in grupodeJefe)
			{	
				if (int legajo == legajo)
				{
					grupodeJefe.remove(obrero);
				}
			}
			return grupodeJefe;
		}*/
	}
}