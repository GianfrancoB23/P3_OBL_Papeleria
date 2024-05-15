using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos
{
    public interface IGetPedido
    {
        PedidoDTO GetByIdDTO(int id);
        Pedido GetById(int id);
        IEnumerable<PedidoDTO> GetPedidosPorFecha(DateTime date);
    }
}
