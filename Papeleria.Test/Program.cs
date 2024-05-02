using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.AccesoDatos.Memoria;
using Papeleria.AccesoDatos.EF;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Usuario;
using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades.ValueObjects.Pedidos;

namespace Papeleria.Test
{
    internal class Program
    {
        static IRepositorioUsuario _repoUsuarios = new RepositorioUsuarioEF(new PapeleriaContext());
        static IRepositorioPedido _repoPedidos = new RepositorioPedidoEF(new PapeleriaContext());
        static IRepositorioCliente _repoClientes = new RepositorioClienteEF(new PapeleriaContext(), _repoPedidos);
        static IRepositorioLineaPedido _repoLineasPedidos = new RepositorioLineaPedidoEF(new PapeleriaContext());
        static IRepositorioArticulo _repoArticulo = new RepositorioArticuloEF(new PapeleriaContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Articulo a = new Articulo(1234567898765, "papa", "ssssssssss", 1500, 20);
            AgregarArticulo(a);

            Cliente c = new Cliente(123456789101, "Pepsi Sociedad Anonima", "Avenida Millan", 5285, "Montevideo");
            //Express pedido = new Express(c, 3, new IVA(22), new LineaPedido(a, 10), true);

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
            //AgregarCliente(c);
           // AgregarPedido((Pedido) pedido);
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
        static void AgregarArticulo(Articulo articulo)
        {
            try
            {
                _repoArticulo.Add(articulo);
            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void AgregarPedido(Pedido pedido)
        {
            try
            {
                _repoPedidos.Add(pedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void AgregarLineaPedido(LineaPedido lineaPedido)
        {
            try
            {
                _repoLineasPedidos.Add(lineaPedido);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
        static void AgregarCliente(Cliente cliente)
        {
            try
            {
                _repoClientes.Add(cliente);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
