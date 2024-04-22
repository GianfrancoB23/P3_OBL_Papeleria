using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Articulos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Papeleria.LogicaNegocio.Entidades;
using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos
{
    public class UsuariosMappers
    {
        public Usuario FromDto(UsuarioAltaDto dto) {
            if (dto == null) throw new UsuarioNuloExcepcion("Los datos del DTO son nulos");
            return new Usuario(dto.Email,dto.Nombre,dto.Apellido,dto.Contrasenia);
        }

        public UsuarioListadosDto ToDto(Usuario usuario) {
            if (usuario == null) throw new UsuarioNuloExcepcion();
            return new UsuarioListadosDto()
            {
                Id = usuario.Id,
                Email = usuario.Email.Direccion,
                Nombre = usuario.NombreCompleto.Nombre,
                Apellido = usuario.NombreCompleto.Apellido,
                Contrasenia = usuario.Contrasenia.Valor
            };
        }
        //https://vimeopro.com/universidadortfi/fi-5212-programacion-3-cabella-69235-p3-m3a-remoto/video/929607409
        //1:36:07

    }
}
