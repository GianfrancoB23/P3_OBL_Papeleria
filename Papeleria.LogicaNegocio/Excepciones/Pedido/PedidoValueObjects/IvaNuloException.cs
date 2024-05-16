using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Pedido.PedidoValueObjects
{
    public class IvaNuloException : Exception
    {
        public IvaNuloException()
        {
        }

        public IvaNuloException(string? message) : base(message)
        {
        }

        public IvaNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IvaNuloException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
