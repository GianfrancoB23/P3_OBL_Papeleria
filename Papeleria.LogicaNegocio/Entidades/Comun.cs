using Papeleria.LogicaNegocio.Entidades.ValueObjects;
using System;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Comun : Pedido
	{
		public DateTime entregaPrometida{ get; set; }

		public void CambiarFechaPrometida()
		{

		}

		public bool EsValido()
		{
			return null;
		}

		public void CalcularYFijarPrecio(IVA iva)
		{

		}

		public double CalcularRecargoYFijar()
		{
			return 0;
		}

	}

}

