using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente
{
    public class ClienteDuplicadoException : Exception
    {
        public ClienteDuplicadoException()
        {
        }

        public ClienteDuplicadoException(string? message) : base(message)
        {
        }

        public ClienteDuplicadoException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected ClienteDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
