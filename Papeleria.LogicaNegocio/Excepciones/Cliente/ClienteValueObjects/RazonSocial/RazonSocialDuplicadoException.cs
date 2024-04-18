using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial
{
    public class RazonSocialDuplicadoException : Exception
    {
        public RazonSocialDuplicadoException() { }

        public RazonSocialDuplicadoException(string? message) : base(message) { }

        public RazonSocialDuplicadoException(string? message, Exception? innerException) : base(message, innerException) { }

        protected RazonSocialDuplicadoException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}

