using System;
using System.Runtime.Serialization;

namespace _1703__hw___CarInGarageWithNewException
{
    [Serializable]
    public class RepairMisMatchException : ApplicationException
    {
        public RepairMisMatchException()
        {
        }

        public RepairMisMatchException(string message) : base(message)
        {
        }

        public RepairMisMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMisMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}