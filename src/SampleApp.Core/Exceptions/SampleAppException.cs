using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Core.Exceptions
{
    public class SampleAppException : Exception
    {
        public SampleAppException()
        {
        }

        public SampleAppException(string message) : base(message)
        {
        }

        public SampleAppException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
