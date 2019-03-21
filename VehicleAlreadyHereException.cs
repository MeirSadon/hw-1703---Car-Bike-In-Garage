using System;
using System.Runtime.Serialization;

namespace _1703__hw___CarInGarageWithNewException
{
    [Serializable]
    public class VehicleAlreadyHereException : ApplicationException
    {
        public VehicleAlreadyHereException()
        {
        }

        public VehicleAlreadyHereException(string message) : base(message)
        {
        }

        public VehicleAlreadyHereException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleAlreadyHereException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}