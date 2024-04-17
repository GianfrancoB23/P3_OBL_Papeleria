using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RUT
{
    public class RutNuloException : Exception
    {
        public RutNuloException() { }

        public RutNuloException(string? message) : base(message) { }

        public RutNuloException(string? message, Exception? innerException) : base(message, innerException) { }

        protected RutNuloException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
