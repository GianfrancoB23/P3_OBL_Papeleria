using Empresa.LogicaDeNegocio.Entidades;
using Papeleria.LogicaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.InterfacesRepositorio
{
    public interface IRepositorioLineaPedido:IRepositorio<LineaPedido>
    {
        public IEnumerable<LineaPedido> GetAll();
        public LineaPedido Get(int id);
        public IEnumerable<LineaPedido> GetByArticulo(Articulo articulo);

    }
}
