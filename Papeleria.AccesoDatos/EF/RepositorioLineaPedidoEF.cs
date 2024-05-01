using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF
{
    public class RepositorioLineaPedidoEF : IRepositorioLineaPedido
    {
        private PapeleriaContext _db { get; set; }
        public RepositorioLineaPedidoEF(PapeleriaContext db)
        {
            _db = db;
        }

        public void Add(LineaPedido obj)
        {
            try
            {
                _db.LineasPedidos.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new ClienteNoValidoException(ex.Message);
            }
        }

        public LineaPedido Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LineaPedido> GetAll()
        {
            return _db.LineasPedidos.ToList();
        }

        public IEnumerable<LineaPedido> GetByArticulo(Articulo articulo)
        {
            throw new NotImplementedException();
        }

        public LineaPedido GetById(int id)
        {
            LineaPedido? lineaPedido= _db.LineasPedidos.FirstOrDefault(lnPd => lnPd.Id == id);
            return lineaPedido;
        }

        public IEnumerable<LineaPedido> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(LineaPedido obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, LineaPedido obj)
        {
            throw new NotImplementedException();
        }
    }
}
