using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.InterfacesCasosUso.Clientes
{
    public interface IBuscarClientes
    {
        public IEnumerable<ClienteDTO> GetAll();
        public ClienteDTO GetXRazonSocial(string razon);
        public IEnumerable<ClienteDTO> GetXMontoSuperado(double monto);
    }
}
