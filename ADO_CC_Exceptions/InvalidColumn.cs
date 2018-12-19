using System;
using System.Runtime.Serialization;

namespace ADO_CC_Exceptions
{
    [Serializable]
    internal class InvalidColumn : Exception
    {
        public InvalidColumn()
        {
        }

        public InvalidColumn(string message) : base(message)
        {
        }

        public InvalidColumn(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InvalidColumn(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}