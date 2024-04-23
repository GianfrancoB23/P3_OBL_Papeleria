using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuario
{
    public class UsuarioAltaDto
    {
        [Required]
        public string Email { get; set; }

        public string Nombre{ get; set; }
        public string Apellido{ get; set; }
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contrasenia { get; set; }
    }
}
