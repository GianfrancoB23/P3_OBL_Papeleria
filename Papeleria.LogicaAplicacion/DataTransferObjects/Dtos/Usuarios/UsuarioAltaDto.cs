using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario
{
    public class UsuarioAltaDto
    {
        public string Email { get; set; }

        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        public string Contrasenia { get; set; }
    }
}
