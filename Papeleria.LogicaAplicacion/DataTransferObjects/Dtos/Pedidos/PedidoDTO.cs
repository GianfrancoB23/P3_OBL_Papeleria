using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int ClienteID { get; set; }
        public List<LineaPedidoDTO> LineasPedido { get; set; }
        public double recargo { get; set; }
        public double iva { get; set; }
        public double precioFinal { get; set; }
        public bool entregado { get; set; }
        public bool anulado { get; set; }
    }
}
