using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente
{
    public class ClienteNuloException : Exception
    {
        public ClienteNuloException()
        {
        }

        public ClienteNuloException(string? message) : base(message)
        {
        }

        public ClienteNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ClienteNuloException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
