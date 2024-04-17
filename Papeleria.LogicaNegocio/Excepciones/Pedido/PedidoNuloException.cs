using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Pedido
{
    public class PedidoNuloException : Exception
    {
        public PedidoNuloException()
        {
        }

        public PedidoNuloException(string? message) : base(message)
        {
        }

        public PedidoNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected PedidoNuloException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
