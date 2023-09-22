using System;
using System.Runtime.Serialization;

namespace E_videoteka
{
    [Serializable]
    internal class ValidacijaPrijaveException : Exception
    {
        public ValidacijaPrijaveException()
        {
        }

        public ValidacijaPrijaveException(string message) : base(message)
        {
        }

        public ValidacijaPrijaveException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ValidacijaPrijaveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}