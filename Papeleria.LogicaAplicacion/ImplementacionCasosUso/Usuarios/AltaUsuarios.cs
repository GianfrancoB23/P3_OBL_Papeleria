using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaAplicacion.Interaces;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class AltaUsuarios : IAlta<Usuario>
    {
        private IRepositorioUsuario _repo = new RepositorioUsuarioEF();
        private IListar<Usuario> _buscarUsuario = new BuscarUsuario();

        public void Crear(Usuario obj)
        {
            if (_buscarUsuario.ListarUno(obj.Id) == null)
                _repo.Add(obj);
            else
                throw new UsuarioDuplicadoExcepcion("Duplicado");
        }
    }
}
