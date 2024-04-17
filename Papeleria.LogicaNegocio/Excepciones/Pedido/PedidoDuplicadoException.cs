using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Pedido
{
    public class PedidoDuplicadoException : Exception
    {
        public PedidoDuplicadoException()
        {
        }

        public PedidoDuplicadoException(string? message) : base(message)
        {
        }

        public PedidoDuplicadoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PedidoDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
