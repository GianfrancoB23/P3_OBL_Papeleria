using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.AccesoDatos.Memoria;
using Papeleria.AccesoDatos.EF;

namespace Papeleria.Test
{
    internal class Program
    {
        static IRepositorioUsuario _repoUsuarios = new RepositorioUsuarioEF();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Email");
            string email = Console.ReadLine();
            Console.WriteLine("Nombre");
            string nom = Console.ReadLine();
            Console.WriteLine("Apellido");
            string ape = Console.ReadLine();
            Console.WriteLine("Contraseña");
            string pass = Console.ReadLine();

            Usuario usuario = new Usuario(email,nom,ape,pass);
            AgregarUsuario(usuario);
        }
        static void AgregarUsuario(Usuario usuario)
        {
            try
            {
                _repoUsuarios.Add(usuario);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
