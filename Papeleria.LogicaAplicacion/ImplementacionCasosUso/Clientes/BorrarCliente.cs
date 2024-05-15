using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
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
    public class BorrarCliente : IBorrarCliente
    {
        private IRepositorioCliente _repoCliente;

        public BorrarCliente(IRepositorioCliente repo)
        {
            _repoCliente = repo;
        }

        public void Ejecutar(int id, ClienteDTO clienteBorrar)
        {
            if (clienteBorrar == null)
                throw new ClienteNuloException("Usuario no puede ser nulo.");
            try
            {
                var usuario = _repoCliente.GetById(clienteBorrar.Id);
                _repoCliente.Remove(usuario);
            }
            catch (Exception ex)
            {
                throw new UsuarioNoValidoExcepcion(ex.Message);
            }
        }
    }
}

