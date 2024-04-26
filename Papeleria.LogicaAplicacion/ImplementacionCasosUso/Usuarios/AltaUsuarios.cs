using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario;
using Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos;
using Papeleria.LogicaAplicacion.Interaces;
using Papeleria.LogicaAplicacion.InterfacesCasosUso.Usuarios;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class AltaUsuarios : IAltaUsuario
    {
        private IRepositorioUsuario _repoUsuarios;

        public AltaUsuarios(IRepositorioUsuario repo)
        {
            _repoUsuarios = repo;
        }

        public void Ejecutar(UsuarioAltaDto dto)
        {
            if (dto == null)
                throw new UsuarioNuloExcepcion("Nulo");

            Usuario usuario = UsuariosMappers.FromDto(dto);
            _repoUsuarios.Add(usuario);
        }
    }
}
