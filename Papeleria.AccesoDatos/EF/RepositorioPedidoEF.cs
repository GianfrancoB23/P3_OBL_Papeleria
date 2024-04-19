using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioPedidoEF : IRepositorioPedido
    {
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Pedido obj)
        {
            _db.Pedidos.Add(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Pedido> GetAll()
        {
            return _db.Pedidos.ToList();
        }

        public Pedido GetById(int id)
        {
            Pedido? pedido= _db.Pedidos.FirstOrDefault(pedido => pedido.Id == id);
            return pedido;
        }

        public IEnumerable<Pedido> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public Pedido GetPedido(Pedido pedido)
        {
            throw new NotImplementedException();
        }

        public Pedido GetPedidoById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosPorCliente(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosPorDireccion(DireccionCliente direccionPedido)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosPorRazon(RazonSocial rsocial)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosPorRUT(RUT rut)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetPedidosQueSuperenMonto(double monto)
        {

            IEnumerable<Pedido> pedidos = _db.Pedidos.Where(pedido => pedido.precioFinal >= monto);
            return pedidos;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Pedido obj)
        {
            throw new NotImplementedException();
        }
    }
}
