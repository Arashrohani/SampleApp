using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleApp.Core.Interfaces.Models
{
    public interface IBaseResult
    {
        bool WasSuccessful { get; set; }
        string Message { get; set; }
        int ResultId { get; set; }
        IList<string> Messages { get; set; }
    }
}
