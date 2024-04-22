using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaAplicacion.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.ImplementacionCasosUso.Usuarios
{
    public class BuscarUsuario : IListar<Usuario>
    {
        public IEnumerable<Usuario> ListarPorNombre(string name)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> ListarSeleccionPorId(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> ListarTodo()
        {
            throw new NotImplementedException();
        }

        public Usuario ListarUno(int id)
        {
            throw new NotImplementedException();
        }

        public Usuario ListarUnoPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}

