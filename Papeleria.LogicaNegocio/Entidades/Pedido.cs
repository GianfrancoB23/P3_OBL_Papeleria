using System;
using System.Collections.Generic;
using Papeleria.LogicaNegocio.Entidades.ValueObjects;
using Papeleria.LogicaNegocio.InterfacesEntidades;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public abstract class Pedido
	{
		public DateTime fechaPedido{ get; set; }

		public Cliente cliente{ get; set; }

		public List<Linea> lineas{ get; set; }

		public double precioFinal{ get; set; }

		public double recargo{ get; set; }

		private IEntity iEntity;

		private ICollection<Linea> linea;

		private IVA iVA;

		private IValidable iValidable;

		private ICollection<Cliente> cliente;

		private IEquatable_T_ iEquatable_T_;

		public void CalcularYFijarPrecio(IVA iva)
		{

		}

		public void CambiarFechaPrometida()
		{

		}

		public double CalcularRecargoYFijar()
		{
			return 0;
		}

		public bool EsValido()
		{
			return null;
		}

	}

}

