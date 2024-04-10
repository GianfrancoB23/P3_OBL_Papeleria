using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.Collections.Generic;

namespace Empresa.LogicaDeNegocio.Entidades
{
    public class Articulo : IValidable<Articulo>, IEquatable<Articulo>, IEntity
	{
        public int Id { get; set; }
        public CodigoProveedorArticulos codigoProveedor{ get; set; }

		public NombreArticulo nombreArticulo{ get; set; }

		public DescripcionArticulo descripcion{ get; set; }

		public int precioVP{ get; set; }

		public StockArticulo stock{ get; set; }


		private ICollection<LineaPedido> linea = new List<LineaPedido>();

        public Articulo(CodigoProveedorArticulos codigoProveedor, NombreArticulo nombre, DescripcionArticulo descripcion, int precioVP, StockArticulo stock)
        {
            this.codigoProveedor = codigoProveedor;
            this.nombreArticulo = nombre;
            this.descripcion = descripcion;
            this.precioVP = precioVP;
            this.stock = stock;
        }

        public Articulo()
        {
            
        }

        public void RestarStock()
		{

		}

        public bool Equals(Articulo? other)
        {
            if (other == null) return false;
            return this.nombreArticulo == other.nombreArticulo;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            return this.Equals(obj as Articulo);

        }

        public void esValido()
        {
            throw new NotImplementedException();
        }
    }
}

