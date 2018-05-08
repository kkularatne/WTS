using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTS.Data;
using WTS.DTOs;
using WTS.Models;
using WTS.Services;

namespace WTS.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

       private readonly IEmployeeService employeeService;

        public ValuesController( IEmployeeService service) {
            
            employeeService = service;
        }

        // GET api/values
        //[HttpGet]
        //public IEnumerable<EmployeeDto> Get()
        //{
        //    return employeeService.Test();
        //}

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
