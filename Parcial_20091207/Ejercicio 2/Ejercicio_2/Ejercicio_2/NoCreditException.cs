using System;
using System.Runtime.Serialization;

namespace Ejercicio_2
{
    [Serializable]
    internal class NoCreditException : Exception
    {
        public NoCreditException()
        {
        }

        public NoCreditException(string message) : base(message)
        {
        }

        public NoCreditException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NoCreditException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}