using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaAplicacion.Interaces;
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
        private IRepositorioUsuario _repo;

        public AltaUsuarios(IRepositorioUsuario repo)
        {
            _repo = repo;
        }

        public void Crear(Usuario obj)
        {
            _repo.Add(obj);
        }
    }
}
