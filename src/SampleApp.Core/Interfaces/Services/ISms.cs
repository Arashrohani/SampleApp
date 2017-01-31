using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.Interfaces.Models;

namespace SampleApp.Core.Interfaces.Services
{
    public interface ISms
    {
        IResult SendSmsTo(string number, string message);
        IResult SendSmsToSupport(string number, string message);
        Task<IResult> SendSmsToAsync(string number, string message);
        Task<IResult> SendSmsToSupportAsync(string number, string message);
    }
}
