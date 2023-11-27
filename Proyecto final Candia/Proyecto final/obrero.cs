/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 31/10/2023
 * Hora: 15:40
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Proyecto_final
{
	public class Obrero
	{
		//Atributos
		
		protected string nomyap;
		protected int dni;
		protected int legajo;
		protected double sueldo;
		protected bool esJefe;
		protected string cargo;
	    	
	    //Constructor
		
	    public Obrero(string nomyap, int dni, int legajo, double sueldo, string cargo)
    {
        this.nomyap = nomyap;
        this.dni = dni;
        this.legajo = legajo;
        this.sueldo = sueldo;
        this.cargo = cargo;
	}
	    public Obrero(string nomyap, int dni, int legajo, double sueldo, bool esJefe)
    {
        this.nomyap = nomyap;
        this.dni = dni;
        this.legajo = legajo;
        this.sueldo = sueldo;
        this.esJefe = esJefe;
	}
	    
	    //Propiedades
	    
	    public string Nomyap
	    {
			set {nomyap = value;}
			get {return nomyap;}
	    }
	    
	    public int DNI
	    {
			set {dni = value;}
			get {return dni;}
	    }
	    
	    public int Legajo
	    {
			set {legajo = value;}
			get {return legajo;}
	    }
	    
	    public double Sueldo
	    {
			set {sueldo = value;}
			get {return sueldo;}
	    }
	    
	    public string Cargo
	    {
	    	set {cargo = value;}
			get {return cargo;}
	    }
		public bool EsJefe
	    {
			set {esJefe = value;}
			get {return esJefe;}
	    }
		
		//Metodos
		
}
}