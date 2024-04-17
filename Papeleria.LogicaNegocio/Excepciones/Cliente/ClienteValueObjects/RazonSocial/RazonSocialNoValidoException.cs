using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial
{
    public class RazonSocialNoValidoException : Exception
    {
        public RazonSocialNoValidoException() { }

        public RazonSocialNoValidoException(string? message) : base(message) { }

        public RazonSocialNoValidoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected RazonSocialNoValidoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
