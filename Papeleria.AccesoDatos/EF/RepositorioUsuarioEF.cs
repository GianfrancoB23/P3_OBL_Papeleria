using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioUsuarioEF : IRepositorioUsuario
    {
        private PapeleriaContext _db=new PapeleriaContext();
        public void Add(Usuario obj)
        {
            _db.Usuarios.Add(obj);
            _db.SaveChanges();
        }

        public IEnumerable<Usuario> GetAll()
        {
            return _db.Usuarios.ToList();
        }

        public Usuario GetById(int id)
        {
            Usuario? usuario = _db.Usuarios.FirstOrDefault(usr => usr.Id == id);
            return usuario;
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Usuario obj)
        {
            throw new NotImplementedException();
        }
        public Usuario GetUsuarioPorEmail(EmailUsuario email)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetUsuarios()
        {
            throw new NotImplementedException();
        }

        public Usuario GetUsuario(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Usuario> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }
    }
}
