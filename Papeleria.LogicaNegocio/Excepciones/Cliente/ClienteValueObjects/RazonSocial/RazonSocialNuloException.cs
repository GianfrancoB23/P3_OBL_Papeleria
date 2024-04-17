using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Papeleria.LogicaNegocio.Excepciones.Cliente.ClienteValueObjects.RazonSocial
{
    public class RazonSocialNuloException : Exception
    {
        public RazonSocialNuloException()
        {
        }

        public RazonSocialNuloException(string? message) : base(message)
        {
        }

        public RazonSocialNuloException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected RazonSocialNuloException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
