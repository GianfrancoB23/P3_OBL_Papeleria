using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos
{
    public interface IAltaPedido
    {
        void EjecutarExpress(PedidoDTO dto);
        void EjecutarComunes(PedidoDTO dto);
    }
}
