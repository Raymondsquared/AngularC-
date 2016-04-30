using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularCSharp.Core.Exceptions
{
    public class InfrastructureLayerException : Exception
    {
        public InfrastructureLayerException()
        {
        }

        public InfrastructureLayerException(string message) : base(message)
        {
        }

        public InfrastructureLayerException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
