using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleApp.Core.Interfaces.Models;

namespace SampleApp.Services
{
    public class Result : IResult
    {
        public bool WasSuccessful { get; set; }
        public string Message { get; set; }
        public int ResultId { get; set; }
        public IList<string> Messages { get; set; }
        public IResult ReturnError(string message = "")
        {
            this.Message = message ?? "There was an error processing this request";
            this.WasSuccessful = false;
            return this;
        }

        public IResult ReturnSuccess(string message = "", int id = -1)
        {
            this.WasSuccessful = true;
            this.Message = message ?? "Completed successfully";
            this.ResultId = id;
            return this;
        }
    }
}
