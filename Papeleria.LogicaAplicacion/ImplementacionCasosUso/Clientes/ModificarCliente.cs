using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Clientes
{
    public class ModificarCliente : IModificarCliente
    {
        private IRepositorioCliente _repoClientes;

        public ModificarCliente(IRepositorioCliente repo)
        {
            _repoClientes = repo;
        }

        public void Ejecutar(int id, ClienteDTO clienteModificado)
        {
            if (clienteModificado == null)
                throw new ClienteNoValidoException("Cliente no puede ser nulo.");
            try
            {
                var cliente = ClientesMappers.FromDtoUpdate(clienteModificado);
                _repoClientes.Update(id, cliente);
            }
            catch (Exception ex)
            {
                throw new UsuarioNoValidoExcepcion(ex.Message);
            }

        }
    }
}
