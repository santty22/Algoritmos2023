/*
 * Created by SharpDevelop.
 * User: Almnos
 * Date: 1/11/2023
 * Time: 20:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto_final
{
	public class EmpresaConstructora
	{
		//Atributos
		
		private string nombre;
    	private ArrayList listaGrupos;
		private ArrayList listaObras;
		private ArrayList obrasFinalizadas;
		
		//Constructores
		
		public EmpresaConstructora(string nombre)
		{
			this.nombre = nombre;
			listaGrupos = new ArrayList();
			listaObras = new ArrayList();
			obrasFinalizadas = new ArrayList();
		}
		
		//Propiedades
		
		public string Nombre
		{
			set{nombre=value;}
			get{return nombre;}
		}
		public ArrayList ListaGrupos
		{
			get{return listaGrupos;}
		}
		public ArrayList ListaObras
		{
			get{return listaObras;}
		}
		public ArrayList ObrasFinalizadas
		{
			get{return obrasFinalizadas;}
		}
		//Metodos
		
		public void AgregarObrero(int grupo, Obrero obrero)
		{
			foreach (Grupos g in listaGrupos)
			{
				if (g.NumGrupo==grupo)
				{
					g.ListaObrero.Add(obrero);
					Console.WriteLine("Obrero agregado correctamente al grupo {0}.",g.NumGrupo);
				}
			}
		}
		
		public void EliminarObrero(int legajo)
		{
			bool obreroeliminado=false;
			foreach (Grupos g in listaGrupos)
			{
				foreach(Obrero o in g.ListaObrero)
					{
						if (o.Legajo==legajo)
						{
							g.ListaObrero.Remove(o);
							obreroeliminado=true;
							break;
						}
					}
			}
			if (obreroeliminado)
			{
				Console.WriteLine("Obrero eliminado correctamente.");
			}
			else
			{
				Console.WriteLine("El obrero no se encontró o no se pudo eliminar.");
			}
		}
		
		public void ListadodeObreros()
		{
			foreach (Grupos g in listaGrupos)
			{
				Console.WriteLine("Grupo {0}:",g.NumGrupo);
				foreach(Obrero o in g.ListaObrero)
					{
						Console.WriteLine("Nombre: {0}. DNI: {1}. Legajo: {2}.",o.Nomyap,o.DNI,o.Legajo);
					}
			}
		}
		/*public void ListadodeJefes()
		{
			foreach (Grupos g in listaGrupos)
			{
				Console.WriteLine("Grupo {0}:",g.NumGrupo);
				foreach(Jefe j in g.ListaObrero)
					{
						Console.WriteLine("Nombre: {0}. DNI: {1}. Legajo: {2}.",j.Nomyap,j.DNI,j.Legajo);
					}
			}
		}*/
		public void AgregarObra(Obra nuevaObra)
		{
			listaObras.Add(nuevaObra);
			Console.WriteLine("Obra agregada correctamente.");
		}
	}
}
