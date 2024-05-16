using Papeleria.LogicaAplicacion.InterfacesCasosUso.Pedidos;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Pedidos
{
    public class AnularPedido : IAnularPedido
    {
        private IRepositorioPedido _repoPedidos;

        public AnularPedido(IRepositorioPedido _repositorioPedidos)
        {
            _repoPedidos = _repositorioPedidos;
        }
        public void Ejecutar(int id)
        {
            _repoPedidos.Anular(id);
        }
    }
}
