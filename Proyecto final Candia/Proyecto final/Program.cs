/*
 * Creado por SharpDevelop.
 * Usuario: Marcos
 * Fecha: 31/10/2023
 * Hora: 15:29
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto_final
{
	class Program
	{
		public static void Main(string[] args)
		{
				
	    	EmpresaConstructora sp = new EmpresaConstructora("markotina S.A");
	
	        int opcion;
	        string decision;
	        MostrarMenu();
	        Console.WriteLine("Elija la opción deseada.");
	        opcion = int.Parse(Console.ReadLine());
	        while(opcion!=0)
	        {
	        	if(opcion==1)
	        	{
	        		Console.WriteLine("Desea agregar un obrero?");
	        		decision=Console.ReadLine();
	        		while(decision=="si")
	        		{
	        			Console.WriteLine("Nombre y apellido:");
	        			string nomyap=Console.ReadLine();
	        			Console.WriteLine("DNI:");
	        			int dni=int.Parse(Console.ReadLine());
	        			Console.WriteLine("Legajo:");
	        			int legajo=int.Parse(Console.ReadLine());
	        			Console.WriteLine("Sueldo:");
	        			double sueldo=double.Parse(Console.ReadLine());
	        			
	        			Console.WriteLine("El obrero es jefe de algún grupo?");
	        			string dec=Console.ReadLine();
	        			if(dec=="si")
	        			{
	        				bool esJefe = true;
	        				Console.WriteLine("Cuál es su grupo a cargo?");
	        				int grupoacargo=int.Parse(Console.ReadLine());
	        				Jefe nuevoJefe = new Jefe(nomyap,dni,legajo,sueldo,esJefe,grupoacargo);
	        				sp.AgregarObrero(grupoacargo,nuevoJefe);
	        			}
	        			else
	        			{
	        				Console.WriteLine("Cargo:");
	        				string cargo=Console.ReadLine();
	        				Console.WriteLine("A qué grupo pertenece?");
	        				int grupodelobrero=int.Parse(Console.ReadLine());
	        				Obrero nuevoObrero = new Obrero(nomyap,dni,legajo,sueldo,cargo);
	        				sp.AgregarObrero(grupodelobrero,nuevoObrero);
	        			}
	        			Console.WriteLine("Desea agregar un nuevo obrero?");
	        			decision = Console.ReadLine();
	        		}
	        	}
	        	if (opcion==2)
	        	{
	        		Console.WriteLine("Desea eliminar un obrero?");
	        		decision=Console.ReadLine();
	        		while(decision=="si")
	        		{
	        			Console.WriteLine("Ingrese el número de legajo del obrero:");
	        			int legajo = int.Parse(Console.ReadLine());
	        			sp.EliminarObrero(legajo);
	        			Console.WriteLine("Desea eliminar un obrero?");
	        			decision=Console.ReadLine();
	        		}
	        	}
	        	if (opcion==3)
	        	{
	        		MostrarSubmenu();
	        		Console.WriteLine("Elija una opción");
	        		char num=char.Parse(Console.ReadLine());
	        		while (num!=0)
	        		{
	        			if(num==1)
	        			{
	        				sp.ListadodeObreros();
	        			}
	        		}
	        	}
	        	if (opcion==4)
	        	{
	        		Console.WriteLine("Desea agregar una obra?");
					decision=Console.ReadLine();
					while(decision=="si")
					{
						Console.WriteLine("Ingrese nombre del propietario de la obra:");
						string nomProp= Console.ReadLine();
						Console.WriteLine("Ingrese el DNI del propietario:");
						int dniProp= int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el código de la obra (no debe coincidir con otra obra agregada previamente):");
						int codInt=int.Parse(Console.ReadLine());
						Console.WriteLine("Ingrese el tipo de obra a realizar:");
						string tipo=Console.ReadLine();
						Console.WriteLine("Ingrese el tiempo estimado de ejecución (en días):");
						string tiempo=Console.ReadLine();
						int avance= 0;
						Console.WriteLine("Listado de jefes:");
						foreach (Grupos g in sp.ListaGrupos)
						{
							Console.WriteLine("Grupo {0}:",g.NumGrupo);
							foreach(Jefe j in g.ListaObrero)
							{
								Console.WriteLine("Nombre: {0}. DNI: {1}. Legajo: {2}.",j.Nomyap,j.DNI,j.Legajo);
							}
						}
						Console.WriteLine("Seleccione al jefe a cargo de la obra (ingrese legajo):");
						int legajo= int.Parse(Console.ReadLine());
						Jefe jefeSel=null;
						foreach (Grupos g in sp.ListaGrupos)
						{
							foreach(Jefe jefeDisp in g.ListaObrero)
							{
								if(legajo==jefeDisp.Legajo)
								{
									jefeSel= (Jefe)jefeDisp;
									break;
								}
							}
						}
						Console.WriteLine("Ingrese el nombre de la obra:");
						string nomObra=Console.ReadLine();
						Console.WriteLine("Ingrese el costo de la obra:");
						int costo=int.Parse(Console.ReadLine());
						
						Obra nuevaObra = new Obra(nomProp, dniProp, codInt, tipo, tiempo, avance, jefeSel,nomObra,costo);
						sp.AgregarObra(nuevaObra);
						
						Console.WriteLine("Desea agregar una nueva obra?");
						decision=Console.ReadLine();
					}
	        	}
	        	
	               // case 5:
	                   // ModificarAvanceObra();
	                   // break;
	               // case 6:
	                //    DarDeBajaJefe();
	                   // break;
	               // case 0:
	                    //Console.WriteLine("Saliendo del programa. ¡Hasta luego!");
	                   // break;
	                //default:
	                 //   Console.WriteLine("Opción no válida. Inténtelo nuevamente.");
	                   // break;*/
	            
	            Console.WriteLine("Elija la opción deseada.");
        		opcion = int.Parse(Console.ReadLine());
	        }
        }
    

   	 	public static void MostrarMenu()
    	{
        	Console.WriteLine("----- Menú Principal -----");
        	Console.WriteLine("1. Contratar un obrero nuevo");
        	Console.WriteLine("2. Eliminar un obrero");
        	Console.WriteLine("3. Submenú de impresión");
        	Console.WriteLine("4. Agregar una obra y asignarle un jefe");
        	Console.WriteLine("5. Modificar el estado de avance de una obra");
        	Console.WriteLine("6. Dar de baja a un jefe");
        	Console.WriteLine("0. Salir");
    	}

	    public static void MostrarSubmenu()
	    {
	        int opcionSubMenu;
	        do
	        {
	            Console.WriteLine("----- Submenú de Impresión -----");
	            Console.WriteLine("1. Listado de obreros");
	            Console.WriteLine("2. Obras en ejecución con más del 50% de avance");
	            Console.WriteLine("3. Obras finalizadas");
	            Console.WriteLine("4. Listado de jefes");
	            Console.WriteLine("0. Volver al Menú Principal");
	           	opcionSubMenu = LeerEntero("Ingrese la opción deseada: ");
	
	
	            switch (opcionSubMenu)
	            {
	                case 1:
	                    // Implementar listado de obreros
	                    break;
	                case 2:
	                    // Implementar listado de obras en ejecución con más del 50% de avance
	                    break;
	                case 3:
	                    // Implementar listado de obras finalizadas
	                    break;
	                case 4:
	                    // Implementar listado de jefes
	                    break;
	                case 0:
	                    Console.WriteLine("Volviendo al Menú Principal");
	                    break;
	                default:
	                    Console.WriteLine("Opción no válida. Inténtelo nuevamente.");
	                    break;
	            }
	
	        } while (opcionSubMenu != 0);
	    }
			public static int LeerEntero(string mensaje)
	    {
	        int numero;
	        Console.Write(mensaje);
	        while (!int.TryParse(Console.ReadLine(), out numero))
	        {
	            Console.WriteLine("Entrada no válida. Inténtelo nuevamente.");
	            Console.Write(mensaje);
	        }
	        return numero;
	    }
		
			
		//metodos
		
		// iniciar obra
		
		
		//avance de la obra 
		//eliminar_obra
		//asignar jefe de obra
		//bajar jefe de obra
		
	
		//obras de ejecucion
		}
	
	
	
}