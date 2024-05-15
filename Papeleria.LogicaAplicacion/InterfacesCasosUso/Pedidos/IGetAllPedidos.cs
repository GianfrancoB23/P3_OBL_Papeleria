using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Pedidos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos
{
    public interface IGetAllPedidos
    {
        public IEnumerable<PedidoDTO> Ejecutar();
    }
}
