using DemoModels.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        [Route("GetEmployees")]
        public IActionResult GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            Employee employee = new Employee();
            employee.EmpId = 1;
            employee.Name   = "Test";
            employees.Add(employee);

            employee.EmpId = 2;
            employee.Name = "Test2";
            employees.Add(employee);

            employee.EmpId = 3;
            employee.Name = "Test3";
            employees.Add(employee);

            return Ok(employees);
        }
    }
}
