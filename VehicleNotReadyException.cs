using System;
using System.Runtime.Serialization;

namespace _1703__hw___CarInGarageWithNewException
{
    [Serializable]
    public class VehicleNotReadyException : ApplicationException
    {
        public VehicleNotReadyException()
        {
        }

        public VehicleNotReadyException(string message) : base(message)
        {
        }

        public VehicleNotReadyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected VehicleNotReadyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}