using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.Direccion
{
    public class DireccionDuplicadoException : Exception
    {
        public DireccionDuplicadoException() { }

        public DireccionDuplicadoException(string? message) : base(message) { }

        public DireccionDuplicadoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected DireccionDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
