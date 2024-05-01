using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Microsoft.EntityFrameworkCore;
using Papeleria.AccesoDatos.Excepciones;
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
        private PapeleriaContext _db { get; set; }
        public RepositorioClienteEF(PapeleriaContext db)
        {
            _db = db;
        }

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
            return _db.Clientes.ToList();
        }

        public Cliente GetById(int id)
        {
            Cliente? cliente = _db.Clientes.FirstOrDefault(cli => cli.Id == id);
            return cliente;
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

        public IEnumerable<Cliente> GetObjectsByID(List<int> ids)
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
            if (id == null || obj == null)
            {
                throw new ArgumentNullRepositorioException("No se recibió ningun usuario.");
            }

            Cliente cliente = GetById(id);

            try
            {
                cliente.Update(obj);
                _db.Clientes.Update(cliente);
                _db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new InfraException("Hubo un problema, reintente.");
            }
        }
    }
}
