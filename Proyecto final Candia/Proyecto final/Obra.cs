/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 31/10/2023
 * Hora: 20:04
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_final
{
	public class Obra
	{
		//Atributos
		
		private string nomProp;
		private int dniProp;
		private int codInt;
		private string tipo;
		private string tiempo;
		private int avance;
		private Jefe jefedeObra;
		private string nomObra;
		private double costo;
		
		//Constructores
		
		public Obra(string nomProp, int dniProp, int codInt, string tipo, string tiempo, int avance, Jefe jefedeObra, string nomObra, int costo)
		{
			this.nomProp=nomProp;
			this.dniProp=dniProp;
			this.codInt=codInt;
			this.tipo=tipo;
			this.tiempo=tiempo;
			this.avance=avance;
			this.jefedeObra=jefedeObra;
			this.nomObra=nomObra;
			this.costo=costo;	
		}
		
		//Propiedades
		
		public string NomProp
		{
			set {nomProp=value;}
			get {return nomProp;}
		}
		public int DniProp
		{
			set {dniProp = value;}
			get {return dniProp;}
		}
		public int CodInt
		{
			set {codInt = value;}
			get {return codInt;}
		}
		public string Tipo
		{
			set {tipo = value;}
			get {return tipo;}
		}
		public string Tiempo
		{
			set {tiempo = value;}
			get {return tiempo;}
		}
		public int Avance
		{
			set {avance = value;}
			get {return avance;}
		}
		public Jefe JefedeObra
		{
			set {jefedeObra = value;}
			get {return jefedeObra;}
		}
		public string NomObra
		{
			set {nomObra = value;}
			get {return nomObra;}
		}
		public double Costo
		{
			set {costo = value;}
			get {return costo;}
		}
		
		//Metodos
		public bool ModificarAvancedeObra(int porcentaje)
		{
			if(porcentaje==100)
			{
				Avance = (int)porcentaje;
				Console.WriteLine("La obra llegó al 100% por lo que será dada por finalizada.");
				return true;
			}
			if(porcentaje<100&&porcentaje>=0)
			{
				Avance = (int)porcentaje;
				Console.WriteLine("El estado de avance de la obra es de: {0}",Avance);
			}
			else
			{
				Console.WriteLine("El porcentaje ingresado no es correcto, debe ser menor a 100");
			}
			return false;
		}
	}
}