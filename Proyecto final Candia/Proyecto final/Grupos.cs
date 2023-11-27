/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 31/10/2023
 * Hora: 15:35
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto_final
{
	public class Grupos
	{
		//Atributos
		
		private int numGrupo;	
		private int obraActual;	
		private ArrayList listaObrero = new ArrayList();
		
		//Constructores
		
		public Grupos (int numGrupo, int obraActual)
		{
			this.numGrupo=numGrupo;
			this.obraActual=obraActual;
			listaObrero=new ArrayList();
		}
		
		//Propiedades
		
		public int NumGrupo
		{
			set {numGrupo = value;}
			get {return numGrupo;}
		}
		public int ObraActual
	    {
			set {obraActual = value;}
			get {return obraActual;}
	    }
		public ArrayList ListaObrero
		{
			get {return listaObrero;}
		}
		
		//seed de obreros
		/*Obrero obrero1 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero2 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero3 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero4 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero5 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero6 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero7 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero8 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		Obrero obrero9 = new Obrero("LucasCoronel",5215225,01,1000,"capataz","NoEsJefe");
		*/
	}
}