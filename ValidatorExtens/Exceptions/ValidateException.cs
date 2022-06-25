using System;
using System.Runtime.Serialization;

namespace ValidatorExtens.Exceptions
{
    public sealed class ValidateException : Exception
    {
        public ValidateException()
        {
        }

        public ValidateException(string message) : base(message)
        {
        }

        public ValidateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public ValidateException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
