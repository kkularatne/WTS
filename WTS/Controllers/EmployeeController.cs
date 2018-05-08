using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WTS.DTOs;
using WTS.Services;

namespace WTS.Controllers
{
    [Produces("application/json")]
    [Route("api/Employee")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService employeeService;

        public EmployeeController(IEmployeeService service)
        {

            employeeService = service;
        }

        [HttpGet]
        public IEnumerable<EmployeeDto> Get()
        {
            return employeeService.getShiftDetails();
        }

    }
}