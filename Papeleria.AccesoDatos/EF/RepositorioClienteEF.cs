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
        private PapeleriaContext _db;
        private IRepositorioPedido _repositorioPedido { get; set; }
        public RepositorioClienteEF(IRepositorioPedido repositorioPedido)
        {
            _db = new PapeleriaContext();
            _repositorioPedido = repositorioPedido;
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
            return _db.Clientes.FirstOrDefault(cli => cli.Id == idCliente);
        }

        public Cliente GetClientePorDireccion(DireccionCliente direccionCliente)
        {
            return _db.Clientes.FirstOrDefault(cli => cli.direccion.Equals(direccionCliente));
        }

        public Cliente GetClientePorRazon(string rsocial)
        {
            try
            {
                //No tocar, funciona...
                var clientes = _db.Clientes.ToList();
                var cliente = clientes.FirstOrDefault(c => c.razonSocial.RazonSoc.Equals(rsocial, StringComparison.OrdinalIgnoreCase)); //OrdinalIngnore case para que ignero mayusculas

                return cliente;
            }
            catch (Exception ex)
            {

                throw new ClienteNoValidoException("Error al buscar el cliente.");
            }

        }

        public Cliente GetClientePorRUT(long rut)
        {
            return _db.Clientes.FirstOrDefault(cli => cli.rut.Rut.Equals(rut));
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _db.Clientes.ToList();
        }

        public IEnumerable<Cliente> GetClientesPorPedido(int idPedido)
        {
            return _db.Clientes.Where(cli => cli.pedidos.Any(pedido => pedido.Id == idPedido)).ToList();
        }

        public IEnumerable<Cliente> GetClientesPedidoSupereMonto(double monto)
        {
            var pedidos = _repositorioPedido.GetPedidosQueSuperenMonto(monto);
            var clientes = pedidos.Select(pedido => pedido.cliente).Distinct();
            return clientes;
        }

        public IEnumerable<Cliente> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            var cliente = GetById(id);
            if (cliente != null)
            {
                _db.Clientes.Remove(cliente);
                _db.SaveChanges();
            }
        }

        public void Remove(Cliente obj)
        {
            if (obj != null)
            {
                _db.Clientes.Remove(obj);
                _db.SaveChanges();
            }
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
