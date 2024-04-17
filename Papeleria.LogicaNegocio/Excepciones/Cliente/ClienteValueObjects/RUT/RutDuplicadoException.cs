using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT
{
    public class RutDuplicadoException : Exception
    {
        public RutDuplicadoException() { }

        public RutDuplicadoException(string? message) : base(message) { }

        public RutDuplicadoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected RutDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
