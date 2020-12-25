using System;
using System.Runtime.Serialization;

namespace Ejercicio_2
{
    [Serializable]
    internal class DisableCellPhoneException : Exception
    {
        public DisableCellPhoneException()
        {
        }

        public DisableCellPhoneException(string message) : base(message)
        {
        }

        public DisableCellPhoneException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DisableCellPhoneException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}