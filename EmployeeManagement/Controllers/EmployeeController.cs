using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployee _employee;
        public EmployeeController(IEmployee employee )
        {
            _employee = employee;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Post()
        {
            return new string[] { "Value 1", "Value 2" };
        }
        [HttpPost]
        public IActionResult AddEmployee(EmployeeModel employeeModel )
        {
            var response  =  _employee.AddEmployeeAsync(employeeModel);
            return Ok(response);
            
        }
    }
}