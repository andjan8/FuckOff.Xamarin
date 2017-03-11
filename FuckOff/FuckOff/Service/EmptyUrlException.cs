using System;

namespace FuckOff.Service
{
    public class EmptyUrlException : Exception
    {
        public EmptyUrlException()
        {
        }

        public EmptyUrlException(string message) : base(message)
        {
        }

        public EmptyUrlException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}