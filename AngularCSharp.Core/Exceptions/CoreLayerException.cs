using System;

namespace AngularCSharp.Core.Exceptions
{
    public class CoreLayerException : Exception
    {
        public CoreLayerException()
        {
        }

        public CoreLayerException(string message) : base(message)
        {
        }

        public CoreLayerException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
