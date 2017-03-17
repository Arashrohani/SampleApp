using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using SampleApp.Business;

namespace SampleApp.Web.Api
{
    [Route("api/employee")]
    [EnableCors("AllowNG2Origin")]
    public class EmployeeApiController : Controller
    {
        public IActionResult Get()
        {
            try
            {
                return Ok(new
                {
                    data = new EmployeeData().GetAllEmployees()
                });
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
