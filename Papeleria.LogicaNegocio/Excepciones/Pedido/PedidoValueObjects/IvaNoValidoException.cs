using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Pedido.PedidoValueObjects
{
    public class IvaNoValidoException : Exception
    {
        public IvaNoValidoException()
        {
        }

        public IvaNoValidoException(string? message) : base(message)
        {
        }

        public IvaNoValidoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IvaNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
