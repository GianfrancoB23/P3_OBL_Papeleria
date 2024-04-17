using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.Direccion
{
    public class DireccionNoValidoException : Exception
    {
        public DireccionNoValidoException() { }

        public DireccionNoValidoException(string? message) : base(message) { }

        public DireccionNoValidoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected DireccionNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
