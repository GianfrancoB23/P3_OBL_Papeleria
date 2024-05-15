using Empresa.LogicaDeNegocio.Entidades;
using Empresa.LogicaDeNegocio.Sistema;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Clientes;
using Papeleria.LogicaAplicacion.DataTransferObjects.Dtos.Usuarios;
using Papeleria.LogicaNegocio.Excepciones.Cliente;
using Papeleria.LogicaNegocio.Excepciones.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaAplicacion.DataTransferObjects.MapeosDatos
{
    public class ClientesMappers
    {
        public static Cliente FromDto(ClienteDTO dto)
        {
            if (dto == null) throw new UsuarioNuloExcepcion(nameof(dto));
            return new Cliente(dto.rut, dto.razonSocial, dto.Calle, dto.Numero, dto.Ciudad);
        }
        public static ClienteDTO ToDto(Cliente cliente)
        {
            if (cliente == null)
                throw new ClienteNuloException("El cliente no puede ser nulo.");
            return new ClienteDTO()
            {
                Id = cliente.Id,
                rut = cliente.rut.Rut,
                razonSocial = cliente.razonSocial.RazonSoc,
                Calle = cliente.direccion.Calle,
                Numero = cliente.direccion.Numero,
                Ciudad = cliente.direccion.Ciudad,
                Distancia = cliente.direccion.Distancia

            };
        }

        public static IEnumerable<ClienteDTO> FromLista(IEnumerable<Cliente> clientes)
        {
            if (clientes == null)
            {
                throw new UsuarioNuloExcepcion("La lista de usuarios no puede ser nula");
            }
            return clientes.Select(cliente => ToDto(cliente));
        }
    }
}
