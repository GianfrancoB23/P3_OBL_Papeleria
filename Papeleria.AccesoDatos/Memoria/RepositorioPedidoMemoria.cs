﻿using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Memoria
{
    public class RepositorioPedidoMemoria : IRepositorioPedido
    {
        public void Add(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public Pedido GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Cliente GetCliente(int idCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorDireccion(DireccionCliente direccionCliente)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorRazon(RazonSocial rsocial)
        {
            throw new NotImplementedException();
        }

        public Cliente GetClientePorRUT(RUT rut)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetClientes()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> GetClientesPorPedido(int idPedido)
        {
            throw new NotImplementedException();
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