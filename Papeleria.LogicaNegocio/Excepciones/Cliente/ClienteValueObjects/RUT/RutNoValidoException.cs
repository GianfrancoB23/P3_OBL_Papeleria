using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT
{
    public class RutNoValidoException : Exception
    {
        public RutNoValidoException() { }

        public RutNoValidoException(string? message) : base(message) { }

        public RutNoValidoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected RutNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
