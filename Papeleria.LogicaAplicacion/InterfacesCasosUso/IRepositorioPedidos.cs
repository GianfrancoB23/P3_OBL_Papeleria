using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using System.Collections.Generic;
using System;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioPedidos : IRepositorio_T_
	{
		private RepositorioPedidos Memoria repositorioPedidos Memoria;

		private RepositorioPedidosEF repositorioPedidosEF;

		IEnumerable<Pedido> GetPedidosSuperen(Double monto);

		IEnumerable<Pedido> GetPedidosAnuladosYOrdenadosXFecha();

	}

}

