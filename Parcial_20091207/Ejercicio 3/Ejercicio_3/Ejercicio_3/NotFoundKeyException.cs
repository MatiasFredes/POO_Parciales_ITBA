using System;
using System.Runtime.Serialization;

namespace Ejercicio_3
{
    [Serializable]
    internal class NotFoundKeyException : Exception
    {
        public NotFoundKeyException()
        {
        }

        public NotFoundKeyException(string message) : base(message)
        {
        }

        public NotFoundKeyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotFoundKeyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}