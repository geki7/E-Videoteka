using System;
using System.Runtime.Serialization;

namespace E_videoteka
{
    [Serializable]
    internal class PasswordMissMatchException : Exception
    {
        public PasswordMissMatchException()
        {
        }

        public PasswordMissMatchException(string message) : base(message)
        {
        }

        public PasswordMissMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PasswordMissMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}