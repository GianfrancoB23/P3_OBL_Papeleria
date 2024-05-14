using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos
{
    public class PedidoAltaDto
    {
        public DateTime FechaEntrega { get; set; }
        public int ClienteSeleccionadoID { get; set; }
        public List<LineaPedidoListadoDto> LineasPedido { get; set; }
    }
}
