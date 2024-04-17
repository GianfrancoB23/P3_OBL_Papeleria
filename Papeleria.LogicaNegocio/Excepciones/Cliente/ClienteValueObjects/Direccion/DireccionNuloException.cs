using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.Direccion
{
    public class DireccionNuloException : Exception
    {
        public DireccionNuloException() { }

        public DireccionNuloException(string? message) : base(message) { }

        public DireccionNuloException(string? message, Exception? innerException) : base(message, innerException) { }

        protected DireccionNuloException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
