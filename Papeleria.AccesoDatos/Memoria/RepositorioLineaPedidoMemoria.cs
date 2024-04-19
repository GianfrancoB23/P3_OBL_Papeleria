using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades;
using Papeleria.LogicaNegocio.InterfacesRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.AccesoDatos.Memoria
{
    public class RepositorioLineaPedidoMemoria : IRepositorioLineaPedido
    {
        public void Add(LineaPedido obj)
        {
            throw new NotImplementedException();
        }

        public LineaPedido Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LineaPedido> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LineaPedido> GetByArticulo(Articulo articulo)
        {
            throw new NotImplementedException();
        }

        public LineaPedido GetById(int id)
        {
            throw new NotImplementedException();
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
