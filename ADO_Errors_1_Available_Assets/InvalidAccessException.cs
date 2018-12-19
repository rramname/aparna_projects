using System;
using System.Runtime.Serialization;

namespace ADO_Errors_1_Available_Assets
{
    [Serializable]
    internal class InvalidAccessException : Exception
    {
        public InvalidAccessException()
        {
        }

        public InvalidAccessException(string message) : base(message)
        {
        }
    }
}