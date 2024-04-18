using Empresa.LogicaDeNegocio.InterfacesRepositorios;

using System.Collections.Generic;
using System;
using Empresa.LogicaDeNegocio.Entidades;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioPedidos : IRepositorio<Pedido>
    {
		public IEnumerable<Pedido> GetPedidosSuperen(Double monto);

		public IEnumerable<Pedido> GetPedidosAnuladosYOrdenadosXFecha();
		public IEnumerable<Pedido> GetPedidos();
		public Pedido GetPedido(int id);
		public Pedido GetPedidoByCliente(Cliente cliente);

	}

}

