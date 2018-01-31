using System;
using System.Runtime.Serialization;

namespace SimpleChess
{
    [Serializable]
    internal class BadRankException : Exception
    {
        public BadRankException()
        {
        }

        public BadRankException(string message) : base(message)
        {
        }

        public BadRankException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BadRankException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}