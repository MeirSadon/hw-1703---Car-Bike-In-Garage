using System;
using System.Runtime.Serialization;

namespace _1703__hw___CarInGarageWithNewException
{
    [Serializable]
    public class WeDoNotFixTotalLostException : ApplicationException
    {
        public WeDoNotFixTotalLostException()
        {
        }

        public WeDoNotFixTotalLostException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLostException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLostException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}