using System;
using System.Runtime.Serialization;

namespace E_videoteka
{
    [Serializable]
    public class EmptyInputException : Exception
    {
        public EmptyInputException()
        {
        }

        public EmptyInputException(string message) : base(message)
        {
        }

        public EmptyInputException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EmptyInputException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}