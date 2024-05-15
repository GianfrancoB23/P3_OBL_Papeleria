using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Papeleria.AccesoDatos.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes
{
    public class BuscarClientes : IBuscarClientes
    {
        private IRepositorioCliente _repoClientes;

        public BuscarClientes(IRepositorioCliente repo)
        {
            _repoClientes = repo;
        }
        public IEnumerable<ClienteDTO> GetAll()
        {
            var clientesOrigen = _repoClientes.GetAll();
            if (clientesOrigen == null || clientesOrigen.Count() == 0)
            {
                throw new ClienteNuloException("No hay clientes registrados");
            }
            return ClientesMappers.FromLista(clientesOrigen);
        }

        public IEnumerable<ClienteDTO> GetXMontoSuperado(double monto)
        {
            var clientesOrigen = _repoClientes.GetClientesPedidoSupereMonto(monto);
            if (clientesOrigen == null || clientesOrigen.Count() == 0)
            {
                throw new ClienteNuloException("No hay clientes registrados");
            }
            return ClientesMappers.FromLista(clientesOrigen);
        }

        public ClienteDTO GetXRazonSocial(string razon)
        {
            var clientesOrigen = _repoClientes.GetClientePorRazon(razon);
            if (clientesOrigen == null)
            {
                throw new ClienteNuloException("No hay clientes registrados con esa razon social.");
            }
            return ClientesMappers.ToDto(clientesOrigen);
        }
    }
}
