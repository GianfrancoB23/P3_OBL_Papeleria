using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Articulo;
using Papeleria.LogicaNegocio.Excepciones.Articulo.ArticulosValueObjects.Linea;
using Papeleria.LogicaNegocio.InterfacesEntidades;
using System.ComponentModel.DataAnnotations.Schema;

namespace Papeleria.LogicaNegocio.Entidades
{
    public class LineaPedido : IValidable<LineaPedido>, IEntity
    {
        public int Id { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitarioVigente { get; set; }
        public Pedido pedido { get; set; }

        public LineaPedido(Articulo articulo, int cantidad)
        {
            Articulo = articulo;
            Cantidad = cantidad;
            PrecioUnitarioVigente = articulo.PrecioVP;
            esValido();
            this.pedido = null;
        }

        public LineaPedido()
        {

        }

        public void AsignarPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void esValido()
        {
            if (Articulo == null)
            {
                throw new ArticuloNuloException("El articulo no puede ser nulo en la linea del pedido.");
            }
            if (Cantidad == null || Cantidad < 1)
            {
                throw new LineaNuloException("La cantindad no puede ser nulo o menor a 1");
            }
        }
    }

}

