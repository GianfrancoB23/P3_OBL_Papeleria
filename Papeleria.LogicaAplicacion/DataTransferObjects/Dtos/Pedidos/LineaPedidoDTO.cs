using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos
{
    public class LineaPedidoDTO
    {
        public int id { get; set; }
        public int idArticulo { get; set; }
        public long CodigoProveedor { get; set; }
        public string NombreArticulo { get; set; }
        public string Descripcion { get; set; }
        public double PrecioVP { get; set; }
        public int Stock { get; set; }
        public int Cantidad { get; set; }
        public double PrecioUnitario { get; set; }
        public double Subtotal { get; set; }
    }
}
