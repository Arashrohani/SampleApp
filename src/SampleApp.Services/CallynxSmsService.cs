using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.Interfaces.Models;
using SampleApp.Core.Interfaces.Services;

namespace SampleApp.Services
{
    public class CallynxSmsService : ISms
    {
        
        public IResult SendSmsTo(string number, string message)
        {
            throw new NotImplementedException();
        }

        public IResult SendSmsToSupport(string number, string message)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> SendSmsToAsync(string number, string message)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> SendSmsToSupportAsync(string number, string message)
        {
            throw new NotImplementedException();
        }
    }
}
