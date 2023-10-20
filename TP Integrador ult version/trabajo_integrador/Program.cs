/*
 * Creado por SharpDevelop.
 * Usuario: steven
 * Fecha: 02/10/2023
 * Hora: 11:01 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace trabajo_integrador
{
	class Program
	{
		public static void Main(string[] args)
		{
			int opcion;
			
			SalonEventos ss = new SalonEventos("ss");
			
			MenuPrincipal();
			opcion = int.Parse(Console.ReadLine());
			while(opcion!=0)
			{
				if (opcion==1)
				{
					MenuAdministracion();
					char decision;
					opcion = int.Parse(Console.ReadLine());
					while(opcion!=0)
					{
						if (opcion == 1)
						{
							Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision== 's')
							{
								Console.WriteLine("Nombre: ");
								string nombre = Console.ReadLine();
								Console.WriteLine("DNI: ");
								string dni = Console.ReadLine();
								Console.WriteLine("Legajo: ");
								string legajo = Console.ReadLine();
								Console.WriteLine("Sueldo: ");
								int sueldo = int.Parse(Console.ReadLine());
								
								// se pregunta al usuario si el empleado a cargar sera un Encargado.
								
								
								Console.WriteLine("El nuevo empleado es un ENCARGADO? s/n");
								bool esencargado = false;
								char dec = char.Parse(Console.ReadLine());
								if(dec == 's')
								{
									esencargado = true;
									Console.WriteLine("Ingrese el plus de sueldo: ");
									int plusSueldo = int.Parse(Console.ReadLine());
									Encargado nuevoEncargado = new Encargado(nombre,dni,esencargado,legajo,sueldo,plusSueldo);
									nuevoEncargado.AgregarPlus(nuevoEncargado);
								}
								else
								{
									Console.WriteLine("Puesto: ");
									string puesto = Console.ReadLine();
									Empleado nuevoEmpleado = new Empleado(nombre,dni,puesto,legajo,sueldo);
									ss.AgregarEmpleado(nuevoEmpleado);
								}
								Console.WriteLine("¿Desea cargar un nuevo empleado? s/n");
								decision = char.Parse(Console.ReadLine());	
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
							
						}
						else if (opcion == 2)
						{
							Console.WriteLine("¿Desea dar de baja un empleado? s/n");
							decision = char.Parse(Console.ReadLine());
							while (decision == 's')
							{
								Console.WriteLine("Ingrese el legajo del empleado a dar de baja:");
								string legajo = Console.ReadLine();
								ss.EliminarEmpleado(legajo);
								Console.WriteLine("¿Desea dar de baja a otro empleado? s/n");
								decision = char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
								
						}
						/*else if (opcion == 5)
						{
							Console.WriteLine("¿Desea dar de baja a un encargado? s/n");
							decision = char.Parse(Console.ReadLine());
							while(decision == 's')
							{
								Console.WriteLine("Ingrese el legajo del encargado a dar de baja:");
								string legajo = (Console.ReadLine());
								ss.EliminarEncargado(legajo);
								Console.WriteLine("'¿Desea dar de baja a otro encargado? s/n");
								decision = char.Parse(Console.ReadLine());
							}
							MenuAdministracion();
							opcion = int.Parse(Console.ReadLine());
						}*/
					}
				}
					
				if (opcion==2)
				{
					MenuEventos();
					char decision;
					opcion = int.Parse(Console.ReadLine());
					while(opcion!=0)
					{
						if(opcion==1)
						{
							Console.WriteLine("A continuación se solicitarán datos para contratar un evento.");
							Console.WriteLine("Nombre del cliente:");
							string nombreCliente = Console.ReadLine();
							Console.WriteLine("DNI del cliente:");
							string dniCliente = Console.ReadLine();
							Console.WriteLine("Fecha del evento: DD/MM/AA");
							string fecha = Console.ReadLine();
							Console.WriteLine("Hora del evento: XX:XX");
							string hora = Console.ReadLine();
							Console.WriteLine("Tipo de evento:");
							string tipo = Console.ReadLine();
							
							//Mostrar encargados
							Console.WriteLine("Lista de encargados:");
							foreach(Empleado encargadosDisponibles in ss.ListaEmpleados)
							{
								if (encargadosDisponibles.EsEncargado)
								{
									Console.WriteLine("Nombre: {0}, Legajo: {1}.",encargadosDisponibles.Nombre,encargadosDisponibles.Legajo);
								}
							}
							//Elegir encargado
							Console.WriteLine("Seleccione un encargado (ingrese su legajo):");
							string legajo = Console.ReadLine();
							Empleado encargadoSeleccionado=null;
							foreach(Empleado encargadosDisponibles in ss.ListaEmpleados)
							{
								if (legajo == encargadosDisponibles.Legajo)
								{
									encargadoSeleccionado = encargadosDisponibles;
									break;
								}
							}
							Console.WriteLine("Precio del evento");
							int precioEvento = int.Parse(Console.ReadLine());
							ArrayList serviciosContratados = new ArrayList();
							Eventos eventoContratado = new Eventos(nombreCliente,dniCliente,fecha,hora,tipo,encargadoSeleccionado,precioEvento,serviciosContratados);
							MenuEventos();
							opcion = int.Parse(Console.ReadLine());
						}
						else if(opcion==2)
						{
							Console.WriteLine("Desea cancelar un evento? s/n");
							decision = char.Parse(Console.ReadLine());
							while (decision == 's')
							{
								Console.WriteLine("Ingrese la fecha del evento a cancelar (DD/MM/AA)");
								string fecha = Console.ReadLine();
								Console.WriteLine("Ingrese la hora del evento a cancelar (XX:XX)");
								string hora = Console.ReadLine();
								Console.WriteLine("Ingrese el tipo de evento a cancelar");
								string tipo = Console.ReadLine();
								Eventos eventoSeleccionado=null;
								foreach (Eventos eventosDisponibles in ss.ListaEventosContratados)
								{
									if(eventosDisponibles.Fecha==fecha  & eventosDisponibles.Hora==hora & eventosDisponibles.Tipo==tipo)
									{
										eventoSeleccionado = eventosDisponibles;
										ss.CancelarEvento(eventoSeleccionado);
										break;
									}
								}
							}
							MenuEventos();
							opcion = int.Parse(Console.ReadLine());
						}
						else if(opcion==3)
						{
							Console.WriteLine("Seleccione la fecha, hora y tipo de evento para agregarle servicios");
							Console.WriteLine("Ingrese la fecha: (DD/MM/AA)");
							string fecha = Console.ReadLine();
							Console.WriteLine("Ingrese la hora: (XX:XX)");
							string hora = Console.ReadLine();
							Console.WriteLine("Ingrese el tipo de evento:");
							string tipo = Console.ReadLine();
							Eventos eventoSeleccionado=null;
							foreach (Eventos eventosDisponibles in ss.ListaEventosContratados)
							{
								if(eventosDisponibles.Fecha==fecha  & eventosDisponibles.Hora==hora & eventosDisponibles.Tipo==tipo)
								{
									eventoSeleccionado=eventosDisponibles;
									Console.WriteLine("¿Desea agregar un servicio? s/n");
									decision = char.Parse(Console.ReadLine());
									while(decision== 's')
									{
										Console.WriteLine("Codigo:");
										string scodigo = Console.ReadLine();
										Console.WriteLine("Tipo:");
										string stipo = Console.ReadLine();
										Console.WriteLine("Descripcion:");
										string sdescripcion = Console.ReadLine();
										Console.WriteLine("Costo Unitario:");
										int scosto = int.Parse(Console.ReadLine());
										Console.WriteLine("Cantidad de unidades:");
										int scantidad = int.Parse(Console.ReadLine());
										Servicios nuevoServicio = new Servicios(scodigo,stipo,sdescripcion,scosto,scantidad);
										eventoSeleccionado.AgregarServicio(nuevoServicio);
										Console.WriteLine("¿Desea agregar otro servicio? s/n");
										decision=char.Parse(Console.ReadLine());
									}
								}
							}
							MenuEventos();
							opcion = int.Parse(Console.ReadLine());
						}
						else if(opcion==4)
						{
							Console.WriteLine("Seleccione la fecha, hora y tipo de evento para agregarle servicios");
							Console.WriteLine("Ingrese la fecha: (DD/MM/AA)");
							string fecha = Console.ReadLine();
							Console.WriteLine("Ingrese la hora: (XX:XX)");
							string hora = Console.ReadLine();
							Console.WriteLine("Ingrese el tipo de evento:");
							string tipo = Console.ReadLine();
							Eventos eventoSeleccionado=null;
							foreach (Eventos eventosDisponibles in ss.ListaEventosContratados)
							{
								if(eventosDisponibles.Fecha==fecha  & eventosDisponibles.Hora==hora & eventosDisponibles.Tipo==tipo)
								{
									Console.WriteLine("Desea eliminar un servicio? s/n");
									decision = char.Parse(Console.ReadLine());
									while(decision == 's')
									{
										Console.WriteLine("Ingrese el codigo del servicio a eliminar:");
										string codigo = Console.ReadLine();
										eventoSeleccionado.EliminarServicio(codigo);
										Console.WriteLine("Desea eliminar otro servicio?");
										decision = char.Parse(Console.ReadLine());
									}
								}
							}
							MenuEventos();
							opcion = int.Parse(Console.ReadLine());
						}
					}
						
				}
				MenuPrincipal();
				opcion = int.Parse(Console.ReadLine());
			}
		
			
			
			foreach(Empleado e in ss.ListaEmpleados )
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		// Funciones.
		
		public static void MenuPrincipal()
		{
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("SALON DE EVENTOS SS");
			Console.WriteLine("MENU PRINCIPAL");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("1- Menu administrativo");
			Console.WriteLine("2- Menú de eventos");
			Console.WriteLine("3- Submenú");
			Console.WriteLine("0- Salir");
			Console.WriteLine("---------------------------------------------------------------");
			Console.WriteLine("---------------------------------------------------------------");
		}
		public static void MenuAdministracion()
		{
			Console.WriteLine("1- Dar de alta empleado");
			Console.WriteLine("2- Dar de baja empleado");
			Console.WriteLine("0- Volver");
		}
		public static void MenuEventos()
		{
			Console.WriteLine("1- Contratar un evento.");
			Console.WriteLine("2- Eliminar un evento.");
			Console.WriteLine("3- Agregar un servicio para un evento.");
			Console.WriteLine("4- Eliminar un servicio para un evento.");
			Console.WriteLine("0- Volver");
		}
	}
}