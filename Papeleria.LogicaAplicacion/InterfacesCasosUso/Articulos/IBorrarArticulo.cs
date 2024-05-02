using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Articulos
{
    public interface IBorrarArticulo
    {
        void Ejecutar(int id, ArticuloBorrarDto usu);
    }
}
