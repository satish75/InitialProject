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
        [Route("add")]
        public IActionResult AddEmployee(EmployeeModel employeeModel )
        {
            var response  =  _employee.AddEmployeeAsync(employeeModel);
            return Ok(response);
            
        }
        [HttpPost]
        [Route("update")]
        public IActionResult UpdateEmployee(EmployeeModel employeeModel)
        {
            var response = _employee.UpdateEmployeeAsync(employeeModel);
            return Ok(response);

        }

        [HttpDelete]
        [Route("delete")]
        public IActionResult DeleteEmployee(EmployeeModel employeeModel)
        {
            var response = _employee.DeleteEmployeeAsync(employeeModel);
            return Ok(response);
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetEmployee(int id)
        {
            var response = _employee.GetByIdEmployeeAsync(id);
            return Ok(response);
        }

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllEmployee()
        {
            var response = _employee.GetAllEmployeeAsync();
            return Ok(response);
        }
    }
}