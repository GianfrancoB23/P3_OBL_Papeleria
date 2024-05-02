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
        public IEnumerable<ClienteListadosDto> GetAll();
        public ClienteListadosDto GetXRazonSocial(string razon);
        public IEnumerable<ClienteListadosDto> GetXMontoSuperado(double monto);
    }
}
