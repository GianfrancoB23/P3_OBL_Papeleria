using Papeleria.LogicaNegocio.Entidades.ValueObjects;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Articulo
	{
		public CodigoProveedor codigoProveedor{ get; set; }

		public NombreArticulo nombre{ get; set; }

		public DescripcionArticulo descripcion{ get; set; }

		public int precioVP{ get; set; }

		public StockArticulo stock{ get; set; }

		private CodigoProveedor codigoProveedor;

		private NombreArticulo nombreArticulo;

		private DescripcionArticulo descripcionArticulo;

		private StockArticulo stockArticulo;

		private Linea linea;

		private ICollection<Linea> linea;

		private StockArticulo stockArticulo;

		private IValidable iValidable;

		private IEntity iEntity;

		private IEquatable_T_ iEquatable_T_;

		public void RestarStock()
		{

		}

		public bool EsValido()
		{
			return null;
		}

	}

}

