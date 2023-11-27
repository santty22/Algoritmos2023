using System;

namespace trabajo_integrador
{
	public class DecisionExcepcion : Exception  
	{
		public string motivo;
		public DecisionExcepcion(string motivo)
		{
			this.motivo = motivo;
		}
	}
}
