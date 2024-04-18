﻿using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioClienteEF : IRepositorioCliente
    {
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Cliente obj)
        {
            try
            {
                _db.Clientes.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new ClienteNoValidoException(ex.Message);
            }
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById(int id)
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

        public void Remove(Cliente obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}