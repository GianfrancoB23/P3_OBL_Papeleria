using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaNegocio.Excepciones.Pedido;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.EF.ToDelete
{
    public class RepositorioComunesEF : IRepositorioComun
    {
        private PapeleriaContext _db = new PapeleriaContext();
        public void Add(Comunes obj)
        {
            try
            {
                _db.Comuns.Add(obj);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new PedidoNoValidoException(ex.Message);
            }
        }

        public IEnumerable<Comunes> GetAll()
        {
            return _db.Comuns.ToList();
        }

        public Comunes GetById(int id)
        {
            Comunes? comun = _db.Comuns.FirstOrDefault(pedido => pedido.Id == id);
            return comun;
        }

        public IEnumerable<Comunes> GetObjectsByID(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Comunes obj)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Comunes obj)
        {
            throw new NotImplementedException();
        }
    }
}
