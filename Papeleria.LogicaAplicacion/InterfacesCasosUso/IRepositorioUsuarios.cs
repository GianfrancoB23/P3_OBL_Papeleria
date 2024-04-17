using Empresa.LogicaDeNegocio.InterfacesRepositorios;
using Empresa.LogicaDeNegocio.Sistema;
using IEmpresa.AccesoDatos.RepositorioMemoria;
using IEmpresa.AccesoDatos.RepostiorioEF;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;

namespace Empresa.LogicaDeNegocio.InterfacesRepositorios
{
	public interface IRepositorioUsuarios : IRepositorio<Usuario>
    {
		public IEnumerable<Usuario> GetUsuarios();

		public Usuario GetUsuario(int id);
		public Usuario GetUsuario(string id);
		public Usuario GetUsuario(Usuario usuario);
		public Usuario GetUsuarioByNombreCompleto(NombreCompleto nombre);

	}

}

