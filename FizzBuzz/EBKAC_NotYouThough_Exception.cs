using System;
using System.Runtime.Serialization;

namespace FizzBuzz
{
    [Serializable]
    internal class EBKAC_NotYouThough_Exception : Exception
    {
        public EBKAC_NotYouThough_Exception()
        {
        }

        public EBKAC_NotYouThough_Exception(string? message) : base(message)
        {
        }

        public EBKAC_NotYouThough_Exception(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EBKAC_NotYouThough_Exception(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}