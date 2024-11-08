﻿using Empresa.LogicaDeNegocio.Entidades;
using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
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
        private PapeleriaContext _db;
        public RepositorioPedidoEF()
        {
            _db = new PapeleriaContext();
        }

        public void Add(Pedido obj)
        {
            try
            {
                _db.ChangeTracker.Clear(); // NO TOCAR :)
                _db.Pedidos.Attach(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new PedidoNoValidoException(ex.Message);
            }
            
        }

        public IEnumerable<Pedido> GetAll()
        {
            List<Cliente> clientes = _db.Clientes.ToList(); // NO TOCAR :)
            List<Articulo> articulos = _db.Articulos.ToList();
            List<Pedido> pedidos = _db.Pedidos.ToList();
            var lineas = _db.LineasPedidos.ToList();
            foreach (Pedido pedido in pedidos)
            {
                var filtrados = lineas;

            }
            return pedidos;
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
            Pedido pedidoEncontrado = _db.Pedidos.FirstOrDefault(p => p.Id == pedido.Id);
            if (pedidoEncontrado != null)
            {
                return pedidoEncontrado;
            }
            return null;
        }

        public IEnumerable<Pedido> GetPedidosPorCliente(Cliente cliente)
        {
            List<Pedido> pedidosCliente = _db.Pedidos.Where(p => p.cliente.Id == cliente.Id).ToList();
            return pedidosCliente;
        }

        public IEnumerable<Pedido> GetPedidosPorDireccion(DireccionCliente direccionPedido)
        {
            var pedidosPorDireccion = _db.Pedidos.Where(p => p.cliente.direccion == direccionPedido).ToList();
            return pedidosPorDireccion;
        }

        public IEnumerable<Pedido> GetPedidosPorRazon(RazonSocial rsocial)
        {
            return _db.Pedidos.Where(p => p.cliente.razonSocial.Equals(rsocial)).ToList();
        }

        public IEnumerable<Pedido> GetPedidosPorRUT(RUT rut)
        {
            return _db.Pedidos.Where(p => p.cliente.rut.Rut == rut.Rut).ToList();
        }

        public IEnumerable<Pedido> GetPedidosQueSuperenMonto(double monto)
        {
            List<Cliente> clientes = _db.Clientes.ToList(); // NO TOCAR :)
            var pedidos = _db.Pedidos.ToList();
            var pedidosSuperaronMonto = pedidos.Where(pedido => pedido.precioFinal >= monto);
            var cantidad = pedidosSuperaronMonto.Count();
            return pedidosSuperaronMonto;
        }

        public IEnumerable<Pedido> GetPedidosPorFecha(DateTime date)
        {

            IEnumerable<Pedido> pedidos = _db.Pedidos.Where(pedido => pedido.fechaPedido.Date == date);
            return pedidos;
        }
        public void Remove(int id)
        {
            var pedido = _db.Pedidos.FirstOrDefault(p => p.Id == id);
            if (pedido != null)
            {
                _db.Pedidos.Remove(pedido);
                _db.SaveChanges();
            }
        }

        public void Remove(Pedido obj)
        {
            _db.Pedidos.Remove(obj);
            _db.SaveChanges();
        }

        public void Update(int id, Pedido obj)
        {
            throw new NotImplementedException();
        }
        public void Anular(int id)
        {
            var pedido = _db.Pedidos.FirstOrDefault(p => p.Id == id);

            if (pedido != null)
            {
                try
                {
                    pedido.AnularPedido();
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new PedidoNoValidoException(ex.Message);
                }
            }
            else
            {
                throw new UsuarioNuloExcepcion("El pedido no existe");
            }
        }
    }
}
