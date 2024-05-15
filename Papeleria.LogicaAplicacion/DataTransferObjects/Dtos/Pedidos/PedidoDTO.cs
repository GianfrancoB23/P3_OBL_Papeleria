using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos
{
    public class PedidoDTO
    {
        public DateTime FechaEntrega { get; set; }
        public int ClienteSeleccionadoID { get; set; }
        public List<LineaPedidoDTO> LineasPedido { get; set; }
    }
}
