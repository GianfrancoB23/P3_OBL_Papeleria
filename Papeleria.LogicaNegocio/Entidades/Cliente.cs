using Papeleria.LogicaNegocio.Entidades.ValueObjects;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Cliente
	{
		public RUT rut{ get; set; }

		public RazonSocial razonSocial{ get; set; }

		public Direccion direccion{ get; set; }

		public List<Pedido> pedidos{ get; set; }

		private RUT rUT;

		private RazonSocial razonSocial;

		private IValidable iValidable;

		private IEntity iEntity;

		private Direccion direccion;

		private Pedido pedido;

		private IEquatable_T_ iEquatable_T_;

		public bool EsValido()
		{
			return null;
		}

	}

}

