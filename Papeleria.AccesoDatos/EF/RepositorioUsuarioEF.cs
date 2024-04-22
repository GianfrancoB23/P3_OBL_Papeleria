using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Microsoft.EntityFrameworkCore;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Clientes;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using Papeleria.LogicaNegocio.Excepciones.Usuario.UsuarioExcepcions.Constrasenia;
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
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Usuario obj)
        {
            try
            {
                _db.Usuarios.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new UsuarioNoValidoExcepcion(ex.Message);
            }
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
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Id == id);
            if (usuario != null)
            {
                _db.Usuarios.Remove(usuario);
                _db.SaveChanges();
            }
        }

        public void Remove(Usuario obj)
        {
            _db.Usuarios.Remove(obj);
            _db.SaveChanges();
        }

        public void Update(int id, Usuario obj)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                try
                {
                    usuario.NombreCompleto = new NombreCompleto(obj.NombreCompleto.Nombre, obj.NombreCompleto.Apellido);
                    usuario.Contrasenia = new ContraseniaUsuario(obj.Contrasenia.Valor);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw new UsuarioNoValidoExcepcion(ex.Message);
                }
            }
            else
            {
                throw new UsuarioNuloExcepcion("El usuario no existe");
            }
        }
        public Usuario GetUsuarioPorEmail(EmailUsuario email)
        {
            return _db.Usuarios.FirstOrDefault(u => u.Email.Direccion == email.Direccion);
        }

        public IEnumerable<Usuario> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void ModificarContrasenia(int id, ContraseniaUsuario contraseniaNueva)
        {
            var usuario = _db.Usuarios.FirstOrDefault(u => u.Id == id);

            if (usuario != null)
            {
                try
                {
                    usuario.Contrasenia = new ContraseniaUsuario(contraseniaNueva.Valor);
                    _db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ContraseniaNoValidoException(ex.Message);
                }
            }
            else
            {
                throw new UsuarioNuloExcepcion("El usuario no existe");
            }
        }
    }
}
